﻿
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz
{
	public partial class ExportTo1cDialog
	{
		private global::Gtk.HBox hbox1;

		private global::Gtk.Table table1;

		private global::QS.Widgets.GtkUI.DateRangePicker dateperiodpicker1;

		private global::Gtk.ScrolledWindow GtkScrolledWindowErrors;

		private global::Gtk.TextView textviewErrors;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Button buttonExport;

		private global::Gtk.Button buttonExportIPTinkoff;

		private global::Gtk.Label label10;

		private global::Gtk.Label label7;

		private global::Gtk.VBox vbox1;

		private global::Gtk.Table table3;

		private global::Gtk.Label label1;

		private global::Gtk.Label label2;

		private global::Gtk.Label label3;

		private global::Gtk.Label label4;

		private global::Gtk.Label label5;

		private global::Gtk.Label label6;

		private global::Gtk.Label labelExportedSum;

		private global::Gtk.Label labelTotalCounterparty;

		private global::Gtk.Label labelTotalInvoices;

		private global::Gtk.Label labelTotalNomenclature;

		private global::Gtk.Label labelTotalSales;

		private global::Gtk.Label labelTotalSum;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Button buttonSave;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.ExportTo1cDialog
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.ExportTo1cDialog";
			// Container child Vodovoz.ExportTo1cDialog.Gtk.Container+ContainerChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table(((uint)(3)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			this.table1.BorderWidth = ((uint)(27));
			// Container child table1.Gtk.Table+TableChild
			this.dateperiodpicker1 = new global::QS.Widgets.GtkUI.DateRangePicker();
			this.dateperiodpicker1.Events = ((global::Gdk.EventMask)(256));
			this.dateperiodpicker1.Name = "dateperiodpicker1";
			this.dateperiodpicker1.StartDate = new global::System.DateTime(0);
			this.dateperiodpicker1.EndDate = new global::System.DateTime(0);
			this.table1.Add(this.dateperiodpicker1);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1[this.dateperiodpicker1]));
			w1.LeftAttach = ((uint)(1));
			w1.RightAttach = ((uint)(2));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.GtkScrolledWindowErrors = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindowErrors.Name = "GtkScrolledWindowErrors";
			this.GtkScrolledWindowErrors.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindowErrors.Gtk.Container+ContainerChild
			this.textviewErrors = new global::Gtk.TextView();
			this.textviewErrors.CanFocus = true;
			this.textviewErrors.Name = "textviewErrors";
			this.textviewErrors.Editable = false;
			this.GtkScrolledWindowErrors.Add(this.textviewErrors);
			this.table1.Add(this.GtkScrolledWindowErrors);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1[this.GtkScrolledWindowErrors]));
			w3.TopAttach = ((uint)(2));
			w3.BottomAttach = ((uint)(3));
			w3.RightAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.buttonExport = new global::Gtk.Button();
			this.buttonExport.Sensitive = false;
			this.buttonExport.CanFocus = true;
			this.buttonExport.Name = "buttonExport";
			this.buttonExport.UseUnderline = true;
			this.buttonExport.Label = global::Mono.Unix.Catalog.GetString("В бухгалтерию ООО");
			this.hbox4.Add(this.buttonExport);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.buttonExport]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.buttonExportIPTinkoff = new global::Gtk.Button();
			this.buttonExportIPTinkoff.Sensitive = false;
			this.buttonExportIPTinkoff.CanFocus = true;
			this.buttonExportIPTinkoff.Name = "buttonExportIPTinkoff";
			this.buttonExportIPTinkoff.UseUnderline = true;
			this.buttonExportIPTinkoff.Label = global::Mono.Unix.Catalog.GetString("В ИП для оплаты по Тинькофф");
			this.hbox4.Add(this.buttonExportIPTinkoff);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.buttonExportIPTinkoff]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			this.table1.Add(this.hbox4);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1[this.hbox4]));
			w6.TopAttach = ((uint)(1));
			w6.BottomAttach = ((uint)(2));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label10 = new global::Gtk.Label();
			this.label10.Name = "label10";
			this.label10.Xalign = 1F;
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString("Период:");
			this.table1.Add(this.label10);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1[this.label10]));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label7 = new global::Gtk.Label();
			this.label7.Name = "label7";
			this.label7.Xalign = 0F;
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("Сформировать выгрузку:");
			this.table1.Add(this.label7);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1[this.label7]));
			w8.TopAttach = ((uint)(1));
			w8.BottomAttach = ((uint)(2));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			this.hbox1.Add(this.table1);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.table1]));
			w9.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.table3 = new global::Gtk.Table(((uint)(6)), ((uint)(2)), false);
			this.table3.Name = "table3";
			this.table3.RowSpacing = ((uint)(6));
			this.table3.ColumnSpacing = ((uint)(6));
			// Container child table3.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.Xalign = 1F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Заказов на сумму:");
			this.table3.Add(this.label1);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table3[this.label1]));
			w10.TopAttach = ((uint)(2));
			w10.BottomAttach = ((uint)(3));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.Xalign = 1F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Контрагентов выгружено:");
			this.table3.Add(this.label2);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table3[this.label2]));
			w11.TopAttach = ((uint)(4));
			w11.BottomAttach = ((uint)(5));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.Xalign = 1F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Реализаций выгружено:");
			this.table3.Add(this.label3);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table3[this.label3]));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.Xalign = 1F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Выгрузка на сумму:");
			this.table3.Add(this.label4);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table3[this.label4]));
			w13.TopAttach = ((uint)(3));
			w13.BottomAttach = ((uint)(4));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.Xalign = 1F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Номенклатур выгружено:");
			this.table3.Add(this.label5);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table3[this.label5]));
			w14.TopAttach = ((uint)(5));
			w14.BottomAttach = ((uint)(6));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label();
			this.label6.Name = "label6";
			this.label6.Xalign = 1F;
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("Счет-фактур выгружено:");
			this.table3.Add(this.label6);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table3[this.label6]));
			w15.TopAttach = ((uint)(1));
			w15.BottomAttach = ((uint)(2));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.labelExportedSum = new global::Gtk.Label();
			this.labelExportedSum.Name = "labelExportedSum";
			this.labelExportedSum.LabelProp = global::Mono.Unix.Catalog.GetString("0");
			this.table3.Add(this.labelExportedSum);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table3[this.labelExportedSum]));
			w16.TopAttach = ((uint)(3));
			w16.BottomAttach = ((uint)(4));
			w16.LeftAttach = ((uint)(1));
			w16.RightAttach = ((uint)(2));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.labelTotalCounterparty = new global::Gtk.Label();
			this.labelTotalCounterparty.Name = "labelTotalCounterparty";
			this.labelTotalCounterparty.LabelProp = global::Mono.Unix.Catalog.GetString("0");
			this.table3.Add(this.labelTotalCounterparty);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table3[this.labelTotalCounterparty]));
			w17.TopAttach = ((uint)(4));
			w17.BottomAttach = ((uint)(5));
			w17.LeftAttach = ((uint)(1));
			w17.RightAttach = ((uint)(2));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.labelTotalInvoices = new global::Gtk.Label();
			this.labelTotalInvoices.Name = "labelTotalInvoices";
			this.labelTotalInvoices.LabelProp = global::Mono.Unix.Catalog.GetString("0");
			this.table3.Add(this.labelTotalInvoices);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table3[this.labelTotalInvoices]));
			w18.TopAttach = ((uint)(1));
			w18.BottomAttach = ((uint)(2));
			w18.LeftAttach = ((uint)(1));
			w18.RightAttach = ((uint)(2));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.labelTotalNomenclature = new global::Gtk.Label();
			this.labelTotalNomenclature.Name = "labelTotalNomenclature";
			this.labelTotalNomenclature.LabelProp = global::Mono.Unix.Catalog.GetString("0");
			this.table3.Add(this.labelTotalNomenclature);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table3[this.labelTotalNomenclature]));
			w19.TopAttach = ((uint)(5));
			w19.BottomAttach = ((uint)(6));
			w19.LeftAttach = ((uint)(1));
			w19.RightAttach = ((uint)(2));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.labelTotalSales = new global::Gtk.Label();
			this.labelTotalSales.Name = "labelTotalSales";
			this.labelTotalSales.LabelProp = global::Mono.Unix.Catalog.GetString("0");
			this.table3.Add(this.labelTotalSales);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table3[this.labelTotalSales]));
			w20.LeftAttach = ((uint)(1));
			w20.RightAttach = ((uint)(2));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.labelTotalSum = new global::Gtk.Label();
			this.labelTotalSum.Name = "labelTotalSum";
			this.labelTotalSum.LabelProp = global::Mono.Unix.Catalog.GetString("0");
			this.table3.Add(this.labelTotalSum);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table3[this.labelTotalSum]));
			w21.TopAttach = ((uint)(2));
			w21.BottomAttach = ((uint)(3));
			w21.LeftAttach = ((uint)(1));
			w21.RightAttach = ((uint)(2));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox1.Add(this.table3);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.table3]));
			w22.Position = 0;
			w22.Expand = false;
			w22.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.buttonSave = new global::Gtk.Button();
			this.buttonSave.Sensitive = false;
			this.buttonSave.CanFocus = true;
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.UseUnderline = true;
			this.buttonSave.Label = global::Mono.Unix.Catalog.GetString("Сохранить");
			global::Gtk.Image w23 = new global::Gtk.Image();
			w23.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-save", global::Gtk.IconSize.Button);
			this.buttonSave.Image = w23;
			this.hbox3.Add(this.buttonSave);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.buttonSave]));
			w24.Position = 1;
			w24.Expand = false;
			w24.Fill = false;
			this.vbox1.Add(this.hbox3);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox3]));
			w25.Position = 1;
			w25.Expand = false;
			w25.Fill = false;
			this.hbox1.Add(this.vbox1);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbox1]));
			w26.Position = 1;
			this.Add(this.hbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.GtkScrolledWindowErrors.Hide();
			this.Hide();
			this.buttonExport.Clicked += new global::System.EventHandler(this.OnButtonExportClicked);
			this.buttonExportIPTinkoff.Clicked += new global::System.EventHandler(this.OnButtonExportIPTinkoffClicked);
			this.dateperiodpicker1.PeriodChanged += new global::System.EventHandler(this.OnDateperiodpicker1PeriodChanged);
			this.buttonSave.Clicked += new global::System.EventHandler(this.OnButtonSaveClicked);
		}
	}
}
