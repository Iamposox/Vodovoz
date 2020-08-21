using System;
using System.Collections.Generic;
using System.Linq;
using QS.Commands;
using QS.Dialog;
using QS.DomainModel.Entity;
using QS.DomainModel.Entity.EntityPermissions.EntityExtendedPermission;
using QS.DomainModel.NotifyChange;
using QS.DomainModel.UoW;
using QS.Navigation;
using QS.Project.Domain;
using QS.Project.Journal.EntitySelector;
using QS.Services;
using QS.ViewModels;
using Vodovoz.Domain.Cash;
using Vodovoz.Domain.Employees;
using Vodovoz.Domain.Logistic;
using Vodovoz.EntityRepositories.Cash;
using Vodovoz.Infrastructure.Services;
using Vodovoz.PermissionExtensions;
using Vodovoz.Services;
using Vodovoz.TempAdapters;

namespace Vodovoz.ViewModels.Dialogs.Cash
{
	public class CashIncomeViewModel : EntityTabViewModelBase<Income>
	{
		private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

		private readonly IEmployeeService employeeService;
		private readonly IEntityExtendedPermissionValidator entityExtendedPermissionValidator;
		private readonly IReportViewOpener reportViewOpener;
		private readonly IEntityChangeWatcher entityChangeWatcher;
		private readonly ICashCategoryRepository cashCategoryRepository;
		private readonly IEmployeeJournalFactory employeeJournalFactory;
		private readonly ICounterpartyJournalFactory counterpartyJournalFactory;
		private readonly IAvailableCashSubdivisionProvider availableCashSubdivisionProvider;
		private readonly IInteractiveService interactiveService;
		private readonly IUserService userService;

		private IPermissionResult permissionResult;
		private bool canEditRectroactively;

		public CashIncomeViewModel(
			IEntityUoWBuilder uowBuilder, 
			IUnitOfWorkFactory unitOfWorkFactory,
			IEmployeeService employeeService,
			IEntityExtendedPermissionValidator entityExtendedPermissionValidator,
			IReportViewOpener reportViewOpener,
			ICommonServices commonServices,
			IEntityChangeWatcher entityChangeWatcher,
			ICashCategoryRepository cashCategoryRepository,
			IEmployeeJournalFactory employeeJournalFactory,
			ICounterpartyJournalFactory counterpartyJournalFactory,
			IAvailableCashSubdivisionProvider availableCashSubdivisionProvider,
			INavigationManager navigation = null)
		: base(uowBuilder, unitOfWorkFactory, commonServices, navigation)
		{
			this.employeeService = employeeService ?? throw new ArgumentNullException(nameof(employeeService));
			this.entityExtendedPermissionValidator = entityExtendedPermissionValidator ?? throw new ArgumentNullException(nameof(entityExtendedPermissionValidator));
			this.reportViewOpener = reportViewOpener ?? throw new ArgumentNullException(nameof(reportViewOpener));
			this.entityChangeWatcher = entityChangeWatcher ?? throw new ArgumentNullException(nameof(entityChangeWatcher));
			this.cashCategoryRepository = cashCategoryRepository ?? throw new ArgumentNullException(nameof(cashCategoryRepository));
			this.employeeJournalFactory = employeeJournalFactory ?? throw new ArgumentNullException(nameof(employeeJournalFactory));
			this.counterpartyJournalFactory = counterpartyJournalFactory ?? throw new ArgumentNullException(nameof(counterpartyJournalFactory));
			this.availableCashSubdivisionProvider = availableCashSubdivisionProvider ?? throw new ArgumentNullException(nameof(availableCashSubdivisionProvider));
			this.interactiveService = commonServices.InteractiveService;
			this.userService = commonServices.UserService;

			if(!ValidateAndSetCashier()) {
				return;
			}

			if(!ValidatePermissions()) {
				return;
			}

			if(!ValidateAndSetAvailableCashSubdivisions()) {
				return;
			}

			if(uowBuilder.IsNewEntity) {
				Entity.Date = DateTime.Now;
			}

			ConfigureDlg();
			SubscribesOnChanges();
		}

		#region Init

		private bool ValidateAndSetCashier()
		{
			if(!UoW.IsNew) {
				return true;
			}
			Entity.Casher = employeeService.GetEmployeeForCurrentUser(UoW);
			if(Entity.Casher == null) {
				interactiveService.ShowMessage(
					ImportanceLevel.Error,
					"Ваш пользователь не привязан к действующему сотруднику, " +
					"вы не можете создавать кассовые документы, " +
					"так как некого указывать в качестве кассира."
				);
				FailInitialize = true;
				return false;
			}
			return true;
		}

