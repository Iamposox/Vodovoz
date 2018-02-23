
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz.Panel
{
	public partial class AdditionalAgreementPanelView
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.Label label4;

		private global::Gtk.Table table1;

		private global::Gtk.Label label2;

		private global::Gtk.Label label3;

		private global::Gtk.Label label5;

		private global::Vodovoz.WrapLabel labelBottlesPerMonth;

		private global::Vodovoz.WrapLabel labelEquipmentCount;

		private global::Vodovoz.WrapLabel labelNextService;

		private global::Gtk.VBox vboxRent;

		private global::Gtk.Label label1;

		private global::Vodovoz.WrapLabel labelRent;

		private global::Gtk.VBox vboxFixedPrices;

		private global::Gtk.Label label6;

		private global::Gamma.GtkWidgets.yTreeView ytreeviewFixedPrices;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.Panel.AdditionalAgreementPanelView
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.Panel.AdditionalAgreementPanelView";
			// Container child Vodovoz.Panel.AdditionalAgreementPanelView.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("<b><u>Допсоглашения</u></b>");
			this.label4.UseMarkup = true;
			this.vbox1.Add(this.label4);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label4]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table(((uint)(3)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label();
			this.label2.WidthRequest = 100;
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Бутылей в этом месяце:");
			this.label2.Wrap = true;
			this.table1.Add(this.label2);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1[this.label2]));
			w2.TopAttach = ((uint)(2));
			w2.BottomAttach = ((uint)(3));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.Xalign = 0F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Кулеров:");
			this.table1.Add(this.label3);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1[this.label3]));
			w3.TopAttach = ((uint)(1));
			w3.BottomAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label();
			this.label5.WidthRequest = 100;
			this.label5.Name = "label5";
			this.label5.Xalign = 0F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Ближайшая сан. обработка:");
			this.label5.Wrap = true;
			this.table1.Add(this.label5);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1[this.label5]));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelBottlesPerMonth = new global::Vodovoz.WrapLabel();
			this.labelBottlesPerMonth.Name = "labelBottlesPerMonth";
			this.labelBottlesPerMonth.LabelProp = global::Mono.Unix.Catalog.GetString("wraplabel3");
			this.labelBottlesPerMonth.Wrap = true;
			this.labelBottlesPerMonth.Selectable = true;
			this.table1.Add(this.labelBottlesPerMonth);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1[this.labelBottlesPerMonth]));
			w5.TopAttach = ((uint)(2));
			w5.BottomAttach = ((uint)(3));
			w5.LeftAttach = ((uint)(1));
			w5.RightAttach = ((uint)(2));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelEquipmentCount = new global::Vodovoz.WrapLabel();
			this.labelEquipmentCount.Name = "labelEquipmentCount";
			this.labelEquipmentCount.LabelProp = global::Mono.Unix.Catalog.GetString("wraplabel1");
			this.labelEquipmentCount.Selectable = true;
			this.table1.Add(this.labelEquipmentCount);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1[this.labelEquipmentCount]));
			w6.TopAttach = ((uint)(1));
			w6.BottomAttach = ((uint)(2));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelNextService = new global::Vodovoz.WrapLabel();
			this.labelNextService.Name = "labelNextService";
			this.labelNextService.LabelProp = global::Mono.Unix.Catalog.GetString("wraplabel1");
			this.labelNextService.Wrap = true;
			this.labelNextService.Selectable = true;
			this.table1.Add(this.labelNextService);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1[this.labelNextService]));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox1.Add(this.table1);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.table1]));
			w8.Position = 2;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.vboxRent = new global::Gtk.VBox();
			this.vboxRent.Name = "vboxRent";
			this.vboxRent.Spacing = 6;
			// Container child vboxRent.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Посуточная аренда:</b>");
			this.label1.UseMarkup = true;
			this.vboxRent.Add(this.label1);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vboxRent[this.label1]));
			w9.Position = 0;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vboxRent.Gtk.Box+BoxChild
			this.labelRent = new global::Vodovoz.WrapLabel();
			this.labelRent.Name = "labelRent";
			this.labelRent.LabelProp = global::Mono.Unix.Catalog.GetString("wraplabel1");
			this.labelRent.Wrap = true;
			this.labelRent.Selectable = true;
			this.vboxRent.Add(this.labelRent);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vboxRent[this.labelRent]));
			w10.Position = 1;
			w10.Expand = false;
			w10.Fill = false;
			this.vbox1.Add(this.vboxRent);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.vboxRent]));
			w11.Position = 5;
			// Container child vbox1.Gtk.Box+BoxChild
			this.vboxFixedPrices = new global::Gtk.VBox();
			this.vboxFixedPrices.Name = "vboxFixedPrices";
			this.vboxFixedPrices.Spacing = 6;
			// Container child vboxFixedPrices.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Фиксированные цены:</b>");
			this.label6.UseMarkup = true;
			this.vboxFixedPrices.Add(this.label6);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vboxFixedPrices[this.label6]));
			w12.Position = 0;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vboxFixedPrices.Gtk.Box+BoxChild
			this.ytreeviewFixedPrices = new global::Gamma.GtkWidgets.yTreeView();
			this.ytreeviewFixedPrices.CanFocus = true;
			this.ytreeviewFixedPrices.Name = "ytreeviewFixedPrices";
			this.vboxFixedPrices.Add(this.ytreeviewFixedPrices);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vboxFixedPrices[this.ytreeviewFixedPrices]));
			w13.Position = 1;
			w13.Expand = false;
			w13.Fill = false;
			this.vbox1.Add(this.vboxFixedPrices);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.vboxFixedPrices]));
			w14.Position = 6;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.label4.Hide();
			this.table1.Hide();
			this.label1.Hide();
			this.labelRent.Hide();
			this.Hide();
			this.ytreeviewFixedPrices.RowActivated += new global::Gtk.RowActivatedHandler(this.OnYtreeviewFixedPricesRowActivated);
		}
	}
}
