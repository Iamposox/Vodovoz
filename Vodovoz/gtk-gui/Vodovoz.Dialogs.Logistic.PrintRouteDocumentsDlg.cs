﻿
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz.Dialogs.Logistic
{
	public partial class PrintRouteDocumentsDlg
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Label label1;

		private global::QS.Widgets.GtkUI.DatePicker ydatePrint;

		private global::Vodovoz.ViewWidgets.GeographicGroupsToStringWidget geograficGroup;

		private global::Gtk.Button buttonPrint;

		private global::Gtk.ProgressBar progressPrint;

		private global::Gtk.HBox hbox4;

		private global::Gtk.VBox vbox2;

		private global::Gtk.CheckButton checkSelectAll;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gamma.GtkWidgets.yTreeView ytreeRoutes;

		private global::Gtk.ScrolledWindow gtkScrollWndWarnings;

		private global::Gamma.GtkWidgets.yTreeView yTreeViewWarnings;

		private global::Gtk.VBox vbox3;

		private global::Gtk.Label label2;

		private global::Gtk.CheckButton checkRoute;

		private global::Gtk.CheckButton checkRouteMap;

		private global::Gtk.CheckButton chkLoadDocument;

		private global::Gtk.CheckButton chkDocumentsOfOrders;

		private global::Gtk.ScrolledWindow gtkScrlWnd;

		private global::Gamma.GtkWidgets.yTreeView yTreeOrderDocumentTypes;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.Dialogs.Logistic.PrintRouteDocumentsDlg
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.Dialogs.Logistic.PrintRouteDocumentsDlg";
			// Container child Vodovoz.Dialogs.Logistic.PrintRouteDocumentsDlg.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("На дату:");
			this.hbox2.Add(this.label1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.label1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.ydatePrint = new global::QS.Widgets.GtkUI.DatePicker();
			this.ydatePrint.Events = ((global::Gdk.EventMask)(256));
			this.ydatePrint.Name = "ydatePrint";
			this.ydatePrint.WithTime = false;
			this.ydatePrint.Date = new global::System.DateTime(0);
			this.ydatePrint.IsEditable = true;
			this.ydatePrint.AutoSeparation = true;
			this.hbox2.Add(this.ydatePrint);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.ydatePrint]));
			w2.Position = 1;
			w2.Expand = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.geograficGroup = new global::Vodovoz.ViewWidgets.GeographicGroupsToStringWidget();
			this.geograficGroup.Events = ((global::Gdk.EventMask)(256));
			this.geograficGroup.Name = "geograficGroup";
			this.hbox2.Add(this.geograficGroup);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.geograficGroup]));
			w3.Position = 2;
			w3.Expand = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.buttonPrint = new global::Gtk.Button();
			this.buttonPrint.CanFocus = true;
			this.buttonPrint.Name = "buttonPrint";
			this.buttonPrint.UseUnderline = true;
			this.buttonPrint.Label = global::Mono.Unix.Catalog.GetString("Печать всех");
			global::Gtk.Image w4 = new global::Gtk.Image();
			w4.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-print", global::Gtk.IconSize.Menu);
			this.buttonPrint.Image = w4;
			this.hbox2.Add(this.buttonPrint);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.buttonPrint]));
			w5.Position = 3;
			w5.Expand = false;
			w5.Fill = false;
			this.vbox1.Add(this.hbox2);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox2]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.progressPrint = new global::Gtk.ProgressBar();
			this.progressPrint.Name = "progressPrint";
			this.vbox1.Add(this.progressPrint);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.progressPrint]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.checkSelectAll = new global::Gtk.CheckButton();
			this.checkSelectAll.CanFocus = true;
			this.checkSelectAll.Name = "checkSelectAll";
			this.checkSelectAll.Label = global::Mono.Unix.Catalog.GetString("Выбрать все");
			this.checkSelectAll.DrawIndicator = true;
			this.checkSelectAll.UseUnderline = true;
			this.vbox2.Add(this.checkSelectAll);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.checkSelectAll]));
			w8.Position = 0;
			w8.Expand = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.ytreeRoutes = new global::Gamma.GtkWidgets.yTreeView();
			this.ytreeRoutes.CanFocus = true;
			this.ytreeRoutes.Name = "ytreeRoutes";
			this.GtkScrolledWindow.Add(this.ytreeRoutes);
			this.vbox2.Add(this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.GtkScrolledWindow]));
			w10.Position = 1;
			// Container child vbox2.Gtk.Box+BoxChild
			this.gtkScrollWndWarnings = new global::Gtk.ScrolledWindow();
			this.gtkScrollWndWarnings.Name = "gtkScrollWndWarnings";
			this.gtkScrollWndWarnings.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child gtkScrollWndWarnings.Gtk.Container+ContainerChild
			this.yTreeViewWarnings = new global::Gamma.GtkWidgets.yTreeView();
			this.yTreeViewWarnings.CanFocus = true;
			this.yTreeViewWarnings.Name = "yTreeViewWarnings";
			this.gtkScrollWndWarnings.Add(this.yTreeViewWarnings);
			this.vbox2.Add(this.gtkScrollWndWarnings);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.gtkScrollWndWarnings]));
			w12.Position = 2;
			w12.Expand = false;
			this.hbox4.Add(this.vbox2);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.vbox2]));
			w13.Position = 0;
			// Container child hbox4.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Печатаем документы");
			this.vbox3.Add(this.label2);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.label2]));
			w14.Position = 0;
			w14.Expand = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.checkRoute = new global::Gtk.CheckButton();
			this.checkRoute.CanFocus = true;
			this.checkRoute.Name = "checkRoute";
			this.checkRoute.Label = global::Mono.Unix.Catalog.GetString("Маршрутный лист");
			this.checkRoute.Active = true;
			this.checkRoute.DrawIndicator = true;
			this.checkRoute.UseUnderline = true;
			this.vbox3.Add(this.checkRoute);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.checkRoute]));
			w15.Position = 1;
			w15.Expand = false;
			w15.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.checkRouteMap = new global::Gtk.CheckButton();
			this.checkRouteMap.CanFocus = true;
			this.checkRouteMap.Name = "checkRouteMap";
			this.checkRouteMap.Label = global::Mono.Unix.Catalog.GetString("Карта маршрута");
			this.checkRouteMap.Active = true;
			this.checkRouteMap.DrawIndicator = true;
			this.checkRouteMap.UseUnderline = true;
			this.vbox3.Add(this.checkRouteMap);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.checkRouteMap]));
			w16.Position = 2;
			w16.Expand = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.chkLoadDocument = new global::Gtk.CheckButton();
			this.chkLoadDocument.CanFocus = true;
			this.chkLoadDocument.Name = "chkLoadDocument";
			this.chkLoadDocument.Label = global::Mono.Unix.Catalog.GetString("Документ погрузки");
			this.chkLoadDocument.DrawIndicator = true;
			this.chkLoadDocument.UseUnderline = true;
			this.vbox3.Add(this.chkLoadDocument);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.chkLoadDocument]));
			w17.Position = 3;
			w17.Expand = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.chkDocumentsOfOrders = new global::Gtk.CheckButton();
			this.chkDocumentsOfOrders.CanFocus = true;
			this.chkDocumentsOfOrders.Name = "chkDocumentsOfOrders";
			this.chkDocumentsOfOrders.Label = global::Mono.Unix.Catalog.GetString("Документы заказов");
			this.chkDocumentsOfOrders.Active = true;
			this.chkDocumentsOfOrders.DrawIndicator = true;
			this.chkDocumentsOfOrders.UseUnderline = true;
			this.vbox3.Add(this.chkDocumentsOfOrders);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.chkDocumentsOfOrders]));
			w18.Position = 4;
			w18.Expand = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.gtkScrlWnd = new global::Gtk.ScrolledWindow();
			this.gtkScrlWnd.Name = "gtkScrlWnd";
			this.gtkScrlWnd.HscrollbarPolicy = ((global::Gtk.PolicyType)(2));
			this.gtkScrlWnd.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child gtkScrlWnd.Gtk.Container+ContainerChild
			this.yTreeOrderDocumentTypes = new global::Gamma.GtkWidgets.yTreeView();
			this.yTreeOrderDocumentTypes.CanFocus = true;
			this.yTreeOrderDocumentTypes.Name = "yTreeOrderDocumentTypes";
			this.gtkScrlWnd.Add(this.yTreeOrderDocumentTypes);
			this.vbox3.Add(this.gtkScrlWnd);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.gtkScrlWnd]));
			w20.Position = 5;
			this.hbox4.Add(this.vbox3);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.vbox3]));
			w21.Position = 1;
			w21.Expand = false;
			this.vbox1.Add(this.hbox4);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox4]));
			w22.Position = 2;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.gtkScrollWndWarnings.Hide();
			this.Hide();
			this.ydatePrint.DateChanged += new global::System.EventHandler(this.OnYdatePrintDateChanged);
			this.buttonPrint.Clicked += new global::System.EventHandler(this.OnButtonPrintClicked);
			this.checkSelectAll.Toggled += new global::System.EventHandler(this.OnCheckSelectAllToggled);
		}
	}
}
