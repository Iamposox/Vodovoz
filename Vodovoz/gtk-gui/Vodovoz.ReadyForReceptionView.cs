
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz
{
	public partial class ReadyForReceptionView
	{
		private global::Gtk.VBox vbox1;
		
		private global::Gtk.HBox hbox1;
		
		private global::Vodovoz.ReadyForReceptionFilter readyforreceptionfilter1;
		
		private global::QSWidgetLib.SearchEntity searchentity1;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		
		private global::QSOrmProject.RepresentationTreeView tableReadyForReception;
		
		private global::Gtk.HBox hbox2;
		
		private global::Gtk.Button buttonOpen;
		
		private global::Gtk.Button buttonConfirmReception;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Vodovoz.ReadyForReceptionView
			global::Stetic.BinContainer.Attach (this);
			this.Name = "Vodovoz.ReadyForReceptionView";
			// Container child Vodovoz.ReadyForReceptionView.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.readyforreceptionfilter1 = new global::Vodovoz.ReadyForReceptionFilter ();
			this.readyforreceptionfilter1.Events = ((global::Gdk.EventMask)(256));
			this.readyforreceptionfilter1.Name = "readyforreceptionfilter1";
			this.hbox1.Add (this.readyforreceptionfilter1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.readyforreceptionfilter1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			this.vbox1.Add (this.hbox1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.searchentity1 = new global::QSWidgetLib.SearchEntity ();
			this.searchentity1.Events = ((global::Gdk.EventMask)(256));
			this.searchentity1.Name = "searchentity1";
			this.vbox1.Add (this.searchentity1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.searchentity1]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.tableReadyForReception = new global::QSOrmProject.RepresentationTreeView ();
			this.tableReadyForReception.CanFocus = true;
			this.tableReadyForReception.Name = "tableReadyForReception";
			this.GtkScrolledWindow.Add (this.tableReadyForReception);
			this.vbox1.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.GtkScrolledWindow]));
			w5.Position = 2;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.buttonOpen = new global::Gtk.Button ();
			this.buttonOpen.Sensitive = false;
			this.buttonOpen.CanFocus = true;
			this.buttonOpen.Name = "buttonOpen";
			this.buttonOpen.UseUnderline = true;
			this.buttonOpen.Label = global::Mono.Unix.Catalog.GetString ("Разгрузить машину");
			global::Gtk.Image w6 = new global::Gtk.Image ();
			w6.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-ok", global::Gtk.IconSize.Menu);
			this.buttonOpen.Image = w6;
			this.hbox2.Add (this.buttonOpen);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.buttonOpen]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.buttonConfirmReception = new global::Gtk.Button ();
			this.buttonConfirmReception.Sensitive = false;
			this.buttonConfirmReception.CanFocus = true;
			this.buttonConfirmReception.Name = "buttonConfirmReception";
			this.buttonConfirmReception.UseUnderline = true;
			this.buttonConfirmReception.Label = global::Mono.Unix.Catalog.GetString ("Отправить в кассу");
			global::Gtk.Image w8 = new global::Gtk.Image ();
			w8.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-go-forward", global::Gtk.IconSize.Menu);
			this.buttonConfirmReception.Image = w8;
			this.hbox2.Add (this.buttonConfirmReception);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.buttonConfirmReception]));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			this.vbox1.Add (this.hbox2);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox2]));
			w10.Position = 3;
			w10.Expand = false;
			w10.Fill = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.searchentity1.TextChanged += new global::System.EventHandler (this.OnSearchentity1TextChanged);
			this.tableReadyForReception.RowActivated += new global::Gtk.RowActivatedHandler (this.OnTableReadyForReceptionRowActivated);
			this.buttonOpen.Clicked += new global::System.EventHandler (this.OnButtonOpenClicked);
			this.buttonConfirmReception.Clicked += new global::System.EventHandler (this.OnButtonConfirmReceptionClicked);
		}
	}
}
