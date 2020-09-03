using System;
using QS.DomainModel.UoW;
using QS.Permissions;
using Vodovoz.Domain.Cash;
using Vodovoz.Domain.Employees;
using Vodovoz.ViewModels.Dialogs.Cash;
using QS.Project.Domain;
using QS.DomainModel.Entity.EntityPermissions.EntityExtendedPermission;
using Vodovoz.PermissionExtensions;
using Vodovoz.EntityRepositories.Employees;
using QS.DomainModel.NotifyChange;
using QS.Project.Services;
using Vodovoz.ViewWidgets;
using Vodovoz.EntityRepositories.Cash;
using Vodovoz.Domain.Service.BaseParametersServices;
using Vodovoz.Parameters;
using Vodovoz.TempAdapters;
using Vodovoz.ServicesImplementations;

namespace Vodovoz
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class UnclosedAdvancesView : QS.Dialog.Gtk.TdiTabBase
	{
		private IUnitOfWork uow;

		public IUnitOfWork UoW {
			get {
				return uow;
			}
			set {
				if (uow == value)
					return;
				uow = value;
				unclosedadvancesfilter1.UoW = value;
				var vm = new ViewModel.UnclosedAdvancesVM (unclosedadvancesfilter1);

				representationUnclosed.RepresentationModel = vm;
				representationUnclosed.RepresentationModel.UpdateNodes ();
			}
		}

		public bool? UseSlider => null;

		public UnclosedAdvancesView(Employee accountable, ExpenseCategory expense): this()
		{
			if (accountable != null)
				unclosedadvancesfilter1.SetAndRefilterAtOnce(x => x.RestrictAccountable = accountable);
			if (expense != null)
				unclosedadvancesfilter1.SetAndRefilterAtOnce(x => x.RestrictExpenseCategory = expense);
		}

		public UnclosedAdvancesView ()
		{
			this.Build ();
			this.TabName = "Незакрытые авансы";
			unclosedadvancesfilter1.Refiltered += Accountableslipfilter1_Refiltered;
			UoW = UnitOfWorkFactory.CreateWithoutRoot ();
			unclosedadvancesfilter1.UoW = UoW;
			representationUnclosed.Selection.Changed += RepresentationUnclosed_Selection_Changed;
		}

		void RepresentationUnclosed_Selection_Changed (object sender, EventArgs e)
		{
			buttonClose.Sensitive = buttonReturn.Sensitive = representationUnclosed.Selection.CountSelectedRows() > 0;
		}

		void Accountableslipfilter1_Refiltered (object sender, EventArgs e)
		{
			TabName = unclosedadvancesfilter1.RestrictAccountable == null
				? "Незакрытые авансы"
				: String.Format ("Незакрытые авансы по {0}", unclosedadvancesfilter1.RestrictAccountable.ShortName);
		}

		protected void OnButtonReturnClicked(object sender, EventArgs e)
		{
			var expense = UoW.GetById<Expense> (representationUnclosed.GetSelectedId ());

			var cashIncomeViewModel = new CashIncomeViewModel(
				EntityUoWBuilder.ForCreate(),
				UnitOfWorkFactory.GetDefaultFactory,
				VodovozGtkServicesConfig.EmployeeService,
				new EntityExtendedPermissionValidator(PermissionExtensionSingletonStore.GetInstance(), EmployeeSingletonRepository.GetInstance()),
				new GtkReportViewOpener(),
				ServicesConfig.CommonServices,
				NotifyConfiguration.Instance,
				new CashCategoryRepository(new CashCategoryParametersProvider(new ParametersProvider())),
				new EmployeeJournalFactory(),
				new CounterpartyJournalFactory(),
				new AvailableCashSubdivisionProvider()
			);
			if(cashIncomeViewModel.TryFillReturnForAdvance(expense)) {
				OpenNewTab(cashIncomeViewModel);
			}
		}

		protected void OnButtonCloseClicked(object sender, EventArgs e)
		{
			var expense = UoW.GetById<Expense> (representationUnclosed.GetSelectedId ());

			var dlg = new AdvanceReportDlg (expense, PermissionsSettings.PermissionService);
			OpenNewTab (dlg);
		}

		public override void Destroy()
		{
			UoW?.Dispose();
			base.Destroy();
		}
	}
}

