
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz.JournalFilters
{
	public partial class TaskFilter
	{
		private global::Gtk.VBox vboxFilter;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Label label3;

		private global::QSOrmProject.EntryReferenceVM entryreferencevmEmployee;

		private global::Gamma.Widgets.yDatePeriodPicker dateperiodpickerDeadlineFilter;

		private global::Gtk.Label label2;

		private global::Gtk.CheckButton checkbuttonHideCompleted;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Button buttonExpired;

		private global::Gtk.Button buttonToday;

		private global::Gtk.Button buttonTomorrow;

		private global::Gtk.Button buttonThisWeek;

		private global::Gtk.Button buttonNextWeek;

		private global::Gtk.Label label1;

		private global::Gamma.Widgets.yDatePeriodPicker dateperiodpickerCreateDateFilter;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.JournalFilters.TaskFilter
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.JournalFilters.TaskFilter";
			// Container child Vodovoz.JournalFilters.TaskFilter.Gtk.Container+ContainerChild
			this.vboxFilter = new global::Gtk.VBox();
			this.vboxFilter.Name = "vboxFilter";
			this.vboxFilter.Spacing = 6;
			// Container child vboxFilter.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("ФИ оператора :");
			this.hbox4.Add(this.label3);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.label3]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.entryreferencevmEmployee = new global::QSOrmProject.EntryReferenceVM();
			this.entryreferencevmEmployee.Events = ((global::Gdk.EventMask)(256));
			this.entryreferencevmEmployee.Name = "entryreferencevmEmployee";
			this.hbox4.Add(this.entryreferencevmEmployee);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.entryreferencevmEmployee]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.dateperiodpickerDeadlineFilter = new global::Gamma.Widgets.yDatePeriodPicker();
			this.dateperiodpickerDeadlineFilter.Events = ((global::Gdk.EventMask)(256));
			this.dateperiodpickerDeadlineFilter.Name = "dateperiodpickerDeadlineFilter";
			this.dateperiodpickerDeadlineFilter.StartDate = new global::System.DateTime(0);
			this.dateperiodpickerDeadlineFilter.EndDate = new global::System.DateTime(0);
			this.hbox4.Add(this.dateperiodpickerDeadlineFilter);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.dateperiodpickerDeadlineFilter]));
			w3.PackType = ((global::Gtk.PackType)(1));
			w3.Position = 2;
			// Container child hbox4.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Период выполнения задач :");
			this.hbox4.Add(this.label2);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.label2]));
			w4.PackType = ((global::Gtk.PackType)(1));
			w4.Position = 3;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.checkbuttonHideCompleted = new global::Gtk.CheckButton();
			this.checkbuttonHideCompleted.CanFocus = true;
			this.checkbuttonHideCompleted.Name = "checkbuttonHideCompleted";
			this.checkbuttonHideCompleted.Label = global::Mono.Unix.Catalog.GetString("Скрыть выполненые");
			this.checkbuttonHideCompleted.Active = true;
			this.checkbuttonHideCompleted.DrawIndicator = true;
			this.checkbuttonHideCompleted.UseUnderline = true;
			this.hbox4.Add(this.checkbuttonHideCompleted);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.checkbuttonHideCompleted]));
			w5.PackType = ((global::Gtk.PackType)(1));
			w5.Position = 4;
			this.vboxFilter.Add(this.hbox4);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vboxFilter[this.hbox4]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vboxFilter.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.buttonExpired = new global::Gtk.Button();
			this.buttonExpired.CanFocus = true;
			this.buttonExpired.Name = "buttonExpired";
			this.buttonExpired.UseUnderline = true;
			this.buttonExpired.Label = global::Mono.Unix.Catalog.GetString("Просрочено");
			this.hbox2.Add(this.buttonExpired);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.buttonExpired]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.buttonToday = new global::Gtk.Button();
			this.buttonToday.CanFocus = true;
			this.buttonToday.Name = "buttonToday";
			this.buttonToday.UseUnderline = true;
			this.buttonToday.Label = global::Mono.Unix.Catalog.GetString("Сегодня");
			this.hbox2.Add(this.buttonToday);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.buttonToday]));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.buttonTomorrow = new global::Gtk.Button();
			this.buttonTomorrow.CanFocus = true;
			this.buttonTomorrow.Name = "buttonTomorrow";
			this.buttonTomorrow.UseUnderline = true;
			this.buttonTomorrow.Label = global::Mono.Unix.Catalog.GetString("Завтра");
			this.hbox2.Add(this.buttonTomorrow);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.buttonTomorrow]));
			w9.Position = 2;
			w9.Expand = false;
			w9.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.buttonThisWeek = new global::Gtk.Button();
			this.buttonThisWeek.CanFocus = true;
			this.buttonThisWeek.Name = "buttonThisWeek";
			this.buttonThisWeek.UseUnderline = true;
			this.buttonThisWeek.Label = global::Mono.Unix.Catalog.GetString("На этой неделе");
			this.hbox2.Add(this.buttonThisWeek);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.buttonThisWeek]));
			w10.Position = 3;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.buttonNextWeek = new global::Gtk.Button();
			this.buttonNextWeek.CanFocus = true;
			this.buttonNextWeek.Name = "buttonNextWeek";
			this.buttonNextWeek.UseUnderline = true;
			this.buttonNextWeek.Label = global::Mono.Unix.Catalog.GetString("На следующей неделе");
			this.hbox2.Add(this.buttonNextWeek);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.buttonNextWeek]));
			w11.Position = 4;
			w11.Expand = false;
			w11.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Период постановки задач :");
			this.hbox2.Add(this.label1);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.label1]));
			w12.Position = 5;
			w12.Expand = false;
			w12.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.dateperiodpickerCreateDateFilter = new global::Gamma.Widgets.yDatePeriodPicker();
			this.dateperiodpickerCreateDateFilter.Events = ((global::Gdk.EventMask)(256));
			this.dateperiodpickerCreateDateFilter.Name = "dateperiodpickerCreateDateFilter";
			this.dateperiodpickerCreateDateFilter.StartDate = new global::System.DateTime(0);
			this.dateperiodpickerCreateDateFilter.EndDate = new global::System.DateTime(0);
			this.hbox2.Add(this.dateperiodpickerCreateDateFilter);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.dateperiodpickerCreateDateFilter]));
			w13.Position = 6;
			this.vboxFilter.Add(this.hbox2);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vboxFilter[this.hbox2]));
			w14.Position = 1;
			w14.Expand = false;
			w14.Fill = false;
			this.Add(this.vboxFilter);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.vboxFilter.Hide();
			this.Hide();
			this.entryreferencevmEmployee.ChangedByUser += new global::System.EventHandler(this.OnEntryreferencevmEmployeeChangedByUser);
			this.checkbuttonHideCompleted.Toggled += new global::System.EventHandler(this.OnCheckbuttonHideCompletedToggled);
			this.dateperiodpickerDeadlineFilter.PeriodChangedByUser += new global::System.EventHandler(this.OnDateperiodpickerDeadlineFilterPeriodChangedByUser);
			this.buttonExpired.Clicked += new global::System.EventHandler(this.OnButtonExpiredClicked);
			this.buttonToday.Clicked += new global::System.EventHandler(this.OnButtonTodayClicked);
			this.buttonTomorrow.Clicked += new global::System.EventHandler(this.OnButtonTomorrowClicked);
			this.buttonThisWeek.Clicked += new global::System.EventHandler(this.OnButtonThisWeekClicked);
			this.buttonNextWeek.Clicked += new global::System.EventHandler(this.OnButtonNextWeekClicked);
			this.dateperiodpickerCreateDateFilter.PeriodChangedByUser += new global::System.EventHandler(this.OnDateperiodpickerCreateDateStartDateChanged);
		}
	}
}