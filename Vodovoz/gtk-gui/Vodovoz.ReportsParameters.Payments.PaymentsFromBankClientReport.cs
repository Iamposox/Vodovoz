
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz.ReportsParameters.Payments
{
	public partial class PaymentsFromBankClientReport
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Label label1;

		private global::Gamma.Widgets.yEntryReference yentryRefSubdivision;

		private global::Gamma.GtkWidgets.yCheckButton checkAllSubdivisions;

		private global::Gamma.GtkWidgets.yButton btnCreateReport;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.ReportsParameters.Payments.PaymentsFromBankClientReport
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.ReportsParameters.Payments.PaymentsFromBankClientReport";
			// Container child Vodovoz.ReportsParameters.Payments.PaymentsFromBankClientReport.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Подразделение: ");
			this.hbox1.Add(this.label1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.label1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.yentryRefSubdivision = new global::Gamma.Widgets.yEntryReference();
			this.yentryRefSubdivision.Events = ((global::Gdk.EventMask)(256));
			this.yentryRefSubdivision.Name = "yentryRefSubdivision";
			this.hbox1.Add(this.yentryRefSubdivision);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.yentryRefSubdivision]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			this.vbox1.Add(this.hbox1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.checkAllSubdivisions = new global::Gamma.GtkWidgets.yCheckButton();
			this.checkAllSubdivisions.CanFocus = true;
			this.checkAllSubdivisions.Name = "checkAllSubdivisions";
			this.checkAllSubdivisions.Label = global::Mono.Unix.Catalog.GetString("Не ограничивать по подразделению");
			this.checkAllSubdivisions.DrawIndicator = true;
			this.checkAllSubdivisions.UseUnderline = true;
			this.vbox1.Add(this.checkAllSubdivisions);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.checkAllSubdivisions]));
			w4.Position = 2;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.btnCreateReport = new global::Gamma.GtkWidgets.yButton();
			this.btnCreateReport.CanFocus = true;
			this.btnCreateReport.Name = "btnCreateReport";
			this.btnCreateReport.UseUnderline = true;
			this.btnCreateReport.Label = global::Mono.Unix.Catalog.GetString("Сформировать отчет");
			this.vbox1.Add(this.btnCreateReport);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.btnCreateReport]));
			w5.Position = 3;
			w5.Expand = false;
			w5.Fill = false;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}