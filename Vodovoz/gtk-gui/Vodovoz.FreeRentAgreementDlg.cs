
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz
{
	public partial class FreeRentAgreementDlg
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Button buttonSave;

		private global::Gtk.Button buttonCancel;

		private global::Gtk.Table datatable1;

		private global::Gamma.Widgets.yDatePicker dateIssue;

		private global::Gamma.Widgets.yDatePicker dateStart;

		private global::Vodovoz.FreeRentPackagesView freerentpackagesview1;

		private global::Gtk.Label label1;

		private global::Gtk.Label label2;

		private global::Gtk.Label label3;

		private global::Gtk.Label label4;

		private global::Gamma.Widgets.yEntryReferenceVM referenceDeliveryPoint;

		private global::QSDocTemplates.TemplateWidget templatewidget1;

		private global::Gamma.GtkWidgets.yLabel ylabelNumber;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Vodovoz.FreeRentAgreementDlg
			global::Stetic.BinContainer.Attach (this);
			this.Name = "Vodovoz.FreeRentAgreementDlg";
			// Container child Vodovoz.FreeRentAgreementDlg.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonSave = new global::Gtk.Button ();
			this.buttonSave.CanFocus = true;
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.UseUnderline = true;
			this.buttonSave.Label = global::Mono.Unix.Catalog.GetString ("Сохранить");
			global::Gtk.Image w1 = new global::Gtk.Image ();
			w1.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-save", global::Gtk.IconSize.Menu);
			this.buttonSave.Image = w1;
			this.hbox1.Add (this.buttonSave);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonSave]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = global::Mono.Unix.Catalog.GetString ("Отмена");
			global::Gtk.Image w3 = new global::Gtk.Image ();
			w3.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-revert-to-saved", global::Gtk.IconSize.Menu);
			this.buttonCancel.Image = w3;
			this.hbox1.Add (this.buttonCancel);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonCancel]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			this.vbox1.Add (this.hbox1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.datatable1 = new global::Gtk.Table (((uint)(5)), ((uint)(5)), false);
			this.datatable1.Name = "datatable1";
			this.datatable1.RowSpacing = ((uint)(6));
			this.datatable1.ColumnSpacing = ((uint)(6));
			this.datatable1.BorderWidth = ((uint)(6));
			// Container child datatable1.Gtk.Table+TableChild
			this.dateIssue = new global::Gamma.Widgets.yDatePicker ();
			this.dateIssue.Events = ((global::Gdk.EventMask)(256));
			this.dateIssue.Name = "dateIssue";
			this.dateIssue.WithTime = false;
			this.dateIssue.Date = new global::System.DateTime (0);
			this.dateIssue.IsEditable = true;
			this.dateIssue.AutoSeparation = false;
			this.datatable1.Add (this.dateIssue);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.dateIssue]));
			w6.TopAttach = ((uint)(2));
			w6.BottomAttach = ((uint)(3));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.dateStart = new global::Gamma.Widgets.yDatePicker ();
			this.dateStart.Events = ((global::Gdk.EventMask)(256));
			this.dateStart.Name = "dateStart";
			this.dateStart.WithTime = false;
			this.dateStart.Date = new global::System.DateTime (0);
			this.dateStart.IsEditable = true;
			this.dateStart.AutoSeparation = false;
			this.datatable1.Add (this.dateStart);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.dateStart]));
			w7.TopAttach = ((uint)(3));
			w7.BottomAttach = ((uint)(4));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.freerentpackagesview1 = new global::Vodovoz.FreeRentPackagesView ();
			this.freerentpackagesview1.Events = ((global::Gdk.EventMask)(256));
			this.freerentpackagesview1.Name = "freerentpackagesview1";
			this.freerentpackagesview1.IsEditable = false;
			this.datatable1.Add (this.freerentpackagesview1);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.freerentpackagesview1]));
			w8.TopAttach = ((uint)(4));
			w8.BottomAttach = ((uint)(5));
			w8.RightAttach = ((uint)(5));
			// Container child datatable1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 1F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Номер доп. соглашения:");
			this.datatable1.Add (this.label1);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.label1]));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xalign = 1F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Точка доставки:");
			this.datatable1.Add (this.label2);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.label2]));
			w10.TopAttach = ((uint)(1));
			w10.BottomAttach = ((uint)(2));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 1F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Дата создания:");
			this.datatable1.Add (this.label3);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.label3]));
			w11.TopAttach = ((uint)(2));
			w11.BottomAttach = ((uint)(3));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.Xalign = 1F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Дата начала действия:");
			this.datatable1.Add (this.label4);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.label4]));
			w12.TopAttach = ((uint)(3));
			w12.BottomAttach = ((uint)(4));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.referenceDeliveryPoint = new global::Gamma.Widgets.yEntryReferenceVM ();
			this.referenceDeliveryPoint.Events = ((global::Gdk.EventMask)(256));
			this.referenceDeliveryPoint.Name = "referenceDeliveryPoint";
			this.datatable1.Add (this.referenceDeliveryPoint);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.referenceDeliveryPoint]));
			w13.TopAttach = ((uint)(1));
			w13.BottomAttach = ((uint)(2));
			w13.LeftAttach = ((uint)(1));
			w13.RightAttach = ((uint)(2));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.templatewidget1 = new global::QSDocTemplates.TemplateWidget ();
			this.templatewidget1.Events = ((global::Gdk.EventMask)(256));
			this.templatewidget1.Name = "templatewidget1";
			this.datatable1.Add (this.templatewidget1);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.templatewidget1]));
			w14.BottomAttach = ((uint)(4));
			w14.LeftAttach = ((uint)(2));
			w14.RightAttach = ((uint)(5));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.ylabelNumber = new global::Gamma.GtkWidgets.yLabel ();
			this.ylabelNumber.Name = "ylabelNumber";
			this.ylabelNumber.Xalign = 0F;
			this.ylabelNumber.LabelProp = global::Mono.Unix.Catalog.GetString ("ylabel1");
			this.datatable1.Add (this.ylabelNumber);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.ylabelNumber]));
			w15.LeftAttach = ((uint)(1));
			w15.RightAttach = ((uint)(2));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox1.Add (this.datatable1);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.datatable1]));
			w16.Position = 1;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
