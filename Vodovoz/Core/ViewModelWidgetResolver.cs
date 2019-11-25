using System;
using System.Collections.Generic;
using Gtk;
using QS.Dialog.GtkUI;
using QS.Project.Filter;
using QS.RepresentationModel;
using QS.Tdi;
using QS.Tdi.Gtk;
using QS.ViewModels;
using Vodovoz.Infrastructure.Services;

namespace Vodovoz.Core
{
	public class ViewModelWidgetResolver : DefaultTDIWidgetResolver, IFilterWidgetResolver
	{
		private static ViewModelWidgetResolver instance;
		public static ViewModelWidgetResolver Instance {
			get {
				if(instance == null) {
					instance = new ViewModelWidgetResolver();
				}
				return instance; 
			}
			set => instance = value;
		}

		public ViewModelWidgetResolver()
		{
		}

		private Dictionary<Type, Type> viewModelWidgets = new Dictionary<Type, Type>();

		public override Widget Resolve(ITdiTab tab)
		{
			Widget widget = base.Resolve(tab);
			if(widget != null) {
				return widget;
			}

			if(tab is EntityRepresentationSelectorAdapter) {
				return Resolve((tab as EntityRepresentationSelectorAdapter).JournalTab);
			}

			Type tabType = tab.GetType();
			if(!viewModelWidgets.ContainsKey(tabType)) {
				throw new ApplicationException($"Не настроено сопоставление для {tabType.Name}");
			}

			var widgetCtorInfo = viewModelWidgets[tabType].GetConstructor(new[] { tabType });
			widget = (Widget)widgetCtorInfo.Invoke(new object[] { tab });
			return widget;
		}

		public override Widget Resolve(ViewModelBase viewModel)
		{
			if(viewModel == null) {
				return null;
			}

			Widget widget = base.Resolve(viewModel);
			if(widget != null) {
				return widget;
			}

			Type filterType = viewModel.GetType();
			if(!viewModelWidgets.ContainsKey(filterType)) {
				throw new ApplicationException($"Не настроено сопоставление для {filterType.Name}");
			}

			var widgetCtorInfo = viewModelWidgets[filterType].GetConstructor(new[] { filterType });		 
			return (Widget)widgetCtorInfo.Invoke(new object[] { viewModel });
		}


		public virtual Widget Resolve(IJournalFilter filter)
		{
			if(filter == null) {
				return null;
			}

			if(filter is Widget) {
				return (Widget)filter;
			}
			Type filterType = filter.GetType();
			if(!viewModelWidgets.ContainsKey(filterType)) {
				throw new ApplicationException($"Не настроено сопоставление для {filterType.Name}");
			}

			var widgetCtorInfo = viewModelWidgets[filterType].GetConstructor(new[] { filterType });
			Widget widget = (Widget)widgetCtorInfo.Invoke(new object[] { filter });
			return widget;
		}

		public virtual Widget Resolve(QS.Project.Journal.IJournalFilter filter)
		{
			if(filter == null) {
				return null;
			}

			if(filter is Widget) {
				return (Widget)filter;
			}

			Type filterType = filter.GetType();
			if(!viewModelWidgets.ContainsKey(filterType)) {
				throw new ApplicationException($"Не настроено сопоставление для {filterType.Name}");
			}

			var widgetCtorInfo = viewModelWidgets[filterType].GetConstructor(new[] { filterType });
			Widget widget = (Widget)widgetCtorInfo.Invoke(new object[] { filter });
			return widget;
		}

		public virtual Widget Resolve(WidgetViewModelBase viewModel)
		{
			if(viewModel == null)
				return null;

			Type filterType = viewModel.GetType();
			if(!viewModelWidgets.ContainsKey(filterType)) {
				throw new ApplicationException($"Не настроено сопоставление для {filterType.Name}");
			}

			var widgetCtorInfo = viewModelWidgets[filterType].GetConstructor(new[] { filterType });
			Widget widget = (Widget)widgetCtorInfo.Invoke(new object[] { viewModel });
			return widget;
		}

		public virtual ViewModelWidgetResolver RegisterWidgetForTabViewModel<TViewModel, TWidget>()
			where TViewModel : TabViewModelBase
			where TWidget : Widget
		{
			Type viewModelType = typeof(TViewModel);
			Type widgetType = typeof(TWidget);
			if(viewModelWidgets.ContainsKey(viewModelType)) {
				throw new InvalidOperationException($"Модель представления {viewModelType.Name} уже зарегистрирована");
			}
			viewModelWidgets.Add(viewModelType, widgetType);

			return this;
		}

		public virtual ViewModelWidgetResolver RegisterWidgetForWidgetViewModel<TViewModel, TWidget>()
			where TViewModel : ViewModelBase
			where TWidget : Widget
		{
			Type viewModelType = typeof(TViewModel);
			Type widgetType = typeof(TWidget);
			if(viewModelWidgets.ContainsKey(viewModelType)) {
				throw new InvalidOperationException($"Модель представления {viewModelType.Name} уже зарегистрирована");
			}
			viewModelWidgets.Add(viewModelType, widgetType);

			return this;
		}

		public virtual ViewModelWidgetResolver RegisterWidgetForViewModel<TViewModel, TWidget>()
			where TViewModel : ViewModelBase
			where TWidget : Widget
		{
			Type viewModelType = typeof(TViewModel);
			Type widgetType = typeof(TWidget);
			if(viewModelWidgets.ContainsKey(viewModelType)) {
				throw new InvalidOperationException($"Модель представления {viewModelType.Name} уже зарегистрирована");
			}
			viewModelWidgets.Add(viewModelType, widgetType);

			return this;
		}
	}
}
