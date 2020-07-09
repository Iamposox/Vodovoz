using Gtk;
using QS.ViewModels;
using QS.Views.GtkUI;
using Vodovoz.Domain.WageCalculation;
using Vodovoz.ViewModels.WageCalculation;

namespace Vodovoz.Views.WageCalculation
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class WageParameterView : TabViewBase<EmployeeWageParameterViewModel>
	{
		public WageParameterView(EmployeeWageParameterViewModel viewModel) : base(viewModel)
		{
			this.Build();
			Configure();
		}

		private void Configure()
		{
			comboWageType.ItemsEnum = typeof(WageParameterTypes);
			comboWageType.Binding.AddBinding(ViewModel, vm => vm.WageParameterItemType, w => w.SelectedItem).InitializeFromSource();
			comboWageType.Binding.AddBinding(ViewModel, vm => vm.CanEdit, w => w.Sensitive).InitializeFromSource();

			ViewModel.PropertyChanged += (sender, e) => {
				if(e.PropertyName == nameof(ViewModel.WageParameterItemViewModel)) {
					UpdateWageParameterView();
				}
			};

			UpdateWageParameterView();

			buttonSave.Clicked += (sender, e) => ViewModel.Save();
			buttonCancel.Clicked += (sender, e) => ViewModel.Close(false, QS.Navigation.CloseSource.Cancel);
		}

		private Notebook notebook;

		private void UpdateWageParameterView()
		{
			notebook?.Destroy();
			notebook = new Notebook();


			notebook.InsertPage(GetWidget(ViewModel.WageParameterItemViewModel), new Label("Обычный расчет"), 0);
			var ourCarWidget = GetWidget(ViewModel.DriverWithCompanyCarWageParameterItemViewModel);
			if(ourCarWidget != null) {
				notebook.InsertPage(ourCarWidget, new Label("Для авто компании"), 0);
			}

			vboxDialog.Add(notebook);
			notebook.Show();
		}

		private Widget GetWidget(WidgetViewModelBase viewModel)
		{
			if(ViewModel.WageParameterItemViewModel is FixedWageParameterItemViewModel) {
				return new FixedWageParameterView((FixedWageParameterItemViewModel)viewModel);
			} else if(ViewModel.WageParameterItemViewModel is PercentWageParameterItemViewModel) {
				return new PercentWageParameterView((PercentWageParameterItemViewModel)viewModel);
			} else if(ViewModel.WageParameterItemViewModel is SalesPlanWageParameterItemViewModel) {
				return new SalesPlanWageParameterView((SalesPlanWageParameterItemViewModel)viewModel);
			} else if(ViewModel.WageParameterItemViewModel is RatesLevelWageParameterItemViewModel) {
				return new RatesLevelWageParameterView((RatesLevelWageParameterItemViewModel)viewModel);
			} else if(ViewModel.WageParameterItemViewModel is OldRatesWageParameterItemViewModel) {
				return new OldRatesWageParameterView((OldRatesWageParameterItemViewModel)viewModel);
			} else {
				return null;
			}
		}
	}
}
