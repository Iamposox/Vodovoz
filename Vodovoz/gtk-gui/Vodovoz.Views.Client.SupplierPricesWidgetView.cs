
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz.Views.Client
{
	public partial class SupplierPricesWidgetView
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Label lblPrices;

		private global::Gamma.GtkWidgets.ySpinButton spinDelayDays;

		private global::Gtk.Label lblDelayDays;

		private global::Gtk.HBox hboxSearch;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gamma.GtkWidgets.yTreeView yTreePrices;

		private global::Gtk.HBox hbox1;

		private global::Gamma.GtkWidgets.yButton btnAdd;

		private global::Gamma.GtkWidgets.yButton btnEdit;

		private global::Gamma.GtkWidgets.yButton btnDelete;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.Views.Client.SupplierPricesWidgetView
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.Views.Client.SupplierPricesWidgetView";
			// Container child Vodovoz.Views.Client.SupplierPricesWidgetView.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.lblPrices = new global::Gtk.Label();
			this.lblPrices.Name = "lblPrices";
			this.lblPrices.Xalign = 0F;
			this.lblPrices.LabelProp = global::Mono.Unix.Catalog.GetString("Цены поставщика на ТМЦ:");
			this.hbox2.Add(this.lblPrices);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.lblPrices]));
			w1.Position = 0;
			// Container child hbox2.Gtk.Box+BoxChild
			this.spinDelayDays = new global::Gamma.GtkWidgets.ySpinButton(0D, 730D, 1D);
			this.spinDelayDays.CanFocus = true;
			this.spinDelayDays.Name = "spinDelayDays";
			this.spinDelayDays.Adjustment.PageIncrement = 10D;
			this.spinDelayDays.ClimbRate = 1D;
			this.spinDelayDays.Numeric = true;
			this.spinDelayDays.ValueAsDecimal = 0m;
			this.spinDelayDays.ValueAsInt = 0;
			this.hbox2.Add(this.spinDelayDays);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.spinDelayDays]));
			w2.PackType = ((global::Gtk.PackType)(1));
			w2.Position = 1;
			// Container child hbox2.Gtk.Box+BoxChild
			this.lblDelayDays = new global::Gtk.Label();
			this.lblDelayDays.Name = "lblDelayDays";
			this.lblDelayDays.Xalign = 1F;
			this.lblDelayDays.LabelProp = global::Mono.Unix.Catalog.GetString("Отсрочка, дн.:");
			this.hbox2.Add(this.lblDelayDays);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.lblDelayDays]));
			w3.PackType = ((global::Gtk.PackType)(1));
			w3.Position = 2;
			this.vbox1.Add(this.hbox2);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox2]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hboxSearch = new global::Gtk.HBox();
			this.hboxSearch.Name = "hboxSearch";
			this.hboxSearch.Spacing = 6;
			this.vbox1.Add(this.hboxSearch);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hboxSearch]));
			w5.Position = 1;
			w5.Expand = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.yTreePrices = new global::Gamma.GtkWidgets.yTreeView();
			this.yTreePrices.CanFocus = true;
			this.yTreePrices.Name = "yTreePrices";
			this.GtkScrolledWindow.Add(this.yTreePrices);
			this.vbox1.Add(this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.GtkScrolledWindow]));
			w7.Position = 2;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.btnAdd = new global::Gamma.GtkWidgets.yButton();
			this.btnAdd.CanFocus = true;
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.UseUnderline = true;
			this.btnAdd.Label = global::Mono.Unix.Catalog.GetString("Добавить");
			global::Gtk.Image w8 = new global::Gtk.Image();
			w8.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-add", global::Gtk.IconSize.Menu);
			this.btnAdd.Image = w8;
			this.hbox1.Add(this.btnAdd);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.btnAdd]));
			w9.Position = 0;
			w9.Expand = false;
			w9.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.btnEdit = new global::Gamma.GtkWidgets.yButton();
			this.btnEdit.CanFocus = true;
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.UseUnderline = true;
			this.btnEdit.Label = global::Mono.Unix.Catalog.GetString("Изменить");
			global::Gtk.Image w10 = new global::Gtk.Image();
			w10.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-edit", global::Gtk.IconSize.Menu);
			this.btnEdit.Image = w10;
			this.hbox1.Add(this.btnEdit);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.btnEdit]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.btnDelete = new global::Gamma.GtkWidgets.yButton();
			this.btnDelete.CanFocus = true;
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.UseUnderline = true;
			this.btnDelete.Label = global::Mono.Unix.Catalog.GetString("Удалить");
			global::Gtk.Image w12 = new global::Gtk.Image();
			w12.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-delete", global::Gtk.IconSize.Menu);
			this.btnDelete.Image = w12;
			this.hbox1.Add(this.btnDelete);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.btnDelete]));
			w13.Position = 2;
			w13.Expand = false;
			w13.Fill = false;
			this.vbox1.Add(this.hbox1);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
			w14.Position = 3;
			w14.Expand = false;
			w14.Fill = false;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}