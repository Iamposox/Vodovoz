
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz.Views.Security
{
	public partial class RegisteredRMView
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Button buttonSave;

		private global::Gtk.Button buttonCancel;

		private global::Gtk.VSeparator vseparator1;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Label label1;

		private global::Gamma.GtkWidgets.yEntry yentryUsername;

		private global::Gtk.Label label2;

		private global::Gamma.GtkWidgets.yEntry yentryDomainame;

		private global::Gtk.Label label3;

		private global::Gamma.GtkWidgets.yEntry yentrySID;

		private global::Gamma.GtkWidgets.yCheckButton ycheckIsActive;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Button buttonAddUser;

		private global::Gtk.Button buttonDeleteUser;

		private global::Gtk.ScrolledWindow GtkScrolledWindow1;

		private global::Gamma.GtkWidgets.yTreeView ytreeviewUsers;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.Views.Security.RegisteredRMView
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.Views.Security.RegisteredRMView";
			// Container child Vodovoz.Views.Security.RegisteredRMView.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.buttonSave = new global::Gtk.Button();
			this.buttonSave.CanFocus = true;
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.UseUnderline = true;
			this.buttonSave.Label = global::Mono.Unix.Catalog.GetString("Сохранить");
			global::Gtk.Image w1 = new global::Gtk.Image();
			w1.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-floppy", global::Gtk.IconSize.Menu);
			this.buttonSave.Image = w1;
			this.hbox2.Add(this.buttonSave);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.buttonSave]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.buttonCancel = new global::Gtk.Button();
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = global::Mono.Unix.Catalog.GetString("Отмена");
			global::Gtk.Image w3 = new global::Gtk.Image();
			w3.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-revert-to-saved", global::Gtk.IconSize.Menu);
			this.buttonCancel.Image = w3;
			this.hbox2.Add(this.buttonCancel);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.buttonCancel]));
			w4.Position = 1;
			w4.Expand = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.vseparator1 = new global::Gtk.VSeparator();
			this.vseparator1.Name = "vseparator1";
			this.hbox2.Add(this.vseparator1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.vseparator1]));
			w5.PackType = ((global::Gtk.PackType)(1));
			w5.Position = 3;
			w5.Expand = false;
			w5.Fill = false;
			this.vbox1.Add(this.hbox2);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox2]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Имя пользователя: ");
			this.hbox1.Add(this.label1);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.label1]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.yentryUsername = new global::Gamma.GtkWidgets.yEntry();
			this.yentryUsername.CanFocus = true;
			this.yentryUsername.Name = "yentryUsername";
			this.yentryUsername.IsEditable = true;
			this.yentryUsername.InvisibleChar = '•';
			this.hbox1.Add(this.yentryUsername);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.yentryUsername]));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Домен пользователя: ");
			this.hbox1.Add(this.label2);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.label2]));
			w9.Position = 2;
			w9.Expand = false;
			w9.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.yentryDomainame = new global::Gamma.GtkWidgets.yEntry();
			this.yentryDomainame.CanFocus = true;
			this.yentryDomainame.Name = "yentryDomainame";
			this.yentryDomainame.IsEditable = true;
			this.yentryDomainame.InvisibleChar = '•';
			this.hbox1.Add(this.yentryDomainame);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.yentryDomainame]));
			w10.Position = 3;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("SID пользователя: ");
			this.hbox1.Add(this.label3);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.label3]));
			w11.Position = 4;
			w11.Expand = false;
			w11.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.yentrySID = new global::Gamma.GtkWidgets.yEntry();
			this.yentrySID.CanFocus = true;
			this.yentrySID.Name = "yentrySID";
			this.yentrySID.IsEditable = true;
			this.yentrySID.InvisibleChar = '•';
			this.hbox1.Add(this.yentrySID);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.yentrySID]));
			w12.Position = 5;
			w12.Expand = false;
			w12.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.ycheckIsActive = new global::Gamma.GtkWidgets.yCheckButton();
			this.ycheckIsActive.TooltipMarkup = "Больше не работаем с этим клиентом";
			this.ycheckIsActive.CanFocus = true;
			this.ycheckIsActive.Name = "ycheckIsActive";
			this.ycheckIsActive.Label = global::Mono.Unix.Catalog.GetString("Активная запись");
			this.ycheckIsActive.DrawIndicator = true;
			this.ycheckIsActive.UseUnderline = true;
			this.hbox1.Add(this.ycheckIsActive);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.ycheckIsActive]));
			w13.Position = 7;
			w13.Expand = false;
			w13.Fill = false;
			this.vbox1.Add(this.hbox1);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
			w14.Position = 1;
			w14.Expand = false;
			w14.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.buttonAddUser = new global::Gtk.Button();
			this.buttonAddUser.CanFocus = true;
			this.buttonAddUser.Name = "buttonAddUser";
			this.buttonAddUser.UseUnderline = true;
			this.buttonAddUser.Label = global::Mono.Unix.Catalog.GetString("Добавить пользователя");
			global::Gtk.Image w15 = new global::Gtk.Image();
			w15.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-add", global::Gtk.IconSize.Menu);
			this.buttonAddUser.Image = w15;
			this.hbox3.Add(this.buttonAddUser);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.buttonAddUser]));
			w16.Position = 0;
			w16.Expand = false;
			w16.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.buttonDeleteUser = new global::Gtk.Button();
			this.buttonDeleteUser.CanFocus = true;
			this.buttonDeleteUser.Name = "buttonDeleteUser";
			this.buttonDeleteUser.UseUnderline = true;
			this.buttonDeleteUser.Label = global::Mono.Unix.Catalog.GetString("Удалить пользователя");
			global::Gtk.Image w17 = new global::Gtk.Image();
			w17.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-delete", global::Gtk.IconSize.Menu);
			this.buttonDeleteUser.Image = w17;
			this.hbox3.Add(this.buttonDeleteUser);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.buttonDeleteUser]));
			w18.Position = 1;
			w18.Expand = false;
			w18.Fill = false;
			this.vbox1.Add(this.hbox3);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox3]));
			w19.Position = 2;
			w19.Expand = false;
			w19.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.ytreeviewUsers = new global::Gamma.GtkWidgets.yTreeView();
			this.ytreeviewUsers.CanFocus = true;
			this.ytreeviewUsers.Name = "ytreeviewUsers";
			this.GtkScrolledWindow1.Add(this.ytreeviewUsers);
			this.vbox1.Add(this.GtkScrolledWindow1);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.GtkScrolledWindow1]));
			w21.Position = 3;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
			this.buttonAddUser.Clicked += new global::System.EventHandler(this.OnButtonAddUserClicked);
			this.buttonDeleteUser.Clicked += new global::System.EventHandler(this.OnButtonDeleteUserClicked);
		}
	}
}
