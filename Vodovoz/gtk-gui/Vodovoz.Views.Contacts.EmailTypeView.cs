
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz.Views.Contacts
{
	public partial class EmailTypeView
	{
		private global::Gtk.VBox vboxDialog;

		private global::Gtk.HBox hboxDialogButtons;

		private global::Gamma.GtkWidgets.yButton buttonSave;

		private global::Gamma.GtkWidgets.yButton buttonCancel;

		private global::Gtk.Table table1;

		private global::Gtk.Label labelName;

		private global::Gamma.GtkWidgets.yEntry yentryName;

		private global::Gamma.Widgets.yEnumComboBox yenumcomboAdditionalType;

		private global::Gamma.GtkWidgets.yLabel ylabelAdditionalType;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.Views.Contacts.EmailTypeView
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.Views.Contacts.EmailTypeView";
			// Container child Vodovoz.Views.Contacts.EmailTypeView.Gtk.Container+ContainerChild
			this.vboxDialog = new global::Gtk.VBox();
			this.vboxDialog.Name = "vboxDialog";
			this.vboxDialog.Spacing = 6;
			// Container child vboxDialog.Gtk.Box+BoxChild
			this.hboxDialogButtons = new global::Gtk.HBox();
			this.hboxDialogButtons.Name = "hboxDialogButtons";
			this.hboxDialogButtons.Spacing = 6;
			// Container child hboxDialogButtons.Gtk.Box+BoxChild
			this.buttonSave = new global::Gamma.GtkWidgets.yButton();
			this.buttonSave.CanFocus = true;
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.UseUnderline = true;
			this.buttonSave.Label = global::Mono.Unix.Catalog.GetString("Сохранить");
			global::Gtk.Image w1 = new global::Gtk.Image();
			w1.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-save", global::Gtk.IconSize.Menu);
			this.buttonSave.Image = w1;
			this.hboxDialogButtons.Add(this.buttonSave);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hboxDialogButtons[this.buttonSave]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hboxDialogButtons.Gtk.Box+BoxChild
			this.buttonCancel = new global::Gamma.GtkWidgets.yButton();
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = global::Mono.Unix.Catalog.GetString("Отменить");
			global::Gtk.Image w3 = new global::Gtk.Image();
			w3.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-revert-to-saved", global::Gtk.IconSize.Menu);
			this.buttonCancel.Image = w3;
			this.hboxDialogButtons.Add(this.buttonCancel);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hboxDialogButtons[this.buttonCancel]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			this.vboxDialog.Add(this.hboxDialogButtons);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vboxDialog[this.hboxDialogButtons]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vboxDialog.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table(((uint)(2)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.labelName = new global::Gtk.Label();
			this.labelName.Name = "labelName";
			this.labelName.Xalign = 1F;
			this.labelName.LabelProp = global::Mono.Unix.Catalog.GetString("Название:");
			this.table1.Add(this.labelName);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1[this.labelName]));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.yentryName = new global::Gamma.GtkWidgets.yEntry();
			this.yentryName.CanFocus = true;
			this.yentryName.Name = "yentryName";
			this.yentryName.IsEditable = true;
			this.yentryName.InvisibleChar = '•';
			this.table1.Add(this.yentryName);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1[this.yentryName]));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.yenumcomboAdditionalType = new global::Gamma.Widgets.yEnumComboBox();
			this.yenumcomboAdditionalType.Name = "yenumcomboAdditionalType";
			this.yenumcomboAdditionalType.ShowSpecialStateAll = false;
			this.yenumcomboAdditionalType.ShowSpecialStateNot = false;
			this.yenumcomboAdditionalType.UseShortTitle = false;
			this.yenumcomboAdditionalType.DefaultFirst = false;
			this.table1.Add(this.yenumcomboAdditionalType);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1[this.yenumcomboAdditionalType]));
			w8.TopAttach = ((uint)(1));
			w8.BottomAttach = ((uint)(2));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(2));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.ylabelAdditionalType = new global::Gamma.GtkWidgets.yLabel();
			this.ylabelAdditionalType.Name = "ylabelAdditionalType";
			this.ylabelAdditionalType.LabelProp = global::Mono.Unix.Catalog.GetString("Дополнительный тип");
			this.table1.Add(this.ylabelAdditionalType);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1[this.ylabelAdditionalType]));
			w9.TopAttach = ((uint)(1));
			w9.BottomAttach = ((uint)(2));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vboxDialog.Add(this.table1);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vboxDialog[this.table1]));
			w10.Position = 1;
			w10.Expand = false;
			w10.Fill = false;
			this.Add(this.vboxDialog);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
