
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz.Dialogs.Cash.CashTransfer
{
	public partial class CommonCashTransferDlg
	{
		private global::Gtk.VBox vboxDialog;

		private global::Gtk.HBox hboxDialogButtons;

		private global::Gamma.GtkWidgets.yButton buttonSave;

		private global::Gamma.GtkWidgets.yButton buttonCancel;

		private global::Gtk.Button buttonPrint;

		private global::Gtk.Table tableState;

		private global::Gtk.Label labelAuthor;

		private global::Gtk.Label labelCreationDate;

		private global::Gtk.Label labelStatus;

		private global::Gamma.GtkWidgets.yLabel ylabelAuthor;

		private global::Gamma.GtkWidgets.yLabel ylabelCreationDate;

		private global::Gamma.GtkWidgets.yLabel ylabelStatus;

		private global::Gtk.HSeparator hseparator2;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Label labelDriver;

		private global::QS.Widgets.GtkUI.RepresentationEntry entryDriver;

		private global::Gtk.Label labelCar;

		private global::QS.Widgets.GtkUI.EntityViewModelEntry entityviewmodelentryCar;

		private global::Gtk.HBox hboxTransferInfo;

		private global::Gtk.Table tableFrom;

		private global::Gamma.GtkWidgets.yButton buttonSend;

		private global::Gamma.Widgets.ySpecComboBox comboboxCashSubdivisionFrom;

		private global::Gamma.Widgets.ySpecComboBox comboExpenseCategory;

		private global::Gtk.Label labelCashierSender;

		private global::Gtk.Label labelCashSubdivisionFrom;

		private global::Gtk.Label labelExpenseCategory;

		private global::Gtk.Label labelSendDate;

		private global::Gamma.GtkWidgets.yLabel ylabelCashierSender;

		private global::Gamma.GtkWidgets.yLabel ylabelSendTime;

		private global::Gtk.Table tableTo;

		private global::Gamma.GtkWidgets.yButton buttonReceive;

		private global::Gamma.Widgets.ySpecComboBox comboboxCashSubdivisionTo;

		private global::Gamma.Widgets.ySpecComboBox comboIncomeCategory;

		private global::Gtk.Label labelCashierReceiver;

		private global::Gtk.Label labelCashSubdivisionFrom1;

		private global::Gtk.Label labelIncomeCategory;

		private global::Gtk.Label labelReceiveDate;

		private global::Gamma.GtkWidgets.yLabel ylabelCashierReceiver;

		private global::Gamma.GtkWidgets.yLabel ylabelReceiveTime;

		private global::Gtk.HSeparator hseparator1;

		private global::Gtk.HBox hbox6;

		private global::Gtk.Label labelSum;

		private global::Gamma.GtkWidgets.ySpinButton yspinMoney;

		private global::Gtk.Label labelComment;

		private global::Gtk.ScrolledWindow GtkScrolledWindow2;

		private global::Gamma.GtkWidgets.yTextView ytextviewComment;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.Dialogs.Cash.CashTransfer.CommonCashTransferDlg
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.Dialogs.Cash.CashTransfer.CommonCashTransferDlg";
			// Container child Vodovoz.Dialogs.Cash.CashTransfer.CommonCashTransferDlg.Gtk.Container+ContainerChild
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
			// Container child hboxDialogButtons.Gtk.Box+BoxChild
			this.buttonPrint = new global::Gtk.Button();
			this.buttonPrint.CanFocus = true;
			this.buttonPrint.Name = "buttonPrint";
			this.buttonPrint.UseUnderline = true;
			this.buttonPrint.Label = global::Mono.Unix.Catalog.GetString("Печать");
			global::Gtk.Image w5 = new global::Gtk.Image();
			w5.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-print", global::Gtk.IconSize.Menu);
			this.buttonPrint.Image = w5;
			this.hboxDialogButtons.Add(this.buttonPrint);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hboxDialogButtons[this.buttonPrint]));
			w6.Position = 3;
			w6.Expand = false;
			w6.Fill = false;
			this.vboxDialog.Add(this.hboxDialogButtons);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vboxDialog[this.hboxDialogButtons]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vboxDialog.Gtk.Box+BoxChild
			this.tableState = new global::Gtk.Table(((uint)(1)), ((uint)(6)), false);
			this.tableState.Name = "tableState";
			this.tableState.RowSpacing = ((uint)(6));
			this.tableState.ColumnSpacing = ((uint)(6));
			// Container child tableState.Gtk.Table+TableChild
			this.labelAuthor = new global::Gtk.Label();
			this.labelAuthor.Name = "labelAuthor";
			this.labelAuthor.Xalign = 1F;
			this.labelAuthor.LabelProp = global::Mono.Unix.Catalog.GetString("Автор:");
			this.tableState.Add(this.labelAuthor);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.tableState[this.labelAuthor]));
			w8.LeftAttach = ((uint)(2));
			w8.RightAttach = ((uint)(3));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableState.Gtk.Table+TableChild
			this.labelCreationDate = new global::Gtk.Label();
			this.labelCreationDate.Name = "labelCreationDate";
			this.labelCreationDate.Xalign = 1F;
			this.labelCreationDate.LabelProp = global::Mono.Unix.Catalog.GetString("Дата создания:");
			this.tableState.Add(this.labelCreationDate);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.tableState[this.labelCreationDate]));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableState.Gtk.Table+TableChild
			this.labelStatus = new global::Gtk.Label();
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.Xalign = 1F;
			this.labelStatus.LabelProp = global::Mono.Unix.Catalog.GetString("Статус:");
			this.tableState.Add(this.labelStatus);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.tableState[this.labelStatus]));
			w10.LeftAttach = ((uint)(4));
			w10.RightAttach = ((uint)(5));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableState.Gtk.Table+TableChild
			this.ylabelAuthor = new global::Gamma.GtkWidgets.yLabel();
			this.ylabelAuthor.Name = "ylabelAuthor";
			this.ylabelAuthor.Xalign = 0F;
			this.tableState.Add(this.ylabelAuthor);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.tableState[this.ylabelAuthor]));
			w11.LeftAttach = ((uint)(3));
			w11.RightAttach = ((uint)(4));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableState.Gtk.Table+TableChild
			this.ylabelCreationDate = new global::Gamma.GtkWidgets.yLabel();
			this.ylabelCreationDate.Name = "ylabelCreationDate";
			this.ylabelCreationDate.Xalign = 0F;
			this.tableState.Add(this.ylabelCreationDate);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.tableState[this.ylabelCreationDate]));
			w12.LeftAttach = ((uint)(1));
			w12.RightAttach = ((uint)(2));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableState.Gtk.Table+TableChild
			this.ylabelStatus = new global::Gamma.GtkWidgets.yLabel();
			this.ylabelStatus.Name = "ylabelStatus";
			this.ylabelStatus.Xalign = 0F;
			this.tableState.Add(this.ylabelStatus);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.tableState[this.ylabelStatus]));
			w13.LeftAttach = ((uint)(5));
			w13.RightAttach = ((uint)(6));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vboxDialog.Add(this.tableState);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vboxDialog[this.tableState]));
			w14.Position = 1;
			w14.Expand = false;
			w14.Fill = false;
			// Container child vboxDialog.Gtk.Box+BoxChild
			this.hseparator2 = new global::Gtk.HSeparator();
			this.hseparator2.Name = "hseparator2";
			this.vboxDialog.Add(this.hseparator2);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vboxDialog[this.hseparator2]));
			w15.Position = 2;
			w15.Expand = false;
			w15.Fill = false;
			// Container child vboxDialog.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.labelDriver = new global::Gtk.Label();
			this.labelDriver.Name = "labelDriver";
			this.labelDriver.Xalign = 1F;
			this.labelDriver.LabelProp = global::Mono.Unix.Catalog.GetString("Водитель:");
			this.hbox2.Add(this.labelDriver);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.labelDriver]));
			w16.Position = 0;
			w16.Expand = false;
			w16.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.entryDriver = new global::QS.Widgets.GtkUI.RepresentationEntry();
			this.entryDriver.Events = ((global::Gdk.EventMask)(256));
			this.entryDriver.Name = "entryDriver";
			this.hbox2.Add(this.entryDriver);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.entryDriver]));
			w17.Position = 1;
			// Container child hbox2.Gtk.Box+BoxChild
			this.labelCar = new global::Gtk.Label();
			this.labelCar.Name = "labelCar";
			this.labelCar.Xalign = 1F;
			this.labelCar.LabelProp = global::Mono.Unix.Catalog.GetString("Автомобиль:");
			this.hbox2.Add(this.labelCar);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.labelCar]));
			w18.Position = 2;
			w18.Expand = false;
			w18.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.entityviewmodelentryCar = new global::QS.Widgets.GtkUI.EntityViewModelEntry();
			this.entityviewmodelentryCar.Events = ((global::Gdk.EventMask)(256));
			this.entityviewmodelentryCar.Name = "entityviewmodelentryCar";
			this.entityviewmodelentryCar.CanEditReference = true;
			this.hbox2.Add(this.entityviewmodelentryCar);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.entityviewmodelentryCar]));
			w19.Position = 3;
			this.vboxDialog.Add(this.hbox2);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vboxDialog[this.hbox2]));
			w20.Position = 3;
			w20.Expand = false;
			w20.Fill = false;
			// Container child vboxDialog.Gtk.Box+BoxChild
			this.hboxTransferInfo = new global::Gtk.HBox();
			this.hboxTransferInfo.Name = "hboxTransferInfo";
			this.hboxTransferInfo.Spacing = 6;
			// Container child hboxTransferInfo.Gtk.Box+BoxChild
			this.tableFrom = new global::Gtk.Table(((uint)(4)), ((uint)(3)), false);
			this.tableFrom.Name = "tableFrom";
			this.tableFrom.RowSpacing = ((uint)(6));
			this.tableFrom.ColumnSpacing = ((uint)(6));
			// Container child tableFrom.Gtk.Table+TableChild
			this.buttonSend = new global::Gamma.GtkWidgets.yButton();
			this.buttonSend.CanFocus = true;
			this.buttonSend.Name = "buttonSend";
			this.buttonSend.UseUnderline = true;
			this.buttonSend.Label = global::Mono.Unix.Catalog.GetString("Отправить");
			this.tableFrom.Add(this.buttonSend);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.tableFrom[this.buttonSend]));
			w21.TopAttach = ((uint)(3));
			w21.BottomAttach = ((uint)(4));
			w21.LeftAttach = ((uint)(2));
			w21.RightAttach = ((uint)(3));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableFrom.Gtk.Table+TableChild
			this.comboboxCashSubdivisionFrom = new global::Gamma.Widgets.ySpecComboBox();
			this.comboboxCashSubdivisionFrom.Name = "comboboxCashSubdivisionFrom";
			this.comboboxCashSubdivisionFrom.AddIfNotExist = false;
			this.comboboxCashSubdivisionFrom.DefaultFirst = false;
			this.comboboxCashSubdivisionFrom.ShowSpecialStateAll = false;
			this.comboboxCashSubdivisionFrom.ShowSpecialStateNot = true;
			this.tableFrom.Add(this.comboboxCashSubdivisionFrom);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.tableFrom[this.comboboxCashSubdivisionFrom]));
			w22.LeftAttach = ((uint)(1));
			w22.RightAttach = ((uint)(3));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableFrom.Gtk.Table+TableChild
			this.comboExpenseCategory = new global::Gamma.Widgets.ySpecComboBox();
			this.comboExpenseCategory.Name = "comboExpenseCategory";
			this.comboExpenseCategory.AddIfNotExist = false;
			this.comboExpenseCategory.DefaultFirst = false;
			this.comboExpenseCategory.ShowSpecialStateAll = false;
			this.comboExpenseCategory.ShowSpecialStateNot = true;
			this.tableFrom.Add(this.comboExpenseCategory);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.tableFrom[this.comboExpenseCategory]));
			w23.TopAttach = ((uint)(1));
			w23.BottomAttach = ((uint)(2));
			w23.LeftAttach = ((uint)(1));
			w23.RightAttach = ((uint)(3));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableFrom.Gtk.Table+TableChild
			this.labelCashierSender = new global::Gtk.Label();
			this.labelCashierSender.Name = "labelCashierSender";
			this.labelCashierSender.Xalign = 1F;
			this.labelCashierSender.LabelProp = global::Mono.Unix.Catalog.GetString("Отправил:");
			this.tableFrom.Add(this.labelCashierSender);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.tableFrom[this.labelCashierSender]));
			w24.TopAttach = ((uint)(2));
			w24.BottomAttach = ((uint)(3));
			w24.XOptions = ((global::Gtk.AttachOptions)(4));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableFrom.Gtk.Table+TableChild
			this.labelCashSubdivisionFrom = new global::Gtk.Label();
			this.labelCashSubdivisionFrom.Name = "labelCashSubdivisionFrom";
			this.labelCashSubdivisionFrom.Xalign = 1F;
			this.labelCashSubdivisionFrom.LabelProp = global::Mono.Unix.Catalog.GetString("Из кассы:");
			this.tableFrom.Add(this.labelCashSubdivisionFrom);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.tableFrom[this.labelCashSubdivisionFrom]));
			w25.XOptions = ((global::Gtk.AttachOptions)(4));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableFrom.Gtk.Table+TableChild
			this.labelExpenseCategory = new global::Gtk.Label();
			this.labelExpenseCategory.Name = "labelExpenseCategory";
			this.labelExpenseCategory.Xalign = 1F;
			this.labelExpenseCategory.LabelProp = global::Mono.Unix.Catalog.GetString("Статья расхода:");
			this.tableFrom.Add(this.labelExpenseCategory);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.tableFrom[this.labelExpenseCategory]));
			w26.TopAttach = ((uint)(1));
			w26.BottomAttach = ((uint)(2));
			w26.XOptions = ((global::Gtk.AttachOptions)(4));
			w26.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableFrom.Gtk.Table+TableChild
			this.labelSendDate = new global::Gtk.Label();
			this.labelSendDate.Name = "labelSendDate";
			this.labelSendDate.Xalign = 1F;
			this.labelSendDate.LabelProp = global::Mono.Unix.Catalog.GetString("Время отправки:");
			this.tableFrom.Add(this.labelSendDate);
			global::Gtk.Table.TableChild w27 = ((global::Gtk.Table.TableChild)(this.tableFrom[this.labelSendDate]));
			w27.TopAttach = ((uint)(3));
			w27.BottomAttach = ((uint)(4));
			w27.XOptions = ((global::Gtk.AttachOptions)(4));
			w27.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableFrom.Gtk.Table+TableChild
			this.ylabelCashierSender = new global::Gamma.GtkWidgets.yLabel();
			this.ylabelCashierSender.Name = "ylabelCashierSender";
			this.ylabelCashierSender.Xalign = 0F;
			this.tableFrom.Add(this.ylabelCashierSender);
			global::Gtk.Table.TableChild w28 = ((global::Gtk.Table.TableChild)(this.tableFrom[this.ylabelCashierSender]));
			w28.TopAttach = ((uint)(2));
			w28.BottomAttach = ((uint)(3));
			w28.LeftAttach = ((uint)(1));
			w28.RightAttach = ((uint)(3));
			w28.XOptions = ((global::Gtk.AttachOptions)(4));
			w28.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableFrom.Gtk.Table+TableChild
			this.ylabelSendTime = new global::Gamma.GtkWidgets.yLabel();
			this.ylabelSendTime.Name = "ylabelSendTime";
			this.ylabelSendTime.Xalign = 0F;
			this.tableFrom.Add(this.ylabelSendTime);
			global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.tableFrom[this.ylabelSendTime]));
			w29.TopAttach = ((uint)(3));
			w29.BottomAttach = ((uint)(4));
			w29.LeftAttach = ((uint)(1));
			w29.RightAttach = ((uint)(2));
			w29.XOptions = ((global::Gtk.AttachOptions)(4));
			w29.YOptions = ((global::Gtk.AttachOptions)(4));
			this.hboxTransferInfo.Add(this.tableFrom);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hboxTransferInfo[this.tableFrom]));
			w30.Position = 0;
			// Container child hboxTransferInfo.Gtk.Box+BoxChild
			this.tableTo = new global::Gtk.Table(((uint)(4)), ((uint)(3)), false);
			this.tableTo.Name = "tableTo";
			this.tableTo.RowSpacing = ((uint)(6));
			this.tableTo.ColumnSpacing = ((uint)(6));
			// Container child tableTo.Gtk.Table+TableChild
			this.buttonReceive = new global::Gamma.GtkWidgets.yButton();
			this.buttonReceive.CanFocus = true;
			this.buttonReceive.Name = "buttonReceive";
			this.buttonReceive.UseUnderline = true;
			this.buttonReceive.Label = global::Mono.Unix.Catalog.GetString("Принять");
			this.tableTo.Add(this.buttonReceive);
			global::Gtk.Table.TableChild w31 = ((global::Gtk.Table.TableChild)(this.tableTo[this.buttonReceive]));
			w31.TopAttach = ((uint)(3));
			w31.BottomAttach = ((uint)(4));
			w31.LeftAttach = ((uint)(2));
			w31.RightAttach = ((uint)(3));
			w31.XOptions = ((global::Gtk.AttachOptions)(4));
			w31.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableTo.Gtk.Table+TableChild
			this.comboboxCashSubdivisionTo = new global::Gamma.Widgets.ySpecComboBox();
			this.comboboxCashSubdivisionTo.Name = "comboboxCashSubdivisionTo";
			this.comboboxCashSubdivisionTo.AddIfNotExist = false;
			this.comboboxCashSubdivisionTo.DefaultFirst = false;
			this.comboboxCashSubdivisionTo.ShowSpecialStateAll = false;
			this.comboboxCashSubdivisionTo.ShowSpecialStateNot = true;
			this.tableTo.Add(this.comboboxCashSubdivisionTo);
			global::Gtk.Table.TableChild w32 = ((global::Gtk.Table.TableChild)(this.tableTo[this.comboboxCashSubdivisionTo]));
			w32.LeftAttach = ((uint)(1));
			w32.RightAttach = ((uint)(3));
			w32.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableTo.Gtk.Table+TableChild
			this.comboIncomeCategory = new global::Gamma.Widgets.ySpecComboBox();
			this.comboIncomeCategory.Name = "comboIncomeCategory";
			this.comboIncomeCategory.AddIfNotExist = false;
			this.comboIncomeCategory.DefaultFirst = false;
			this.comboIncomeCategory.ShowSpecialStateAll = false;
			this.comboIncomeCategory.ShowSpecialStateNot = true;
			this.tableTo.Add(this.comboIncomeCategory);
			global::Gtk.Table.TableChild w33 = ((global::Gtk.Table.TableChild)(this.tableTo[this.comboIncomeCategory]));
			w33.TopAttach = ((uint)(1));
			w33.BottomAttach = ((uint)(2));
			w33.LeftAttach = ((uint)(1));
			w33.RightAttach = ((uint)(3));
			w33.XOptions = ((global::Gtk.AttachOptions)(4));
			w33.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableTo.Gtk.Table+TableChild
			this.labelCashierReceiver = new global::Gtk.Label();
			this.labelCashierReceiver.Name = "labelCashierReceiver";
			this.labelCashierReceiver.Xalign = 1F;
			this.labelCashierReceiver.LabelProp = global::Mono.Unix.Catalog.GetString("Получил:");
			this.tableTo.Add(this.labelCashierReceiver);
			global::Gtk.Table.TableChild w34 = ((global::Gtk.Table.TableChild)(this.tableTo[this.labelCashierReceiver]));
			w34.TopAttach = ((uint)(2));
			w34.BottomAttach = ((uint)(3));
			w34.XOptions = ((global::Gtk.AttachOptions)(4));
			w34.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableTo.Gtk.Table+TableChild
			this.labelCashSubdivisionFrom1 = new global::Gtk.Label();
			this.labelCashSubdivisionFrom1.Name = "labelCashSubdivisionFrom1";
			this.labelCashSubdivisionFrom1.Xalign = 1F;
			this.labelCashSubdivisionFrom1.LabelProp = global::Mono.Unix.Catalog.GetString("В кассу:");
			this.tableTo.Add(this.labelCashSubdivisionFrom1);
			global::Gtk.Table.TableChild w35 = ((global::Gtk.Table.TableChild)(this.tableTo[this.labelCashSubdivisionFrom1]));
			w35.XOptions = ((global::Gtk.AttachOptions)(4));
			w35.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableTo.Gtk.Table+TableChild
			this.labelIncomeCategory = new global::Gtk.Label();
			this.labelIncomeCategory.Name = "labelIncomeCategory";
			this.labelIncomeCategory.Xalign = 1F;
			this.labelIncomeCategory.LabelProp = global::Mono.Unix.Catalog.GetString("Статья прихода:");
			this.tableTo.Add(this.labelIncomeCategory);
			global::Gtk.Table.TableChild w36 = ((global::Gtk.Table.TableChild)(this.tableTo[this.labelIncomeCategory]));
			w36.TopAttach = ((uint)(1));
			w36.BottomAttach = ((uint)(2));
			w36.XOptions = ((global::Gtk.AttachOptions)(4));
			w36.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableTo.Gtk.Table+TableChild
			this.labelReceiveDate = new global::Gtk.Label();
			this.labelReceiveDate.Name = "labelReceiveDate";
			this.labelReceiveDate.Xalign = 1F;
			this.labelReceiveDate.LabelProp = global::Mono.Unix.Catalog.GetString("Время получения:");
			this.tableTo.Add(this.labelReceiveDate);
			global::Gtk.Table.TableChild w37 = ((global::Gtk.Table.TableChild)(this.tableTo[this.labelReceiveDate]));
			w37.TopAttach = ((uint)(3));
			w37.BottomAttach = ((uint)(4));
			w37.XOptions = ((global::Gtk.AttachOptions)(4));
			w37.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableTo.Gtk.Table+TableChild
			this.ylabelCashierReceiver = new global::Gamma.GtkWidgets.yLabel();
			this.ylabelCashierReceiver.Name = "ylabelCashierReceiver";
			this.ylabelCashierReceiver.Xalign = 0F;
			this.tableTo.Add(this.ylabelCashierReceiver);
			global::Gtk.Table.TableChild w38 = ((global::Gtk.Table.TableChild)(this.tableTo[this.ylabelCashierReceiver]));
			w38.TopAttach = ((uint)(2));
			w38.BottomAttach = ((uint)(3));
			w38.LeftAttach = ((uint)(1));
			w38.RightAttach = ((uint)(3));
			w38.XOptions = ((global::Gtk.AttachOptions)(4));
			w38.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableTo.Gtk.Table+TableChild
			this.ylabelReceiveTime = new global::Gamma.GtkWidgets.yLabel();
			this.ylabelReceiveTime.Name = "ylabelReceiveTime";
			this.ylabelReceiveTime.Xalign = 0F;
			this.tableTo.Add(this.ylabelReceiveTime);
			global::Gtk.Table.TableChild w39 = ((global::Gtk.Table.TableChild)(this.tableTo[this.ylabelReceiveTime]));
			w39.TopAttach = ((uint)(3));
			w39.BottomAttach = ((uint)(4));
			w39.LeftAttach = ((uint)(1));
			w39.RightAttach = ((uint)(2));
			w39.XOptions = ((global::Gtk.AttachOptions)(4));
			w39.YOptions = ((global::Gtk.AttachOptions)(4));
			this.hboxTransferInfo.Add(this.tableTo);
			global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.hboxTransferInfo[this.tableTo]));
			w40.Position = 1;
			this.vboxDialog.Add(this.hboxTransferInfo);
			global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.vboxDialog[this.hboxTransferInfo]));
			w41.Position = 4;
			w41.Expand = false;
			w41.Fill = false;
			// Container child vboxDialog.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator();
			this.hseparator1.Name = "hseparator1";
			this.vboxDialog.Add(this.hseparator1);
			global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.vboxDialog[this.hseparator1]));
			w42.Position = 5;
			w42.Expand = false;
			w42.Fill = false;
			// Container child vboxDialog.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.labelSum = new global::Gtk.Label();
			this.labelSum.Name = "labelSum";
			this.labelSum.Xalign = 1F;
			this.labelSum.LabelProp = global::Mono.Unix.Catalog.GetString("Сумма к отправке:");
			this.hbox6.Add(this.labelSum);
			global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.labelSum]));
			w43.Position = 0;
			w43.Expand = false;
			w43.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.yspinMoney = new global::Gamma.GtkWidgets.ySpinButton(0D, 999999999D, 100D);
			this.yspinMoney.CanDefault = true;
			this.yspinMoney.CanFocus = true;
			this.yspinMoney.Name = "yspinMoney";
			this.yspinMoney.Adjustment.PageIncrement = 1000D;
			this.yspinMoney.ClimbRate = 1D;
			this.yspinMoney.Digits = ((uint)(2));
			this.yspinMoney.Numeric = true;
			this.yspinMoney.ValueAsDecimal = 0m;
			this.yspinMoney.ValueAsInt = 0;
			this.hbox6.Add(this.yspinMoney);
			global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.yspinMoney]));
			w44.Position = 1;
			w44.Expand = false;
			w44.Fill = false;
			this.vboxDialog.Add(this.hbox6);
			global::Gtk.Box.BoxChild w45 = ((global::Gtk.Box.BoxChild)(this.vboxDialog[this.hbox6]));
			w45.Position = 6;
			w45.Expand = false;
			w45.Fill = false;
			// Container child vboxDialog.Gtk.Box+BoxChild
			this.labelComment = new global::Gtk.Label();
			this.labelComment.Name = "labelComment";
			this.labelComment.Xalign = 0F;
			this.labelComment.LabelProp = global::Mono.Unix.Catalog.GetString("Комментарий:");
			this.vboxDialog.Add(this.labelComment);
			global::Gtk.Box.BoxChild w46 = ((global::Gtk.Box.BoxChild)(this.vboxDialog[this.labelComment]));
			w46.Position = 7;
			w46.Expand = false;
			w46.Fill = false;
			// Container child vboxDialog.Gtk.Box+BoxChild
			this.GtkScrolledWindow2 = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow2.Name = "GtkScrolledWindow2";
			this.GtkScrolledWindow2.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow2.Gtk.Container+ContainerChild
			this.ytextviewComment = new global::Gamma.GtkWidgets.yTextView();
			this.ytextviewComment.CanFocus = true;
			this.ytextviewComment.Name = "ytextviewComment";
			this.GtkScrolledWindow2.Add(this.ytextviewComment);
			this.vboxDialog.Add(this.GtkScrolledWindow2);
			global::Gtk.Box.BoxChild w48 = ((global::Gtk.Box.BoxChild)(this.vboxDialog[this.GtkScrolledWindow2]));
			w48.Position = 8;
			this.Add(this.vboxDialog);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
			this.buttonSave.Clicked += new global::System.EventHandler(this.OnButtonSaveClicked);
			this.buttonCancel.Clicked += new global::System.EventHandler(this.OnButtonCancelClicked);
			this.buttonPrint.Clicked += new global::System.EventHandler(this.OnButtonPrintClicked);
			this.buttonSend.Clicked += new global::System.EventHandler(this.OnButtonSendClicked);
			this.buttonReceive.Clicked += new global::System.EventHandler(this.OnButtonReceiveClicked);
		}
	}
}
