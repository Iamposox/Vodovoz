
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz
{
	public partial class NomenclatureDlg
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Button buttonSave;

		private global::Gtk.Button buttonCancel;

		private global::QSWidgetLib.MenuButton menuActions;

		private global::Gtk.RadioButton radioPrice;

		private global::Gtk.RadioButton radioEuqpment;

		private global::Gtk.RadioButton radioInfo;

		private global::Gtk.VSeparator vseparator1;

		private global::Gtk.Notebook notebook1;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.Table datatable1;

		private global::Gamma.GtkWidgets.yCheckButton checkHide;

		private global::Gamma.GtkWidgets.yCheckButton checkNoDeliver;

		private global::Gamma.GtkWidgets.yCheckButton checkNotReserve;

		private global::Gamma.GtkWidgets.yEntry entryCode1c;

		private global::Gamma.GtkWidgets.yEntry entryName;

		private global::Gamma.Widgets.yEnumComboBox enumType;

		private global::Gamma.Widgets.yEnumComboBox enumVAT;

		private global::Gtk.HBox hbox3;

		private global::Gamma.GtkWidgets.ySpinButton spinWeight;

		private global::Gtk.Label volumeLabel;

		private global::Gamma.GtkWidgets.ySpinButton spinVolume;

		private global::Gtk.HBox hbox8;

		private global::Gamma.GtkWidgets.ySpinButton yspinSumOfDamage;

		private global::QSProjectsLib.CurrencyLabel currencylabel2;

		private global::Gtk.Label label3;

		private global::Gtk.Label label4;

		private global::Gtk.Label label5;

		private global::Gtk.Label label7;

		private global::Gtk.Label label8;

		private global::Gtk.Label labelName;

		private global::Gtk.Label labelNoDeliver;

		private global::Gtk.Label labelReserve;

		private global::Gtk.Label labelReserve1;

		private global::Gtk.Label labelType;

		private global::Gtk.Label labelUnit;

		private global::Gtk.Label labelVAT;

		private global::Gtk.Label labelWeight;

		private global::Gamma.Widgets.yEntryReference referenceRouteColumn;

		private global::Gamma.Widgets.yEntryReference referenceUnit;

		private global::Gamma.Widgets.yEntryReference referenceWarehouse;

		private global::Gamma.GtkWidgets.yEntry yentryOfficialName;

		private global::Gamma.GtkWidgets.yEntry yentryShortName;

		private global::Gamma.GtkWidgets.yLabel ylabel1;

		private global::Gtk.Label label1;

		private global::Gtk.Table table1;

		private global::Gamma.GtkWidgets.yCheckButton checkSerial;

		private global::Gamma.GtkWidgets.yEntry entryModel;

		private global::Gtk.Label labelClass;

		private global::Gtk.Label labelColor;

		private global::Gtk.Label labelManufacturer;

		private global::Gtk.Label labelModel;

		private global::Gtk.Label labelRentPriority;

		private global::Gtk.Label labelSerial;

		private global::Gamma.Widgets.yEntryReference referenceColor;

		private global::Gamma.Widgets.yEntryReference referenceManufacturer;

		private global::Gamma.GtkWidgets.yCheckButton ycheckRentPriority;

		private global::Gamma.Widgets.yEntryReference yentryrefEqupmentType;

		private global::Gtk.Label label2;

		private global::Gtk.Table datatable2;

		private global::Vodovoz.PricesView pricesView;

		private global::Gtk.Label label6;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.NomenclatureDlg
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.NomenclatureDlg";
			// Container child Vodovoz.NomenclatureDlg.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonSave = new global::Gtk.Button();
			this.buttonSave.CanFocus = true;
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.UseUnderline = true;
			this.buttonSave.Label = global::Mono.Unix.Catalog.GetString("Сохранить");
			global::Gtk.Image w1 = new global::Gtk.Image();
			w1.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-floppy", global::Gtk.IconSize.Menu);
			this.buttonSave.Image = w1;
			this.hbox1.Add(this.buttonSave);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.buttonSave]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonCancel = new global::Gtk.Button();
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = global::Mono.Unix.Catalog.GetString("Отменить");
			global::Gtk.Image w3 = new global::Gtk.Image();
			w3.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-revert-to-saved", global::Gtk.IconSize.Menu);
			this.buttonCancel.Image = w3;
			this.hbox1.Add(this.buttonCancel);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.buttonCancel]));
			w4.Position = 1;
			w4.Expand = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.menuActions = new global::QSWidgetLib.MenuButton();
			this.menuActions.CanFocus = true;
			this.menuActions.Name = "menuActions";
			this.menuActions.UseUnderline = true;
			this.menuActions.UseMarkup = false;
			global::Gtk.Image w5 = new global::Gtk.Image();
			w5.Pixbuf = global::Gdk.Pixbuf.LoadFromResource("Vodovoz.icons.buttons.menu.png");
			this.menuActions.Image = w5;
			this.hbox1.Add(this.menuActions);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.menuActions]));
			w6.Position = 2;
			w6.Expand = false;
			w6.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.radioPrice = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Цены"));
			this.radioPrice.CanFocus = true;
			this.radioPrice.Name = "radioPrice";
			this.radioPrice.DrawIndicator = false;
			this.radioPrice.UseUnderline = true;
			this.radioPrice.Group = new global::GLib.SList(global::System.IntPtr.Zero);
			this.hbox1.Add(this.radioPrice);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.radioPrice]));
			w7.PackType = ((global::Gtk.PackType)(1));
			w7.Position = 3;
			// Container child hbox1.Gtk.Box+BoxChild
			this.radioEuqpment = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Оборудование"));
			this.radioEuqpment.CanFocus = true;
			this.radioEuqpment.Name = "radioEuqpment";
			this.radioEuqpment.DrawIndicator = false;
			this.radioEuqpment.UseUnderline = true;
			this.radioEuqpment.Group = this.radioPrice.Group;
			this.hbox1.Add(this.radioEuqpment);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.radioEuqpment]));
			w8.PackType = ((global::Gtk.PackType)(1));
			w8.Position = 4;
			// Container child hbox1.Gtk.Box+BoxChild
			this.radioInfo = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Информация"));
			this.radioInfo.CanFocus = true;
			this.radioInfo.Name = "radioInfo";
			this.radioInfo.DrawIndicator = false;
			this.radioInfo.UseUnderline = true;
			this.radioInfo.Group = this.radioPrice.Group;
			this.hbox1.Add(this.radioInfo);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.radioInfo]));
			w9.PackType = ((global::Gtk.PackType)(1));
			w9.Position = 5;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vseparator1 = new global::Gtk.VSeparator();
			this.vseparator1.Name = "vseparator1";
			this.hbox1.Add(this.vseparator1);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vseparator1]));
			w10.PackType = ((global::Gtk.PackType)(1));
			w10.Position = 6;
			w10.Expand = false;
			w10.Fill = false;
			this.vbox1.Add(this.hbox1);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.notebook1 = new global::Gtk.Notebook();
			this.notebook1.CanFocus = true;
			this.notebook1.Name = "notebook1";
			this.notebook1.CurrentPage = 1;
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			global::Gtk.Viewport w12 = new global::Gtk.Viewport();
			w12.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport.Gtk.Container+ContainerChild
			this.datatable1 = new global::Gtk.Table(((uint)(14)), ((uint)(2)), false);
			this.datatable1.Name = "datatable1";
			this.datatable1.RowSpacing = ((uint)(6));
			this.datatable1.ColumnSpacing = ((uint)(6));
			this.datatable1.BorderWidth = ((uint)(6));
			// Container child datatable1.Gtk.Table+TableChild
			this.checkHide = new global::Gamma.GtkWidgets.yCheckButton();
			this.checkHide.CanFocus = true;
			this.checkHide.Name = "checkHide";
			this.checkHide.Label = "";
			this.checkHide.DrawIndicator = true;
			this.checkHide.UseUnderline = true;
			this.datatable1.Add(this.checkHide);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.datatable1[this.checkHide]));
			w13.TopAttach = ((uint)(12));
			w13.BottomAttach = ((uint)(13));
			w13.LeftAttach = ((uint)(1));
			w13.RightAttach = ((uint)(2));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.checkNoDeliver = new global::Gamma.GtkWidgets.yCheckButton();
			this.checkNoDeliver.CanFocus = true;
			this.checkNoDeliver.Name = "checkNoDeliver";
			this.checkNoDeliver.Label = "";
			this.checkNoDeliver.DrawIndicator = true;
			this.checkNoDeliver.UseUnderline = true;
			this.datatable1.Add(this.checkNoDeliver);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.datatable1[this.checkNoDeliver]));
			w14.TopAttach = ((uint)(13));
			w14.BottomAttach = ((uint)(14));
			w14.LeftAttach = ((uint)(1));
			w14.RightAttach = ((uint)(2));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.checkNotReserve = new global::Gamma.GtkWidgets.yCheckButton();
			this.checkNotReserve.CanFocus = true;
			this.checkNotReserve.Name = "checkNotReserve";
			this.checkNotReserve.Label = "";
			this.checkNotReserve.DrawIndicator = true;
			this.checkNotReserve.UseUnderline = true;
			this.datatable1.Add(this.checkNotReserve);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.datatable1[this.checkNotReserve]));
			w15.TopAttach = ((uint)(11));
			w15.BottomAttach = ((uint)(12));
			w15.LeftAttach = ((uint)(1));
			w15.RightAttach = ((uint)(2));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.entryCode1c = new global::Gamma.GtkWidgets.yEntry();
			this.entryCode1c.CanFocus = true;
			this.entryCode1c.Name = "entryCode1c";
			this.entryCode1c.IsEditable = true;
			this.entryCode1c.InvisibleChar = '●';
			this.datatable1.Add(this.entryCode1c);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.datatable1[this.entryCode1c]));
			w16.TopAttach = ((uint)(10));
			w16.BottomAttach = ((uint)(11));
			w16.LeftAttach = ((uint)(1));
			w16.RightAttach = ((uint)(2));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.entryName = new global::Gamma.GtkWidgets.yEntry();
			this.entryName.CanFocus = true;
			this.entryName.Name = "entryName";
			this.entryName.IsEditable = true;
			this.entryName.MaxLength = 220;
			this.entryName.InvisibleChar = '●';
			this.datatable1.Add(this.entryName);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.datatable1[this.entryName]));
			w17.LeftAttach = ((uint)(1));
			w17.RightAttach = ((uint)(2));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.enumType = new global::Gamma.Widgets.yEnumComboBox();
			this.enumType.Name = "enumType";
			this.enumType.ShowSpecialStateAll = false;
			this.enumType.ShowSpecialStateNot = false;
			this.enumType.UseShortTitle = false;
			this.enumType.DefaultFirst = true;
			this.datatable1.Add(this.enumType);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.datatable1[this.enumType]));
			w18.TopAttach = ((uint)(3));
			w18.BottomAttach = ((uint)(4));
			w18.LeftAttach = ((uint)(1));
			w18.RightAttach = ((uint)(2));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.enumVAT = new global::Gamma.Widgets.yEnumComboBox();
			this.enumVAT.Name = "enumVAT";
			this.enumVAT.ShowSpecialStateAll = false;
			this.enumVAT.ShowSpecialStateNot = false;
			this.enumVAT.UseShortTitle = false;
			this.enumVAT.DefaultFirst = true;
			this.datatable1.Add(this.enumVAT);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.datatable1[this.enumVAT]));
			w19.TopAttach = ((uint)(9));
			w19.BottomAttach = ((uint)(10));
			w19.LeftAttach = ((uint)(1));
			w19.RightAttach = ((uint)(2));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.spinWeight = new global::Gamma.GtkWidgets.ySpinButton(0D, 999D, 1D);
			this.spinWeight.CanFocus = true;
			this.spinWeight.Name = "spinWeight";
			this.spinWeight.Adjustment.PageIncrement = 10D;
			this.spinWeight.ClimbRate = 1D;
			this.spinWeight.Digits = ((uint)(3));
			this.spinWeight.Numeric = true;
			this.spinWeight.Value = 3D;
			this.spinWeight.ValueAsDecimal = 0m;
			this.spinWeight.ValueAsInt = 0;
			this.hbox3.Add(this.spinWeight);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.spinWeight]));
			w20.Position = 0;
			// Container child hbox3.Gtk.Box+BoxChild
			this.volumeLabel = new global::Gtk.Label();
			this.volumeLabel.Name = "volumeLabel";
			this.volumeLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Объём (м<sup>3</sup>):");
			this.volumeLabel.UseMarkup = true;
			this.hbox3.Add(this.volumeLabel);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.volumeLabel]));
			w21.Position = 1;
			w21.Expand = false;
			w21.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.spinVolume = new global::Gamma.GtkWidgets.ySpinButton(0D, 999D, 1D);
			this.spinVolume.CanFocus = true;
			this.spinVolume.Name = "spinVolume";
			this.spinVolume.Adjustment.PageIncrement = 10D;
			this.spinVolume.ClimbRate = 1D;
			this.spinVolume.Digits = ((uint)(3));
			this.spinVolume.Numeric = true;
			this.spinVolume.Value = 3D;
			this.spinVolume.ValueAsDecimal = 0m;
			this.spinVolume.ValueAsInt = 0;
			this.hbox3.Add(this.spinVolume);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.spinVolume]));
			w22.Position = 2;
			this.datatable1.Add(this.hbox3);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.datatable1[this.hbox3]));
			w23.TopAttach = ((uint)(5));
			w23.BottomAttach = ((uint)(6));
			w23.LeftAttach = ((uint)(1));
			w23.RightAttach = ((uint)(2));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.hbox8 = new global::Gtk.HBox();
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.yspinSumOfDamage = new global::Gamma.GtkWidgets.ySpinButton(0D, 100000D, 1D);
			this.yspinSumOfDamage.CanFocus = true;
			this.yspinSumOfDamage.Name = "yspinSumOfDamage";
			this.yspinSumOfDamage.Adjustment.PageIncrement = 10D;
			this.yspinSumOfDamage.ClimbRate = 1D;
			this.yspinSumOfDamage.Digits = ((uint)(2));
			this.yspinSumOfDamage.Numeric = true;
			this.yspinSumOfDamage.ValueAsDecimal = 0m;
			this.yspinSumOfDamage.ValueAsInt = 0;
			this.hbox8.Add(this.yspinSumOfDamage);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.yspinSumOfDamage]));
			w24.Position = 0;
			// Container child hbox8.Gtk.Box+BoxChild
			this.currencylabel2 = new global::QSProjectsLib.CurrencyLabel();
			this.currencylabel2.Name = "currencylabel2";
			this.currencylabel2.LabelProp = global::Mono.Unix.Catalog.GetString("currencylabel2");
			this.hbox8.Add(this.currencylabel2);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.currencylabel2]));
			w25.Position = 1;
			w25.Expand = false;
			w25.Fill = false;
			this.datatable1.Add(this.hbox8);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.datatable1[this.hbox8]));
			w26.TopAttach = ((uint)(6));
			w26.BottomAttach = ((uint)(7));
			w26.LeftAttach = ((uint)(1));
			w26.RightAttach = ((uint)(2));
			w26.XOptions = ((global::Gtk.AttachOptions)(4));
			w26.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.Xalign = 1F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Колонка маршрутного листа:");
			this.datatable1.Add(this.label3);
			global::Gtk.Table.TableChild w27 = ((global::Gtk.Table.TableChild)(this.datatable1[this.label3]));
			w27.TopAttach = ((uint)(7));
			w27.BottomAttach = ((uint)(8));
			w27.XOptions = ((global::Gtk.AttachOptions)(4));
			w27.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.Xalign = 1F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Склад отгрузки:");
			this.datatable1.Add(this.label4);
			global::Gtk.Table.TableChild w28 = ((global::Gtk.Table.TableChild)(this.datatable1[this.label4]));
			w28.TopAttach = ((uint)(8));
			w28.BottomAttach = ((uint)(9));
			w28.XOptions = ((global::Gtk.AttachOptions)(4));
			w28.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.Xalign = 1F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Код 1C:");
			this.datatable1.Add(this.label5);
			global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.datatable1[this.label5]));
			w29.TopAttach = ((uint)(10));
			w29.BottomAttach = ((uint)(11));
			w29.XOptions = ((global::Gtk.AttachOptions)(4));
			w29.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.label7 = new global::Gtk.Label();
			this.label7.Name = "label7";
			this.label7.Xalign = 1F;
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("Сумма штрафа:");
			this.datatable1.Add(this.label7);
			global::Gtk.Table.TableChild w30 = ((global::Gtk.Table.TableChild)(this.datatable1[this.label7]));
			w30.TopAttach = ((uint)(6));
			w30.BottomAttach = ((uint)(7));
			w30.XOptions = ((global::Gtk.AttachOptions)(4));
			w30.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.label8 = new global::Gtk.Label();
			this.label8.Name = "label8";
			this.label8.Xalign = 1F;
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString("Официальное название:");
			this.datatable1.Add(this.label8);
			global::Gtk.Table.TableChild w31 = ((global::Gtk.Table.TableChild)(this.datatable1[this.label8]));
			w31.TopAttach = ((uint)(1));
			w31.BottomAttach = ((uint)(2));
			w31.XOptions = ((global::Gtk.AttachOptions)(4));
			w31.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.labelName = new global::Gtk.Label();
			this.labelName.Name = "labelName";
			this.labelName.Xalign = 1F;
			this.labelName.LabelProp = global::Mono.Unix.Catalog.GetString("Наименование:");
			this.datatable1.Add(this.labelName);
			global::Gtk.Table.TableChild w32 = ((global::Gtk.Table.TableChild)(this.datatable1[this.labelName]));
			w32.XOptions = ((global::Gtk.AttachOptions)(4));
			w32.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.labelNoDeliver = new global::Gtk.Label();
			this.labelNoDeliver.Name = "labelNoDeliver";
			this.labelNoDeliver.Xalign = 1F;
			this.labelNoDeliver.LabelProp = global::Mono.Unix.Catalog.GetString("Не требует доставки:");
			this.datatable1.Add(this.labelNoDeliver);
			global::Gtk.Table.TableChild w33 = ((global::Gtk.Table.TableChild)(this.datatable1[this.labelNoDeliver]));
			w33.TopAttach = ((uint)(13));
			w33.BottomAttach = ((uint)(14));
			w33.XOptions = ((global::Gtk.AttachOptions)(4));
			w33.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.labelReserve = new global::Gtk.Label();
			this.labelReserve.Name = "labelReserve";
			this.labelReserve.Xalign = 1F;
			this.labelReserve.LabelProp = global::Mono.Unix.Catalog.GetString("Не резервировать:");
			this.datatable1.Add(this.labelReserve);
			global::Gtk.Table.TableChild w34 = ((global::Gtk.Table.TableChild)(this.datatable1[this.labelReserve]));
			w34.TopAttach = ((uint)(11));
			w34.BottomAttach = ((uint)(12));
			w34.XOptions = ((global::Gtk.AttachOptions)(4));
			w34.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.labelReserve1 = new global::Gtk.Label();
			this.labelReserve1.Name = "labelReserve1";
			this.labelReserve1.Xalign = 1F;
			this.labelReserve1.LabelProp = global::Mono.Unix.Catalog.GetString("Скрыть из МЛ:");
			this.datatable1.Add(this.labelReserve1);
			global::Gtk.Table.TableChild w35 = ((global::Gtk.Table.TableChild)(this.datatable1[this.labelReserve1]));
			w35.TopAttach = ((uint)(12));
			w35.BottomAttach = ((uint)(13));
			w35.XOptions = ((global::Gtk.AttachOptions)(4));
			w35.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.labelType = new global::Gtk.Label();
			this.labelType.Name = "labelType";
			this.labelType.Xalign = 1F;
			this.labelType.LabelProp = global::Mono.Unix.Catalog.GetString("Тип:");
			this.datatable1.Add(this.labelType);
			global::Gtk.Table.TableChild w36 = ((global::Gtk.Table.TableChild)(this.datatable1[this.labelType]));
			w36.TopAttach = ((uint)(3));
			w36.BottomAttach = ((uint)(4));
			w36.XOptions = ((global::Gtk.AttachOptions)(4));
			w36.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.labelUnit = new global::Gtk.Label();
			this.labelUnit.Name = "labelUnit";
			this.labelUnit.Xalign = 1F;
			this.labelUnit.LabelProp = global::Mono.Unix.Catalog.GetString("Единица измерения:");
			this.datatable1.Add(this.labelUnit);
			global::Gtk.Table.TableChild w37 = ((global::Gtk.Table.TableChild)(this.datatable1[this.labelUnit]));
			w37.TopAttach = ((uint)(4));
			w37.BottomAttach = ((uint)(5));
			w37.XOptions = ((global::Gtk.AttachOptions)(4));
			w37.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.labelVAT = new global::Gtk.Label();
			this.labelVAT.Name = "labelVAT";
			this.labelVAT.Xalign = 1F;
			this.labelVAT.LabelProp = global::Mono.Unix.Catalog.GetString("НДС:");
			this.datatable1.Add(this.labelVAT);
			global::Gtk.Table.TableChild w38 = ((global::Gtk.Table.TableChild)(this.datatable1[this.labelVAT]));
			w38.TopAttach = ((uint)(9));
			w38.BottomAttach = ((uint)(10));
			w38.XOptions = ((global::Gtk.AttachOptions)(4));
			w38.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.labelWeight = new global::Gtk.Label();
			this.labelWeight.Name = "labelWeight";
			this.labelWeight.Xalign = 1F;
			this.labelWeight.LabelProp = global::Mono.Unix.Catalog.GetString("Вес (кг):");
			this.datatable1.Add(this.labelWeight);
			global::Gtk.Table.TableChild w39 = ((global::Gtk.Table.TableChild)(this.datatable1[this.labelWeight]));
			w39.TopAttach = ((uint)(5));
			w39.BottomAttach = ((uint)(6));
			w39.XOptions = ((global::Gtk.AttachOptions)(4));
			w39.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.referenceRouteColumn = new global::Gamma.Widgets.yEntryReference();
			this.referenceRouteColumn.Events = ((global::Gdk.EventMask)(256));
			this.referenceRouteColumn.Name = "referenceRouteColumn";
			this.datatable1.Add(this.referenceRouteColumn);
			global::Gtk.Table.TableChild w40 = ((global::Gtk.Table.TableChild)(this.datatable1[this.referenceRouteColumn]));
			w40.TopAttach = ((uint)(7));
			w40.BottomAttach = ((uint)(8));
			w40.LeftAttach = ((uint)(1));
			w40.RightAttach = ((uint)(2));
			w40.XOptions = ((global::Gtk.AttachOptions)(4));
			w40.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.referenceUnit = new global::Gamma.Widgets.yEntryReference();
			this.referenceUnit.Events = ((global::Gdk.EventMask)(256));
			this.referenceUnit.Name = "referenceUnit";
			this.datatable1.Add(this.referenceUnit);
			global::Gtk.Table.TableChild w41 = ((global::Gtk.Table.TableChild)(this.datatable1[this.referenceUnit]));
			w41.TopAttach = ((uint)(4));
			w41.BottomAttach = ((uint)(5));
			w41.LeftAttach = ((uint)(1));
			w41.RightAttach = ((uint)(2));
			w41.XOptions = ((global::Gtk.AttachOptions)(4));
			w41.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.referenceWarehouse = new global::Gamma.Widgets.yEntryReference();
			this.referenceWarehouse.Events = ((global::Gdk.EventMask)(256));
			this.referenceWarehouse.Name = "referenceWarehouse";
			this.datatable1.Add(this.referenceWarehouse);
			global::Gtk.Table.TableChild w42 = ((global::Gtk.Table.TableChild)(this.datatable1[this.referenceWarehouse]));
			w42.TopAttach = ((uint)(8));
			w42.BottomAttach = ((uint)(9));
			w42.LeftAttach = ((uint)(1));
			w42.RightAttach = ((uint)(2));
			w42.XOptions = ((global::Gtk.AttachOptions)(4));
			w42.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.yentryOfficialName = new global::Gamma.GtkWidgets.yEntry();
			this.yentryOfficialName.CanFocus = true;
			this.yentryOfficialName.Name = "yentryOfficialName";
			this.yentryOfficialName.IsEditable = true;
			this.yentryOfficialName.InvisibleChar = '●';
			this.datatable1.Add(this.yentryOfficialName);
			global::Gtk.Table.TableChild w43 = ((global::Gtk.Table.TableChild)(this.datatable1[this.yentryOfficialName]));
			w43.TopAttach = ((uint)(1));
			w43.BottomAttach = ((uint)(2));
			w43.LeftAttach = ((uint)(1));
			w43.RightAttach = ((uint)(2));
			w43.XOptions = ((global::Gtk.AttachOptions)(4));
			w43.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.yentryShortName = new global::Gamma.GtkWidgets.yEntry();
			this.yentryShortName.CanFocus = true;
			this.yentryShortName.Name = "yentryShortName";
			this.yentryShortName.IsEditable = true;
			this.yentryShortName.InvisibleChar = '●';
			this.datatable1.Add(this.yentryShortName);
			global::Gtk.Table.TableChild w44 = ((global::Gtk.Table.TableChild)(this.datatable1[this.yentryShortName]));
			w44.TopAttach = ((uint)(2));
			w44.BottomAttach = ((uint)(3));
			w44.LeftAttach = ((uint)(1));
			w44.RightAttach = ((uint)(2));
			w44.XOptions = ((global::Gtk.AttachOptions)(4));
			w44.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.ylabel1 = new global::Gamma.GtkWidgets.yLabel();
			this.ylabel1.Name = "ylabel1";
			this.ylabel1.Xalign = 1F;
			this.ylabel1.LabelProp = global::Mono.Unix.Catalog.GetString("Сокращенное название:");
			this.datatable1.Add(this.ylabel1);
			global::Gtk.Table.TableChild w45 = ((global::Gtk.Table.TableChild)(this.datatable1[this.ylabel1]));
			w45.TopAttach = ((uint)(2));
			w45.BottomAttach = ((uint)(3));
			w45.XOptions = ((global::Gtk.AttachOptions)(4));
			w45.YOptions = ((global::Gtk.AttachOptions)(4));
			w12.Add(this.datatable1);
			this.GtkScrolledWindow.Add(w12);
			this.notebook1.Add(this.GtkScrolledWindow);
			// Notebook tab
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Информация");
			this.notebook1.SetTabLabel(this.GtkScrolledWindow, this.label1);
			this.label1.ShowAll();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.table1 = new global::Gtk.Table(((uint)(6)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.checkSerial = new global::Gamma.GtkWidgets.yCheckButton();
			this.checkSerial.CanFocus = true;
			this.checkSerial.Name = "checkSerial";
			this.checkSerial.Label = "";
			this.checkSerial.DrawIndicator = true;
			this.checkSerial.UseUnderline = true;
			this.table1.Add(this.checkSerial);
			global::Gtk.Table.TableChild w49 = ((global::Gtk.Table.TableChild)(this.table1[this.checkSerial]));
			w49.TopAttach = ((uint)(4));
			w49.BottomAttach = ((uint)(5));
			w49.LeftAttach = ((uint)(1));
			w49.RightAttach = ((uint)(2));
			w49.XOptions = ((global::Gtk.AttachOptions)(4));
			w49.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryModel = new global::Gamma.GtkWidgets.yEntry();
			this.entryModel.CanFocus = true;
			this.entryModel.Name = "entryModel";
			this.entryModel.IsEditable = true;
			this.entryModel.InvisibleChar = '●';
			this.table1.Add(this.entryModel);
			global::Gtk.Table.TableChild w50 = ((global::Gtk.Table.TableChild)(this.table1[this.entryModel]));
			w50.TopAttach = ((uint)(1));
			w50.BottomAttach = ((uint)(2));
			w50.LeftAttach = ((uint)(1));
			w50.RightAttach = ((uint)(2));
			w50.XOptions = ((global::Gtk.AttachOptions)(4));
			w50.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelClass = new global::Gtk.Label();
			this.labelClass.Name = "labelClass";
			this.labelClass.Xalign = 1F;
			this.labelClass.LabelProp = global::Mono.Unix.Catalog.GetString("Класс оборудования:");
			this.table1.Add(this.labelClass);
			global::Gtk.Table.TableChild w51 = ((global::Gtk.Table.TableChild)(this.table1[this.labelClass]));
			w51.XOptions = ((global::Gtk.AttachOptions)(4));
			w51.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelColor = new global::Gtk.Label();
			this.labelColor.Name = "labelColor";
			this.labelColor.Xalign = 1F;
			this.labelColor.LabelProp = global::Mono.Unix.Catalog.GetString("Цвет:");
			this.table1.Add(this.labelColor);
			global::Gtk.Table.TableChild w52 = ((global::Gtk.Table.TableChild)(this.table1[this.labelColor]));
			w52.TopAttach = ((uint)(3));
			w52.BottomAttach = ((uint)(4));
			w52.XOptions = ((global::Gtk.AttachOptions)(4));
			w52.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelManufacturer = new global::Gtk.Label();
			this.labelManufacturer.Name = "labelManufacturer";
			this.labelManufacturer.Xalign = 1F;
			this.labelManufacturer.LabelProp = global::Mono.Unix.Catalog.GetString("Производитель:");
			this.table1.Add(this.labelManufacturer);
			global::Gtk.Table.TableChild w53 = ((global::Gtk.Table.TableChild)(this.table1[this.labelManufacturer]));
			w53.TopAttach = ((uint)(2));
			w53.BottomAttach = ((uint)(3));
			w53.XOptions = ((global::Gtk.AttachOptions)(4));
			w53.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelModel = new global::Gtk.Label();
			this.labelModel.Name = "labelModel";
			this.labelModel.Xalign = 1F;
			this.labelModel.LabelProp = global::Mono.Unix.Catalog.GetString("Модель:");
			this.table1.Add(this.labelModel);
			global::Gtk.Table.TableChild w54 = ((global::Gtk.Table.TableChild)(this.table1[this.labelModel]));
			w54.TopAttach = ((uint)(1));
			w54.BottomAttach = ((uint)(2));
			w54.XOptions = ((global::Gtk.AttachOptions)(4));
			w54.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelRentPriority = new global::Gtk.Label();
			this.labelRentPriority.Name = "labelRentPriority";
			this.labelRentPriority.Xalign = 1F;
			this.labelRentPriority.LabelProp = global::Mono.Unix.Catalog.GetString("Приоритет для аренды:");
			this.table1.Add(this.labelRentPriority);
			global::Gtk.Table.TableChild w55 = ((global::Gtk.Table.TableChild)(this.table1[this.labelRentPriority]));
			w55.TopAttach = ((uint)(5));
			w55.BottomAttach = ((uint)(6));
			w55.XOptions = ((global::Gtk.AttachOptions)(4));
			w55.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelSerial = new global::Gtk.Label();
			this.labelSerial.Name = "labelSerial";
			this.labelSerial.Xalign = 1F;
			this.labelSerial.LabelProp = global::Mono.Unix.Catalog.GetString("Посерийный учет:");
			this.table1.Add(this.labelSerial);
			global::Gtk.Table.TableChild w56 = ((global::Gtk.Table.TableChild)(this.table1[this.labelSerial]));
			w56.TopAttach = ((uint)(4));
			w56.BottomAttach = ((uint)(5));
			w56.XOptions = ((global::Gtk.AttachOptions)(4));
			w56.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.referenceColor = new global::Gamma.Widgets.yEntryReference();
			this.referenceColor.Events = ((global::Gdk.EventMask)(256));
			this.referenceColor.Name = "referenceColor";
			this.table1.Add(this.referenceColor);
			global::Gtk.Table.TableChild w57 = ((global::Gtk.Table.TableChild)(this.table1[this.referenceColor]));
			w57.TopAttach = ((uint)(3));
			w57.BottomAttach = ((uint)(4));
			w57.LeftAttach = ((uint)(1));
			w57.RightAttach = ((uint)(2));
			w57.XOptions = ((global::Gtk.AttachOptions)(4));
			w57.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.referenceManufacturer = new global::Gamma.Widgets.yEntryReference();
			this.referenceManufacturer.Events = ((global::Gdk.EventMask)(256));
			this.referenceManufacturer.Name = "referenceManufacturer";
			this.table1.Add(this.referenceManufacturer);
			global::Gtk.Table.TableChild w58 = ((global::Gtk.Table.TableChild)(this.table1[this.referenceManufacturer]));
			w58.TopAttach = ((uint)(2));
			w58.BottomAttach = ((uint)(3));
			w58.LeftAttach = ((uint)(1));
			w58.RightAttach = ((uint)(2));
			w58.XOptions = ((global::Gtk.AttachOptions)(4));
			w58.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.ycheckRentPriority = new global::Gamma.GtkWidgets.yCheckButton();
			this.ycheckRentPriority.CanFocus = true;
			this.ycheckRentPriority.Name = "ycheckRentPriority";
			this.ycheckRentPriority.Label = "";
			this.ycheckRentPriority.DrawIndicator = true;
			this.ycheckRentPriority.UseUnderline = true;
			this.table1.Add(this.ycheckRentPriority);
			global::Gtk.Table.TableChild w59 = ((global::Gtk.Table.TableChild)(this.table1[this.ycheckRentPriority]));
			w59.TopAttach = ((uint)(5));
			w59.BottomAttach = ((uint)(6));
			w59.LeftAttach = ((uint)(1));
			w59.RightAttach = ((uint)(2));
			w59.XOptions = ((global::Gtk.AttachOptions)(4));
			w59.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.yentryrefEqupmentType = new global::Gamma.Widgets.yEntryReference();
			this.yentryrefEqupmentType.Events = ((global::Gdk.EventMask)(256));
			this.yentryrefEqupmentType.Name = "yentryrefEqupmentType";
			this.table1.Add(this.yentryrefEqupmentType);
			global::Gtk.Table.TableChild w60 = ((global::Gtk.Table.TableChild)(this.table1[this.yentryrefEqupmentType]));
			w60.LeftAttach = ((uint)(1));
			w60.RightAttach = ((uint)(2));
			w60.XOptions = ((global::Gtk.AttachOptions)(4));
			w60.YOptions = ((global::Gtk.AttachOptions)(4));
			this.notebook1.Add(this.table1);
			global::Gtk.Notebook.NotebookChild w61 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1[this.table1]));
			w61.Position = 1;
			// Notebook tab
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Оборудование");
			this.notebook1.SetTabLabel(this.table1, this.label2);
			this.label2.ShowAll();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.datatable2 = new global::Gtk.Table(((uint)(1)), ((uint)(2)), false);
			this.datatable2.Name = "datatable2";
			this.datatable2.RowSpacing = ((uint)(6));
			this.datatable2.ColumnSpacing = ((uint)(6));
			// Container child datatable2.Gtk.Table+TableChild
			this.pricesView = new global::Vodovoz.PricesView();
			this.pricesView.Events = ((global::Gdk.EventMask)(256));
			this.pricesView.Name = "pricesView";
			this.datatable2.Add(this.pricesView);
			global::Gtk.Table.TableChild w62 = ((global::Gtk.Table.TableChild)(this.datatable2[this.pricesView]));
			w62.LeftAttach = ((uint)(1));
			w62.RightAttach = ((uint)(2));
			this.notebook1.Add(this.datatable2);
			global::Gtk.Notebook.NotebookChild w63 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1[this.datatable2]));
			w63.Position = 2;
			// Notebook tab
			this.label6 = new global::Gtk.Label();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("Цены");
			this.notebook1.SetTabLabel(this.datatable2, this.label6);
			this.label6.ShowAll();
			this.vbox1.Add(this.notebook1);
			global::Gtk.Box.BoxChild w64 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.notebook1]));
			w64.Position = 1;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
			this.radioInfo.Toggled += new global::System.EventHandler(this.OnRadioInfoToggled);
			this.radioEuqpment.Toggled += new global::System.EventHandler(this.OnRadioEuqpmentToggled);
			this.radioPrice.Toggled += new global::System.EventHandler(this.OnRadioPriceToggled);
			this.enumType.Changed += new global::System.EventHandler(this.OnEnumTypeChanged);
		}
	}
}
