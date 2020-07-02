
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz.Views
{
	public partial class ManualPaymentMatchingView
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Button btnSave;

		private global::Gtk.Button btnCancel;

		private global::Gtk.HSeparator hseparator1;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Label label5;

		private global::Gtk.Label labelPaymentNum;

		private global::Gtk.Label label6;

		private global::Gtk.Label labelPayer;

		private global::Gtk.Label label7;

		private global::Gtk.Label labelDate;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Label label11;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gamma.GtkWidgets.yTextView ytextviewPaymentPurpose;

		private global::Gtk.HSeparator hseparator2;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Label label13;

		private global::Gtk.Label labelTotalSum;

		private global::Gtk.Label label14;

		private global::Gtk.Label labelLastBalance;

		private global::Gtk.Label label15;

		private global::Gtk.Label labelToAllocate;

		private global::Gtk.HBox hbox11;

		private global::Gtk.Label label25;

		private global::QS.Widgets.GtkUI.DateRangePicker daterangepicker1;

		private global::Gtk.Label label26;

		private global::Gamma.Widgets.yEnumComboBox yenumcomboOrderStatus;

		private global::Gtk.Label label27;

		private global::Gamma.Widgets.yEnumComboBox yenumcomboOrderPaymentStatus;

		private global::Gtk.HBox hbox6;

		private global::Gtk.Label label19;

		private global::QS.Widgets.GtkUI.EntityViewModelEntry entryCounterparty;

		private global::Gtk.Button button1;

		private global::Gtk.HBox hboxSearch;

		private global::Gtk.ScrolledWindow scrolledwindow1;

		private global::Gamma.GtkWidgets.yTreeView ytreeviewOrdersAllocate;

		private global::Gtk.HBox hbox9;

		private global::Gtk.Label label20;

		private global::Gtk.ScrolledWindow scrolledwindow2;

		private global::Gamma.GtkWidgets.yTextView ytextviewComments;

		private global::Gtk.VBox vbox3;

		private global::Gtk.HBox hbox10;

		private global::Gtk.Label label21;

		private global::Gamma.GtkWidgets.yLabel ylabelAllocated;

		private global::Gtk.HBox hbox12;

		private global::Gtk.Label label22;

		private global::Gamma.GtkWidgets.yLabel ylabelCurBalance;

		private global::Gtk.Button buttonComplete;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.Views.ManualPaymentMatchingView
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.Views.ManualPaymentMatchingView";
			// Container child Vodovoz.Views.ManualPaymentMatchingView.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.btnSave = new global::Gtk.Button();
			this.btnSave.CanFocus = true;
			this.btnSave.Name = "btnSave";
			this.btnSave.UseUnderline = true;
			this.btnSave.Label = global::Mono.Unix.Catalog.GetString("Сохранить");
			global::Gtk.Image w1 = new global::Gtk.Image();
			w1.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-save", global::Gtk.IconSize.Menu);
			this.btnSave.Image = w1;
			this.hbox1.Add(this.btnSave);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.btnSave]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.btnCancel = new global::Gtk.Button();
			this.btnCancel.CanFocus = true;
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.UseUnderline = true;
			this.btnCancel.Label = global::Mono.Unix.Catalog.GetString("Отмена");
			global::Gtk.Image w3 = new global::Gtk.Image();
			w3.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-revert-to-saved", global::Gtk.IconSize.Menu);
			this.btnCancel.Image = w3;
			this.hbox1.Add(this.btnCancel);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.btnCancel]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			this.vbox2.Add(this.hbox1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator();
			this.hseparator1.Name = "hseparator1";
			this.vbox2.Add(this.hseparator1);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hseparator1]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("№ платежа:");
			this.hbox2.Add(this.label5);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.label5]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.labelPaymentNum = new global::Gtk.Label();
			this.labelPaymentNum.Name = "labelPaymentNum";
			this.labelPaymentNum.LabelProp = global::Mono.Unix.Catalog.GetString("paymentNum");
			this.hbox2.Add(this.labelPaymentNum);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.labelPaymentNum]));
			w8.Position = 1;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("Плательщик:");
			this.hbox2.Add(this.label6);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.label6]));
			w9.Position = 2;
			w9.Expand = false;
			w9.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.labelPayer = new global::Gtk.Label();
			this.labelPayer.Name = "labelPayer";
			this.labelPayer.LabelProp = global::Mono.Unix.Catalog.GetString("Payer");
			this.hbox2.Add(this.labelPayer);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.labelPayer]));
			w10.Position = 3;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label7 = new global::Gtk.Label();
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("Дата:");
			this.hbox2.Add(this.label7);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.label7]));
			w11.Position = 4;
			w11.Expand = false;
			w11.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.labelDate = new global::Gtk.Label();
			this.labelDate.Name = "labelDate";
			this.labelDate.LabelProp = global::Mono.Unix.Catalog.GetString("Date");
			this.hbox2.Add(this.labelDate);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.labelDate]));
			w12.Position = 5;
			this.vbox2.Add(this.hbox2);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox2]));
			w13.Position = 2;
			w13.Expand = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.label11 = new global::Gtk.Label();
			this.label11.Name = "label11";
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString("Основание:");
			this.hbox3.Add(this.label11);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.label11]));
			w14.Position = 0;
			w14.Expand = false;
			w14.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.ytextviewPaymentPurpose = new global::Gamma.GtkWidgets.yTextView();
			this.ytextviewPaymentPurpose.CanFocus = true;
			this.ytextviewPaymentPurpose.Name = "ytextviewPaymentPurpose";
			this.ytextviewPaymentPurpose.Editable = false;
			this.ytextviewPaymentPurpose.WrapMode = ((global::Gtk.WrapMode)(2));
			this.GtkScrolledWindow.Add(this.ytextviewPaymentPurpose);
			this.hbox3.Add(this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.GtkScrolledWindow]));
			w16.Position = 1;
			this.vbox2.Add(this.hbox3);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox3]));
			w17.Position = 3;
			w17.Expand = false;
			w17.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hseparator2 = new global::Gtk.HSeparator();
			this.hseparator2.Name = "hseparator2";
			this.vbox2.Add(this.hseparator2);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hseparator2]));
			w18.Position = 4;
			w18.Expand = false;
			w18.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.label13 = new global::Gtk.Label();
			this.label13.Name = "label13";
			this.label13.LabelProp = global::Mono.Unix.Catalog.GetString("Сумма платежа:");
			this.hbox4.Add(this.label13);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.label13]));
			w19.Position = 0;
			w19.Expand = false;
			w19.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.labelTotalSum = new global::Gtk.Label();
			this.labelTotalSum.Name = "labelTotalSum";
			this.labelTotalSum.LabelProp = global::Mono.Unix.Catalog.GetString("TotalSum");
			this.hbox4.Add(this.labelTotalSum);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.labelTotalSum]));
			w20.Position = 1;
			// Container child hbox4.Gtk.Box+BoxChild
			this.label14 = new global::Gtk.Label();
			this.label14.Name = "label14";
			this.label14.LabelProp = global::Mono.Unix.Catalog.GetString("Прошлый остаток:");
			this.hbox4.Add(this.label14);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.label14]));
			w21.Position = 2;
			w21.Expand = false;
			w21.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.labelLastBalance = new global::Gtk.Label();
			this.labelLastBalance.Name = "labelLastBalance";
			this.labelLastBalance.LabelProp = global::Mono.Unix.Catalog.GetString("LastBalance");
			this.hbox4.Add(this.labelLastBalance);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.labelLastBalance]));
			w22.Position = 3;
			// Container child hbox4.Gtk.Box+BoxChild
			this.label15 = new global::Gtk.Label();
			this.label15.Name = "label15";
			this.label15.LabelProp = global::Mono.Unix.Catalog.GetString("К распределению:");
			this.hbox4.Add(this.label15);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.label15]));
			w23.Position = 4;
			w23.Expand = false;
			w23.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.labelToAllocate = new global::Gtk.Label();
			this.labelToAllocate.Name = "labelToAllocate";
			this.labelToAllocate.LabelProp = global::Mono.Unix.Catalog.GetString("ToAllocate");
			this.hbox4.Add(this.labelToAllocate);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.labelToAllocate]));
			w24.Position = 5;
			this.vbox2.Add(this.hbox4);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox4]));
			w25.Position = 5;
			w25.Expand = false;
			w25.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox11 = new global::Gtk.HBox();
			this.hbox11.Name = "hbox11";
			this.hbox11.Spacing = 6;
			// Container child hbox11.Gtk.Box+BoxChild
			this.label25 = new global::Gtk.Label();
			this.label25.Name = "label25";
			this.label25.LabelProp = global::Mono.Unix.Catalog.GetString("Период:");
			this.hbox11.Add(this.label25);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.label25]));
			w26.Position = 0;
			w26.Expand = false;
			w26.Fill = false;
			// Container child hbox11.Gtk.Box+BoxChild
			this.daterangepicker1 = new global::QS.Widgets.GtkUI.DateRangePicker();
			this.daterangepicker1.Events = ((global::Gdk.EventMask)(256));
			this.daterangepicker1.Name = "daterangepicker1";
			this.daterangepicker1.StartDate = new global::System.DateTime(0);
			this.daterangepicker1.EndDate = new global::System.DateTime(0);
			this.hbox11.Add(this.daterangepicker1);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.daterangepicker1]));
			w27.Position = 1;
			// Container child hbox11.Gtk.Box+BoxChild
			this.label26 = new global::Gtk.Label();
			this.label26.Name = "label26";
			this.label26.LabelProp = global::Mono.Unix.Catalog.GetString("Статус заказов:");
			this.hbox11.Add(this.label26);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.label26]));
			w28.Position = 2;
			w28.Expand = false;
			w28.Fill = false;
			// Container child hbox11.Gtk.Box+BoxChild
			this.yenumcomboOrderStatus = new global::Gamma.Widgets.yEnumComboBox();
			this.yenumcomboOrderStatus.Name = "yenumcomboOrderStatus";
			this.yenumcomboOrderStatus.ShowSpecialStateAll = true;
			this.yenumcomboOrderStatus.ShowSpecialStateNot = false;
			this.yenumcomboOrderStatus.UseShortTitle = false;
			this.yenumcomboOrderStatus.DefaultFirst = false;
			this.hbox11.Add(this.yenumcomboOrderStatus);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.yenumcomboOrderStatus]));
			w29.Position = 3;
			// Container child hbox11.Gtk.Box+BoxChild
			this.label27 = new global::Gtk.Label();
			this.label27.Name = "label27";
			this.label27.LabelProp = global::Mono.Unix.Catalog.GetString("Статус оплаты:");
			this.hbox11.Add(this.label27);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.label27]));
			w30.Position = 4;
			w30.Expand = false;
			w30.Fill = false;
			// Container child hbox11.Gtk.Box+BoxChild
			this.yenumcomboOrderPaymentStatus = new global::Gamma.Widgets.yEnumComboBox();
			this.yenumcomboOrderPaymentStatus.Name = "yenumcomboOrderPaymentStatus";
			this.yenumcomboOrderPaymentStatus.ShowSpecialStateAll = true;
			this.yenumcomboOrderPaymentStatus.ShowSpecialStateNot = false;
			this.yenumcomboOrderPaymentStatus.UseShortTitle = false;
			this.yenumcomboOrderPaymentStatus.DefaultFirst = false;
			this.hbox11.Add(this.yenumcomboOrderPaymentStatus);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.yenumcomboOrderPaymentStatus]));
			w31.Position = 5;
			this.vbox2.Add(this.hbox11);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox11]));
			w32.Position = 6;
			w32.Expand = false;
			w32.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.label19 = new global::Gtk.Label();
			this.label19.Name = "label19";
			this.label19.LabelProp = global::Mono.Unix.Catalog.GetString("Контрагент:");
			this.hbox6.Add(this.label19);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.label19]));
			w33.Position = 0;
			w33.Expand = false;
			w33.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.entryCounterparty = new global::QS.Widgets.GtkUI.EntityViewModelEntry();
			this.entryCounterparty.Events = ((global::Gdk.EventMask)(256));
			this.entryCounterparty.Name = "entryCounterparty";
			this.entryCounterparty.CanEditReference = true;
			this.hbox6.Add(this.entryCounterparty);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.entryCounterparty]));
			w34.Position = 1;
			w34.Expand = false;
			w34.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.button1 = new global::Gtk.Button();
			this.button1.CanFocus = true;
			this.button1.Name = "button1";
			this.button1.UseUnderline = true;
			this.button1.Label = global::Mono.Unix.Catalog.GetString("Добавить контрагента");
			this.hbox6.Add(this.button1);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.button1]));
			w35.Position = 2;
			w35.Expand = false;
			w35.Fill = false;
			this.vbox2.Add(this.hbox6);
			global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox6]));
			w36.Position = 7;
			w36.Expand = false;
			w36.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hboxSearch = new global::Gtk.HBox();
			this.hboxSearch.Name = "hboxSearch";
			this.hboxSearch.Spacing = 6;
			this.vbox2.Add(this.hboxSearch);
			global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hboxSearch]));
			w37.Position = 8;
			w37.Expand = false;
			w37.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.scrolledwindow1 = new global::Gtk.ScrolledWindow();
			this.scrolledwindow1.CanFocus = true;
			this.scrolledwindow1.Name = "scrolledwindow1";
			this.scrolledwindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow1.Gtk.Container+ContainerChild
			this.ytreeviewOrdersAllocate = new global::Gamma.GtkWidgets.yTreeView();
			this.ytreeviewOrdersAllocate.CanFocus = true;
			this.ytreeviewOrdersAllocate.Name = "ytreeviewOrdersAllocate";
			this.scrolledwindow1.Add(this.ytreeviewOrdersAllocate);
			this.vbox2.Add(this.scrolledwindow1);
			global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.scrolledwindow1]));
			w39.Position = 9;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox9 = new global::Gtk.HBox();
			this.hbox9.Name = "hbox9";
			this.hbox9.Spacing = 6;
			// Container child hbox9.Gtk.Box+BoxChild
			this.label20 = new global::Gtk.Label();
			this.label20.Name = "label20";
			this.label20.LabelProp = global::Mono.Unix.Catalog.GetString("Комментарий:");
			this.hbox9.Add(this.label20);
			global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.label20]));
			w40.Position = 0;
			w40.Expand = false;
			w40.Fill = false;
			// Container child hbox9.Gtk.Box+BoxChild
			this.scrolledwindow2 = new global::Gtk.ScrolledWindow();
			this.scrolledwindow2.CanFocus = true;
			this.scrolledwindow2.Name = "scrolledwindow2";
			this.scrolledwindow2.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow2.Gtk.Container+ContainerChild
			this.ytextviewComments = new global::Gamma.GtkWidgets.yTextView();
			this.ytextviewComments.CanFocus = true;
			this.ytextviewComments.Name = "ytextviewComments";
			this.scrolledwindow2.Add(this.ytextviewComments);
			this.hbox9.Add(this.scrolledwindow2);
			global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.scrolledwindow2]));
			w42.Position = 1;
			// Container child hbox9.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox10 = new global::Gtk.HBox();
			this.hbox10.Name = "hbox10";
			this.hbox10.Spacing = 6;
			// Container child hbox10.Gtk.Box+BoxChild
			this.label21 = new global::Gtk.Label();
			this.label21.Name = "label21";
			this.label21.LabelProp = global::Mono.Unix.Catalog.GetString("Распределено:");
			this.hbox10.Add(this.label21);
			global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.hbox10[this.label21]));
			w43.Position = 0;
			w43.Expand = false;
			w43.Fill = false;
			// Container child hbox10.Gtk.Box+BoxChild
			this.ylabelAllocated = new global::Gamma.GtkWidgets.yLabel();
			this.ylabelAllocated.Name = "ylabelAllocated";
			this.ylabelAllocated.LabelProp = global::Mono.Unix.Catalog.GetString("Allocated");
			this.hbox10.Add(this.ylabelAllocated);
			global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.hbox10[this.ylabelAllocated]));
			w44.Position = 1;
			w44.Expand = false;
			w44.Fill = false;
			this.vbox3.Add(this.hbox10);
			global::Gtk.Box.BoxChild w45 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox10]));
			w45.Position = 0;
			w45.Expand = false;
			w45.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox12 = new global::Gtk.HBox();
			this.hbox12.Name = "hbox12";
			this.hbox12.Spacing = 6;
			// Container child hbox12.Gtk.Box+BoxChild
			this.label22 = new global::Gtk.Label();
			this.label22.Name = "label22";
			this.label22.LabelProp = global::Mono.Unix.Catalog.GetString("Остаток:");
			this.hbox12.Add(this.label22);
			global::Gtk.Box.BoxChild w46 = ((global::Gtk.Box.BoxChild)(this.hbox12[this.label22]));
			w46.Position = 0;
			w46.Expand = false;
			w46.Fill = false;
			// Container child hbox12.Gtk.Box+BoxChild
			this.ylabelCurBalance = new global::Gamma.GtkWidgets.yLabel();
			this.ylabelCurBalance.Name = "ylabelCurBalance";
			this.ylabelCurBalance.LabelProp = global::Mono.Unix.Catalog.GetString("CurBalance");
			this.hbox12.Add(this.ylabelCurBalance);
			global::Gtk.Box.BoxChild w47 = ((global::Gtk.Box.BoxChild)(this.hbox12[this.ylabelCurBalance]));
			w47.Position = 1;
			w47.Expand = false;
			w47.Fill = false;
			this.vbox3.Add(this.hbox12);
			global::Gtk.Box.BoxChild w48 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox12]));
			w48.Position = 1;
			w48.Expand = false;
			w48.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.buttonComplete = new global::Gtk.Button();
			this.buttonComplete.CanFocus = true;
			this.buttonComplete.Name = "buttonComplete";
			this.buttonComplete.UseUnderline = true;
			this.buttonComplete.Label = global::Mono.Unix.Catalog.GetString("Завершить распределение");
			this.vbox3.Add(this.buttonComplete);
			global::Gtk.Box.BoxChild w49 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.buttonComplete]));
			w49.Position = 2;
			w49.Expand = false;
			w49.Fill = false;
			this.hbox9.Add(this.vbox3);
			global::Gtk.Box.BoxChild w50 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.vbox3]));
			w50.Position = 2;
			w50.Expand = false;
			w50.Fill = false;
			this.vbox2.Add(this.hbox9);
			global::Gtk.Box.BoxChild w51 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox9]));
			w51.Position = 10;
			w51.Expand = false;
			w51.Fill = false;
			this.Add(this.vbox2);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}