
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz.Views.Mango
{
	public partial class IncomingCallView
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.VBox vboxIncomings;

		private global::Gtk.HBox hbox1;

		private global::Gamma.GtkWidgets.yButton buttonDisconnect;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.Views.Mango.IncomingCallView
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.Views.Mango.IncomingCallView";
			// Container child Vodovoz.Views.Mango.IncomingCallView.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.vboxIncomings = new global::Gtk.VBox();
			this.vboxIncomings.Name = "vboxIncomings";
			this.vboxIncomings.Spacing = 6;
			this.vbox1.Add(this.vboxIncomings);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.vboxIncomings]));
			w1.Position = 0;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonDisconnect = new global::Gamma.GtkWidgets.yButton();
			this.buttonDisconnect.CanFocus = true;
			this.buttonDisconnect.Name = "buttonDisconnect";
			this.buttonDisconnect.UseUnderline = true;
			this.buttonDisconnect.Label = global::Mono.Unix.Catalog.GetString("Завершить");
			global::Gtk.Image w2 = new global::Gtk.Image();
			w2.Pixbuf = global::Gdk.Pixbuf.LoadFromResource("Vodovoz.icons.phone.decline-call.png");
			this.buttonDisconnect.Image = w2;
			this.hbox1.Add(this.buttonDisconnect);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.buttonDisconnect]));
			w3.PackType = ((global::Gtk.PackType)(1));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			this.vbox1.Add(this.hbox1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
			this.buttonDisconnect.Clicked += new global::System.EventHandler(this.OnButtonDisconnectClicked);
		}
	}
}