		private bool ValidatePermissions()
		{
			permissionResult = CommonServices.PermissionService.ValidateUserPermission(typeof(Income), userService.CurrentUserId);
			if(UoW.IsNew) {
				if(!permissionResult.CanCreate) {
					interactiveService.ShowMessage(
						ImportanceLevel.Error,
						"Отсутствуют права на создание приходного ордера"
					);
					FailInitialize = true;
					return false;
				}
			} else {
				if(!permissionResult.CanRead) {
					interactiveService.ShowMessage(
						ImportanceLevel.Error,
						"Отсутствуют права на просмотр приходного ордера"
					);
					FailInitialize = true;
					return false;
				}

				canEditRectroactively = entityExtendedPermissionValidator.Validate(
					typeof(Income),
					userService.CurrentUserId,
					new RetroactivelyClosePermission()
				);
			}
			return true;
		}

		private bool ValidateAndSetAvailableCashSubdivisions()
		{
			if(UoW.IsNew) {
				availableCashSubdivisions = availableCashSubdivisionProvider.GetAvailableCashSubdivisions(UoW, typeof(Income)).ToList();
				if(!availableCashSubdivisions.Any()) {
					interactiveService.ShowMessage(
							ImportanceLevel.Error,
							"Невозможно создать приходный ордер, так как у вас нет прав ни на одну из касс"
						);
					FailInitialize = true;
					return false;
				}
				Entity.RelatedToSubdivision = availableCashSubdivisions.First();
			} else {
				if(!availableCashSubdivisions.Contains(Entity.RelatedToSubdivision)) {
					availableCashSubdivisions.Add(Entity.RelatedToSubdivision);
				}
			}

			return true;
		}

		private void ConfigureDlg()
		{
			entityChangeWatcher.BatchSubscribeOnEntity<IncomeCategory>((args) => UpdateIncomeCategories());
			entityChangeWatcher.BatchSubscribeOnEntity<ExpenseCategory>((args) => UpdateExpenseCategories());
			UpdateIncomeCategories();
			UpdateExpenseCategories();
		}

		private void SubscribesOnChanges()
		{
			SetPropertyChangeRelation(e => e.TypeOperation, () => TypeOperation);
			SetPropertyChangeRelation(e => e.IsPartialDebtReturn, () => IsPartialDebtReturn);
			SetPropertyChangeRelation(e => e.Employee, () => Employee);
			SetPropertyChangeRelation(e => e.RouteListClosing, () => ClosingRouteList);
		}

		#endregion Init

		protected override void BeforeSave()
		{
			if(Entity.TypeOperation == IncomeType.Return && UoW.IsNew) {
				Entity.CloseAdvances(UoW);
			}
		}

		private IList<Subdivision> availableCashSubdivisions;
		public IEnumerable<Subdivision> AvailableCashSubdivisions => availableCashSubdivisions;

		#region State

		[PropertyChangedAlso(nameof(CanEditMoney), nameof(CanSelectDebts))]
		public bool CanEdit => (UoW.IsNew && permissionResult.CanCreate) ||
								(permissionResult.CanUpdate && Entity.Date.Date == DateTime.Now.Date) ||
								canEditRectroactively;

		public bool CanEditMoney => CanEdit && (!IsDebtReturn || (IsDebtReturn && IsPartialDebtReturn));
		public bool CanSelectDebts => CanEdit && IsDebtReturn && UoW.IsNew;

		public bool IsPayment => Entity.TypeOperation == IncomeType.Payment;

		public bool IsDriverReport => Entity.TypeOperation == IncomeType.DriverReport;

		[PropertyChangedAlso(nameof(CanEditMoney), nameof(CanSelectDebts))]
		public bool IsDebtReturn => Entity.TypeOperation == IncomeType.Return;

		public bool IsCommonIncome => Entity.TypeOperation == IncomeType.Common;

		private IncomeType typeOperation;
		public virtual IncomeType TypeOperation {
			get => typeOperation;
			set {
				if(SetField(ref typeOperation, value)) {
					Entity.TypeOperation = typeOperation;
					RefreshTypeState();
					OnPropertyChanged(nameof(IsPayment));
					OnPropertyChanged(nameof(IsDriverReport));
					OnPropertyChanged(nameof(IsDebtReturn));
					OnPropertyChanged(nameof(IsCommonIncome));
				}
			}
		}

		private void RefreshTypeState()
		{
			Entity.RouteListClosing = null;
			Entity.Description = "";
			Entity.Employee = null;

			switch(TypeOperation) {
				case IncomeType.Common:
					break;
				case IncomeType.Payment:
					break;
				case IncomeType.DriverReport:
					FillForDriverReport();
					break;
				case IncomeType.Return:
					Entity.RefreshDebts(UoW);
					break;
			}
			Entity.Money = 0;
		}

		#endregion State

		#region Cash categories

		private IList<IncomeCategory> incomeCategories;
		public virtual IList<IncomeCategory> IncomeCategories {
			get => incomeCategories;
			set => SetField(ref incomeCategories, value);
		}

		private void UpdateIncomeCategories()
		{
			IncomeCategories = cashCategoryRepository.IncomeCategories(UoW);
		}

		private IList<ExpenseCategory> expenseCategories;
		public virtual IList<ExpenseCategory> ExpenseCategories {
			get => expenseCategories;
			set => SetField(ref expenseCategories, value);
		}

