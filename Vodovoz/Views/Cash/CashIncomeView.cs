using Gamma.ColumnConfig;
using QS.Project.Services;
using QS.Views.GtkUI;
using Vodovoz.Domain.Cash;
using Vodovoz.Domain.Logistic;
using Vodovoz.ViewModels.Dialogs.Cash;
using VodovozInfrastructure.Extensions;

namespace Vodovoz.Views.Cash
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class CashIncomeView : TabViewBase<CashIncomeViewModel>
	{
		private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

		public CashIncomeView(CashIncomeViewModel viewModel) : base(viewModel)
		{
			this.Build();
			ConfigureView();
		}

		private void ConfigureView()
		{
			enumcomboOperation.ItemsEnum = typeof(IncomeType);
			enumcomboOperation.Binding.AddBinding(ViewModel.Entity, e => e.TypeOperation, w => w.SelectedItem).InitializeFromSource();
			enumcomboOperation.Binding.AddBinding(ViewModel, vm => vm.CanEdit, w => w.Sensitive).InitializeFromSource();

			ylabelCashier.Binding.AddFuncBinding(ViewModel.Entity, e => e.Casher.GetPersonNameWithInitials(), w => w.LabelProp).InitializeFromSource();

			entryEmployee.SetEntityAutocompleteSelectorFactory(ViewModel.EmployeesSelectorFactory);
			entryEmployee.Binding.AddBinding(ViewModel.Entity, e => e.Casher, w => w.Subject).InitializeFromSource();
			entryEmployee.Binding.AddBinding(ViewModel, vm => vm.CanEdit, w => w.Sensitive).InitializeFromSource();

			//FIXME Исправить на новый журнал когда перепишем маршрутные листы
			var filterRL = new RouteListsFilter(ViewModel.UoW);
			filterRL.OnlyStatuses = new RouteListStatus[] { RouteListStatus.EnRoute, RouteListStatus.OnClosing };
			yEntryRouteList.RepresentationModel = new ViewModel.RouteListsVM(filterRL);
			yEntryRouteList.Binding.AddBinding(ViewModel, vm => vm.ClosingRouteList, w => w.Subject).InitializeFromSource();
			yEntryRouteList.CanEditReference = ServicesConfig.CommonServices.CurrentPermissionService.ValidatePresetPermission("can_delete");
			yEntryRouteList.Binding.AddBinding(ViewModel, vm => vm.CanEdit, w => w.Sensitive).InitializeFromSource();
			yEntryRouteList.Binding.AddBinding(ViewModel, vm => vm.IsDriverReport, w => w.Visible).InitializeFromSource();

			labelRouteList.Binding.AddBinding(ViewModel, vm => vm.IsDriverReport, w => w.Visible).InitializeFromSource();

			entryClient.SetEntityAutocompleteSelectorFactory(ViewModel.CounterpartySelectorFactory);
			entryClient.Binding.AddBinding(ViewModel.Entity, e => e.Customer, w => w.Subject).InitializeFromSource();
			entryClient.Binding.AddBinding(ViewModel, vm => vm.CanEdit, w => w.Sensitive).InitializeFromSource();
			entryClient.Binding.AddBinding(ViewModel, vm => vm.IsPayment, w => w.Visible).InitializeFromSource();
			labelClientTitle.Binding.AddBinding(ViewModel, vm => vm.IsPayment, w => w.Visible).InitializeFromSource();

			ydateDocument.Binding.AddBinding(ViewModel.Entity, s => s.Date, w => w.Date).InitializeFromSource();
			ydateDocument.Binding.AddBinding(ViewModel, vm => vm.CanEdit, w => w.Sensitive).InitializeFromSource();

			comboExpenseCategory.ItemsList = ViewModel.ExpenseCategories;
			comboExpenseCategory.Binding.AddBinding(ViewModel.Entity, s => s.ExpenseCategory, w => w.SelectedItem).InitializeFromSource();
			comboExpenseCategory.Binding.AddBinding(ViewModel, vm => vm.CanEdit, w => w.Sensitive).InitializeFromSource();

			comboIncomeCategory.ItemsList = ViewModel.IncomeCategories;
			comboIncomeCategory.Binding.AddBinding(ViewModel.Entity, s => s.IncomeCategory, w => w.SelectedItem).InitializeFromSource();
			comboIncomeCategory.Binding.AddBinding(ViewModel, vm => vm.CanEdit, w => w.Sensitive).InitializeFromSource();

			comboCashSubdivision.Binding.AddBinding(ViewModel.Entity, e => e.RelatedToSubdivision, w => w.SelectedItem).InitializeFromSource();
			comboCashSubdivision.Binding.AddBinding(ViewModel, vm => vm.CanEdit, w => w.Sensitive).InitializeFromSource();

			checkNoClose.Binding.AddBinding(ViewModel, vm => vm.IsPartialDebtReturn, w => w.Active);
			checkNoClose.Binding.AddBinding(ViewModel, vm => vm.CanEdit, w => w.Sensitive).InitializeFromSource();
			checkNoClose.Binding.AddBinding(ViewModel, vm => vm.CanSelectDebts, w => w.Visible).InitializeFromSource();

			yspinMoney.Binding.AddBinding(ViewModel.Entity, s => s.Money, w => w.ValueAsDecimal).InitializeFromSource();
			yspinMoney.Binding.AddBinding(ViewModel, vm => vm.CanEditMoney, w => w.Sensitive).InitializeFromSource();

			ytextviewDescription.Binding.AddBinding(ViewModel.Entity, s => s.Description, w => w.Buffer.Text).InitializeFromSource();
			ytextviewDescription.Binding.AddBinding(ViewModel, vm => vm.CanEdit, w => w.Sensitive).InitializeFromSource();

			buttonPrint.Clicked += (s, e) => ViewModel.PrintCommand.Execute();
			ViewModel.PrintCommand.CanExecuteChanged += (sender, e) => buttonPrint.Sensitive = ViewModel.PrintCommand.CanExecute();

			buttonSave.Clicked += (s, e) => ViewModel.SaveAndCloseCommand.Execute();
			ViewModel.SaveAndCloseCommand.CanExecuteChanged += (sender, e) => buttonSave.Sensitive = ViewModel.SaveAndCloseCommand.CanExecute();

			buttonCancel.Clicked += (s, e) => ViewModel.CloseCommand.Execute();
			ViewModel.CloseCommand.CanExecuteChanged += (sender, e) => buttonCancel.Sensitive = ViewModel.CloseCommand.CanExecute();

			ytreeviewDebts.ColumnsConfig = FluentColumnsConfig<SelectableNode<Expense>>.Create()
				.AddColumn("Закрыть").AddToggleRenderer(a => a.Selected).Editing()
				.AddColumn("Дата").AddTextRenderer(a => a.Value.Date.ToString())
				.AddColumn("Получено").AddTextRenderer(a => a.Value.Money.ToString("C"))
				.AddColumn("Непогашено").AddTextRenderer(a => a.Value.UnclosedMoney.ToString("C"))
				.AddColumn("Статья").AddTextRenderer(a => a.Value.ExpenseCategory.Name)
				.AddColumn("Основание").AddTextRenderer(a => a.Value.Description)
				.Finish();
			ytreeviewDebts.ItemsDataSource = ViewModel.Entity.Debts;

			ViewModel.PropertyChanged += ViewModel_PropertyChanged;;
		}

		void ViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			switch(e.PropertyName) {
				case nameof(ViewModel.CanSelectDebts):
					UpdateDebtsVisibility();
					break;
				default:
					break;
			}
		}

		private void UpdateDebtsVisibility()
		{
			vboxDebts.Visible = ViewModel.CanSelectDebts;
		}

	}
}
