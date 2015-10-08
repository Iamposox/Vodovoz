
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz
{
	public partial class CashIncomeDlg
	{
		private global::Gtk.VBox vbox1;
		
		private global::Gtk.HBox hbox2;
		
		private global::Gtk.Button buttonSave;
		
		private global::Gtk.Button buttonCancel;
		
		private global::Gtk.Button buttonPrint;
		
		private global::Gtk.Table table1;
		
		private global::Gamma.Widgets.ySpecComboBox comboCategory;
		
		private global::Gamma.Widgets.yEnumComboBox enumcomboOperation;
		
		private global::Gtk.HBox hbox6;
		
		private global::Gamma.GtkWidgets.ySpinButton yspinMoney;
		
		private global::QSProjectsLib.CurrencyLabel currencylabel1;
		
		private global::Gtk.Label label1;
		
		private global::Gtk.Label label2;
		
		private global::Gtk.Label label3;
		
		private global::Gtk.Label label5;
		
		private global::Gtk.Label labelClientTitle;
		
		private global::Gtk.Label labelEmploeey;
		
		private global::Gtk.Label labelExpenseTitle;
		
		private global::Gtk.Label labelIncomeTitle;
		
		private global::Gamma.Widgets.yDatePicker ydateDocument;
		
		private global::Gamma.Widgets.yEntryReference yentryCasher;
		
		private global::Gamma.Widgets.yEntryReference yentryClient;
		
		private global::Gamma.Widgets.yEntryReference yentryEmploeey;
		
		private global::Gamma.Widgets.yEntryReference yentryExpense;
		
		private global::Gtk.Label label6;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		
		private global::Gamma.GtkWidgets.yTextView ytextviewDescription;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Vodovoz.CashIncomeDlg
			global::Stetic.BinContainer.Attach (this);
			this.Name = "Vodovoz.CashIncomeDlg";
			// Container child Vodovoz.CashIncomeDlg.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.buttonSave = new global::Gtk.Button ();
			this.buttonSave.CanFocus = true;
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.UseUnderline = true;
			this.buttonSave.Label = global::Mono.Unix.Catalog.GetString ("Сохранить");
			global::Gtk.Image w1 = new global::Gtk.Image ();
			w1.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-save", global::Gtk.IconSize.Menu);
			this.buttonSave.Image = w1;
			this.hbox2.Add (this.buttonSave);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.buttonSave]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = global::Mono.Unix.Catalog.GetString ("Отменить");
			global::Gtk.Image w3 = new global::Gtk.Image ();
			w3.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-revert-to-saved", global::Gtk.IconSize.Menu);
			this.buttonCancel.Image = w3;
			this.hbox2.Add (this.buttonCancel);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.buttonCancel]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.buttonPrint = new global::Gtk.Button ();
			this.buttonPrint.CanFocus = true;
			this.buttonPrint.Name = "buttonPrint";
			this.buttonPrint.UseUnderline = true;
			this.buttonPrint.Label = global::Mono.Unix.Catalog.GetString ("Печать");
			global::Gtk.Image w5 = new global::Gtk.Image ();
			w5.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-print", global::Gtk.IconSize.Menu);
			this.buttonPrint.Image = w5;
			this.hbox2.Add (this.buttonPrint);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.buttonPrint]));
			w6.Position = 2;
			w6.Expand = false;
			w6.Fill = false;
			this.vbox1.Add (this.hbox2);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox2]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table (((uint)(6)), ((uint)(4)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.comboCategory = new global::Gamma.Widgets.ySpecComboBox ();
			this.comboCategory.Name = "comboCategory";
			this.comboCategory.AddIfNotExist = false;
			this.comboCategory.ShowSpecialStateAll = false;
			this.comboCategory.ShowSpecialStateNot = false;
			this.table1.Add (this.comboCategory);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1 [this.comboCategory]));
			w8.TopAttach = ((uint)(1));
			w8.BottomAttach = ((uint)(2));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(2));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.enumcomboOperation = new global::Gamma.Widgets.yEnumComboBox ();
			this.enumcomboOperation.Name = "enumcomboOperation";
			this.enumcomboOperation.ShowSpecialStateAll = false;
			this.enumcomboOperation.ShowSpecialStateNot = false;
			this.table1.Add (this.enumcomboOperation);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1 [this.enumcomboOperation]));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(2));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hbox6 = new global::Gtk.HBox ();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.yspinMoney = new global::Gamma.GtkWidgets.ySpinButton (0, 1000000, 100);
			this.yspinMoney.CanFocus = true;
			this.yspinMoney.Name = "yspinMoney";
			this.yspinMoney.Adjustment.PageIncrement = 1000;
			this.yspinMoney.ClimbRate = 1;
			this.yspinMoney.Digits = ((uint)(2));
			this.yspinMoney.Numeric = true;
			this.yspinMoney.ValueAsDecimal = 0m;
			this.hbox6.Add (this.yspinMoney);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.yspinMoney]));
			w10.Position = 0;
			// Container child hbox6.Gtk.Box+BoxChild
			this.currencylabel1 = new global::QSProjectsLib.CurrencyLabel ();
			this.currencylabel1.Name = "currencylabel1";
			this.currencylabel1.LabelProp = global::Mono.Unix.Catalog.GetString ("currencylabel1");
			this.hbox6.Add (this.currencylabel1);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.currencylabel1]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			this.table1.Add (this.hbox6);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1 [this.hbox6]));
			w12.TopAttach = ((uint)(5));
			w12.BottomAttach = ((uint)(6));
			w12.LeftAttach = ((uint)(1));
			w12.RightAttach = ((uint)(2));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 1F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Дата:");
			this.table1.Add (this.label1);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1 [this.label1]));
			w13.TopAttach = ((uint)(1));
			w13.BottomAttach = ((uint)(2));
			w13.LeftAttach = ((uint)(2));
			w13.RightAttach = ((uint)(3));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xalign = 1F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Кассир:");
			this.table1.Add (this.label2);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table1 [this.label2]));
			w14.LeftAttach = ((uint)(2));
			w14.RightAttach = ((uint)(3));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 1F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Тип операции:");
			this.table1.Add (this.label3);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table1 [this.label3]));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.Xalign = 1F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Сумма:");
			this.table1.Add (this.label5);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table1 [this.label5]));
			w16.TopAttach = ((uint)(5));
			w16.BottomAttach = ((uint)(6));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelClientTitle = new global::Gtk.Label ();
			this.labelClientTitle.Name = "labelClientTitle";
			this.labelClientTitle.Xalign = 1F;
			this.labelClientTitle.LabelProp = global::Mono.Unix.Catalog.GetString ("Клиент:");
			this.table1.Add (this.labelClientTitle);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelClientTitle]));
			w17.TopAttach = ((uint)(3));
			w17.BottomAttach = ((uint)(4));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelEmploeey = new global::Gtk.Label ();
			this.labelEmploeey.Name = "labelEmploeey";
			this.labelEmploeey.Xalign = 1F;
			this.labelEmploeey.LabelProp = global::Mono.Unix.Catalog.GetString ("Сотрудник:");
			this.table1.Add (this.labelEmploeey);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelEmploeey]));
			w18.TopAttach = ((uint)(4));
			w18.BottomAttach = ((uint)(5));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelExpenseTitle = new global::Gtk.Label ();
			this.labelExpenseTitle.Name = "labelExpenseTitle";
			this.labelExpenseTitle.Xalign = 1F;
			this.labelExpenseTitle.LabelProp = global::Mono.Unix.Catalog.GetString ("Статья расхода:");
			this.table1.Add (this.labelExpenseTitle);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelExpenseTitle]));
			w19.TopAttach = ((uint)(2));
			w19.BottomAttach = ((uint)(3));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelIncomeTitle = new global::Gtk.Label ();
			this.labelIncomeTitle.Name = "labelIncomeTitle";
			this.labelIncomeTitle.Xalign = 1F;
			this.labelIncomeTitle.LabelProp = global::Mono.Unix.Catalog.GetString ("Статья дохода:");
			this.table1.Add (this.labelIncomeTitle);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelIncomeTitle]));
			w20.TopAttach = ((uint)(1));
			w20.BottomAttach = ((uint)(2));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.ydateDocument = new global::Gamma.Widgets.yDatePicker ();
			this.ydateDocument.Events = ((global::Gdk.EventMask)(256));
			this.ydateDocument.Name = "ydateDocument";
			this.ydateDocument.Date = new global::System.DateTime (0);
			this.ydateDocument.IsEditable = false;
			this.ydateDocument.AutoSeparation = true;
			this.table1.Add (this.ydateDocument);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table1 [this.ydateDocument]));
			w21.TopAttach = ((uint)(1));
			w21.BottomAttach = ((uint)(2));
			w21.LeftAttach = ((uint)(3));
			w21.RightAttach = ((uint)(4));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.yentryCasher = new global::Gamma.Widgets.yEntryReference ();
			this.yentryCasher.Sensitive = false;
			this.yentryCasher.Events = ((global::Gdk.EventMask)(256));
			this.yentryCasher.Name = "yentryCasher";
			this.table1.Add (this.yentryCasher);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table1 [this.yentryCasher]));
			w22.LeftAttach = ((uint)(3));
			w22.RightAttach = ((uint)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.yentryClient = new global::Gamma.Widgets.yEntryReference ();
			this.yentryClient.Events = ((global::Gdk.EventMask)(256));
			this.yentryClient.Name = "yentryClient";
			this.table1.Add (this.yentryClient);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table1 [this.yentryClient]));
			w23.TopAttach = ((uint)(3));
			w23.BottomAttach = ((uint)(4));
			w23.LeftAttach = ((uint)(1));
			w23.RightAttach = ((uint)(2));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.yentryEmploeey = new global::Gamma.Widgets.yEntryReference ();
			this.yentryEmploeey.Events = ((global::Gdk.EventMask)(256));
			this.yentryEmploeey.Name = "yentryEmploeey";
			this.table1.Add (this.yentryEmploeey);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.table1 [this.yentryEmploeey]));
			w24.TopAttach = ((uint)(4));
			w24.BottomAttach = ((uint)(5));
			w24.LeftAttach = ((uint)(1));
			w24.RightAttach = ((uint)(2));
			w24.XOptions = ((global::Gtk.AttachOptions)(4));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.yentryExpense = new global::Gamma.Widgets.yEntryReference ();
			this.yentryExpense.Events = ((global::Gdk.EventMask)(256));
			this.yentryExpense.Name = "yentryExpense";
			this.table1.Add (this.yentryExpense);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table1 [this.yentryExpense]));
			w25.TopAttach = ((uint)(2));
			w25.BottomAttach = ((uint)(3));
			w25.LeftAttach = ((uint)(1));
			w25.RightAttach = ((uint)(2));
			w25.XOptions = ((global::Gtk.AttachOptions)(4));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox1.Add (this.table1);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.table1]));
			w26.Position = 1;
			w26.Expand = false;
			w26.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.Xalign = 0F;
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Основание:");
			this.vbox1.Add (this.label6);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.label6]));
			w27.Position = 2;
			w27.Expand = false;
			w27.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.ytextviewDescription = new global::Gamma.GtkWidgets.yTextView ();
			this.ytextviewDescription.CanFocus = true;
			this.ytextviewDescription.Name = "ytextviewDescription";
			this.GtkScrolledWindow.Add (this.ytextviewDescription);
			this.vbox1.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.GtkScrolledWindow]));
			w29.Position = 3;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.buttonSave.Clicked += new global::System.EventHandler (this.OnButtonSaveClicked);
			this.buttonCancel.Clicked += new global::System.EventHandler (this.OnButtonCancelClicked);
			this.buttonPrint.Clicked += new global::System.EventHandler (this.OnButtonPrintClicked);
			this.enumcomboOperation.EnumItemSelected += new global::System.EventHandler<Gamma.Widgets.ItemSelectedEventArgs> (this.OnEnumcomboOperationEnumItemSelected);
		}
	}
}
