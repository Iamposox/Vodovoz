
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz
{
	public partial class ReadyForShipmentFilter
	{
		private global::Gtk.HBox hbox3;

		private global::Gtk.Label label2;

		private global::Gamma.Widgets.ySpecComboBox yspeccomboWarehouse;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.ReadyForShipmentFilter
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.ReadyForShipmentFilter";
			// Container child Vodovoz.ReadyForShipmentFilter.Gtk.Container+ContainerChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Склад:");
			this.hbox3.Add(this.label2);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.label2]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.yspeccomboWarehouse = new global::Gamma.Widgets.ySpecComboBox();
			this.yspeccomboWarehouse.Name = "yspeccomboWarehouse";
			this.yspeccomboWarehouse.AddIfNotExist = false;
			this.yspeccomboWarehouse.DefaultFirst = false;
			this.yspeccomboWarehouse.ShowSpecialStateAll = true;
			this.yspeccomboWarehouse.ShowSpecialStateNot = false;
			this.hbox3.Add(this.yspeccomboWarehouse);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.yspeccomboWarehouse]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			this.Add(this.hbox3);
			if((this.Child != null)) {
				this.Child.ShowAll();
			}
			this.Hide();
			this.yspeccomboWarehouse.ItemSelected += new global::System.EventHandler< Gamma.Widgets.ItemSelectedEventArgs > (this.OnYspeccomboWarehouseItemSelected);
		}
	}
}