		private void UpdateExpenseCategories()
		{
			ExpenseCategories = cashCategoryRepository.ExpenseCategories(UoW);
		}

		#endregion Cash categories

		#region Selectors

		private IEntityAutocompleteSelectorFactory employeesSelectorFactory;
		public IEntityAutocompleteSelectorFactory EmployeesSelectorFactory {
			get {
				if(employeesSelectorFactory == null) {
					employeesSelectorFactory = employeeJournalFactory.CreateWorkingEmployeeAutocompleteSelectorFactory();
				}
				return employeesSelectorFactory;
			}
		}

		private IEntityAutocompleteSelectorFactory counterpartySelectorFactory;
		public IEntityAutocompleteSelectorFactory CounterpartySelectorFactory {
			get {
				if(counterpartySelectorFactory == null) {
					counterpartySelectorFactory = counterpartyJournalFactory.CreateCounterpartyAutocompleteSelectorFactory();
				}
				return counterpartySelectorFactory;
			}
		}

		#endregion Selectors

		#region Commands

		#region PrintCommand

		private DelegateCommand printCommand;
		public DelegateCommand PrintCommand {
			get {
				if(printCommand == null) {
					printCommand = new DelegateCommand(
						Print,
						() => IsDebtReturn
					);
					printCommand.CanExecuteChangedWith(this, x => x.IsDebtReturn);
				}
				return printCommand;
			}
		}

		private void Print()
		{
			if(UoW.HasChanges && interactiveService.Question($"Перед печатью необходимо сохранить документ. Сохранить?", "Сохранение")) {
				Save();
			}

			var reportInfo = new QS.Report.ReportInfo {
				Title = String.Format("Квитанция №{0} от {1:d}", Entity.Id, Entity.Date),
				Identifier = "Cash.ReturnTicket",
				Parameters = new Dictionary<string, object> {
					{ "id",  Entity.Id }
				}
			};
			reportViewOpener.OpenReport(this, reportInfo);
		}

		#endregion PrintCommand

		#region Save command

		private DelegateCommand saveAndCloseCommand;
		public DelegateCommand SaveAndCloseCommand {
			get {
				if(saveAndCloseCommand == null) {
					saveAndCloseCommand = new DelegateCommand(SaveAndClose);
				}
				return saveAndCloseCommand;
			}
		}

		#endregion Save command

		#region Close command

		private DelegateCommand closeCommand;
		public DelegateCommand CloseCommand {
			get {
				if(closeCommand == null) {
					closeCommand = new DelegateCommand(
						() => Close(true, CloseSource.Cancel)
					);
				}
				return closeCommand;
			}
		}

		#endregion Close command

		#endregion Commands

		#region Driver report

		private RouteList closingRouteList;
		public virtual RouteList ClosingRouteList {
			get => closingRouteList;
			set {
				if(SetField(ref closingRouteList, value)) {
					FillForDriverReport();
				}
			}
		}

		private void FillForDriverReport()
		{
			if(IsDriverReport) {
				var incomeCategory = cashCategoryRepository.RouteListClosingIncomeCategory(UoW);
				Entity.FillForDriverReport(incomeCategory);
			}
		}

		#endregion Driver report

		#region Debts return

		private Employee employee;
		public virtual Employee Employee {
			get => employee;
			set {
				if(SetField(ref employee, value)) {
					Entity.Employee = employee;
					Entity.RefreshDebts(UoW);
				}
			}
		}

		private bool isPartialDebtReturn;
		[PropertyChangedAlso(nameof(CanEditMoney))]
		public virtual bool IsPartialDebtReturn {
			get => isPartialDebtReturn;
			set {
				if(value && Entity.Debts.Count(x => x.Selected) > 1) {
					interactiveService.ShowMessage(ImportanceLevel.Error, "Частично вернуть можно только один аванс.", "Частичный возврат");
					return;
				}
				if(SetField(ref isPartialDebtReturn, value)) {
					Entity.IsPartialDebtReturn = isPartialDebtReturn;
					Entity.UpdateDebtReturnMoney();
				}
			}
		}

		public bool TryFillReturnForAdvance(Expense advance)
		{
			if(advance.Employee == null) {
				logger.Error("Аванс без сотрудника. Для него нельзя открыть диалог возврата.");
				interactiveService.ShowMessage(
					ImportanceLevel.Warning,
					"Невозможно заполнить возврат. Так как в авансе не указан сотрудник",
					"Заполнение возврата по авансу"
				);
				return false;
			}

			TypeOperation = IncomeType.Return;
			Entity.ExpenseCategory = advance.ExpenseCategory;
			Entity.Employee = advance.Employee;
			var foundDebt = Entity.Debts.FirstOrDefault(x => x.Value.Id == advance.Id);
			if(foundDebt != null) {
				foundDebt.Selected = true;
			}
			return true;
		}

		#endregion Debts return

	}
}
