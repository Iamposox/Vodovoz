
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz.Views.WageCalculation
{
	public partial class FixedWageParameterView
	{
		private global::Gtk.VBox vboxWidget;

		private global::Gtk.HBox hboxFixedType;

		private global::Gamma.GtkWidgets.yLabel ylabelFixedType;

		private global::Gamma.Widgets.yEnumComboBox comboFixedType;

		private global::Gtk.HBox hboxWageForRouteList;

		private global::Gamma.GtkWidgets.yLabel ylabelWageForRouteList;

		private global::Gamma.GtkWidgets.ySpinButton entryRouteListFixedWage;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.Views.WageCalculation.FixedWageParameterView
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.Views.WageCalculation.FixedWageParameterView";
			// Container child Vodovoz.Views.WageCalculation.FixedWageParameterView.Gtk.Container+ContainerChild
			this.vboxWidget = new global::Gtk.VBox();
			this.vboxWidget.Name = "vboxWidget";
			this.vboxWidget.Spacing = 6;
			// Container child vboxWidget.Gtk.Box+BoxChild
			this.hboxFixedType = new global::Gtk.HBox();
			this.hboxFixedType.Name = "hboxFixedType";
			this.hboxFixedType.Spacing = 6;
			// Container child hboxFixedType.Gtk.Box+BoxChild
			this.ylabelFixedType = new global::Gamma.GtkWidgets.yLabel();
			this.ylabelFixedType.Name = "ylabelFixedType";
			this.ylabelFixedType.LabelProp = global::Mono.Unix.Catalog.GetString("Тип фиксы:");
			this.hboxFixedType.Add(this.ylabelFixedType);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hboxFixedType[this.ylabelFixedType]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hboxFixedType.Gtk.Box+BoxChild
			this.comboFixedType = new global::Gamma.Widgets.yEnumComboBox();
			this.comboFixedType.Name = "comboFixedType";
			this.comboFixedType.ShowSpecialStateAll = false;
			this.comboFixedType.ShowSpecialStateNot = false;
			this.comboFixedType.UseShortTitle = false;
			this.comboFixedType.DefaultFirst = false;
			this.hboxFixedType.Add(this.comboFixedType);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hboxFixedType[this.comboFixedType]));
			w2.Position = 1;
			w2.Expand = false;
			this.vboxWidget.Add(this.hboxFixedType);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vboxWidget[this.hboxFixedType]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vboxWidget.Gtk.Box+BoxChild
			this.hboxWageForRouteList = new global::Gtk.HBox();
			this.hboxWageForRouteList.Name = "hboxWageForRouteList";
			this.hboxWageForRouteList.Spacing = 6;
			// Container child hboxWageForRouteList.Gtk.Box+BoxChild
			this.ylabelWageForRouteList = new global::Gamma.GtkWidgets.yLabel();
			this.ylabelWageForRouteList.Name = "ylabelWageForRouteList";
			this.ylabelWageForRouteList.LabelProp = global::Mono.Unix.Catalog.GetString("За МЛ:");
			this.hboxWageForRouteList.Add(this.ylabelWageForRouteList);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hboxWageForRouteList[this.ylabelWageForRouteList]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hboxWageForRouteList.Gtk.Box+BoxChild
			this.entryRouteListFixedWage = new global::Gamma.GtkWidgets.ySpinButton(0D, 99999999D, 1D);
			this.entryRouteListFixedWage.CanFocus = true;
			this.entryRouteListFixedWage.Name = "entryRouteListFixedWage";
			this.entryRouteListFixedWage.Adjustment.PageIncrement = 10D;
			this.entryRouteListFixedWage.ClimbRate = 1D;
			this.entryRouteListFixedWage.Numeric = true;
			this.entryRouteListFixedWage.ValueAsDecimal = 0m;
			this.entryRouteListFixedWage.ValueAsInt = 0;
			this.hboxWageForRouteList.Add(this.entryRouteListFixedWage);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hboxWageForRouteList[this.entryRouteListFixedWage]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			this.vboxWidget.Add(this.hboxWageForRouteList);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vboxWidget[this.hboxWageForRouteList]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			this.Add(this.vboxWidget);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
