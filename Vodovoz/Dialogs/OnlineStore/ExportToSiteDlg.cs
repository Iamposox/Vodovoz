using System;
using System.Collections.Generic;
using Gtk;
using QS.Dialog.GtkUI;
using QS.DomainModel.UoW;
using QSProjectsLib;
using QSSupportLib;
using Vodovoz.Tools.CommerceML;

namespace Vodovoz.Dialogs.OnlineStore
{
	public partial class ExportToSiteDlg : QS.Dialog.Gtk.TdiTabBase
	{
		public ExportToSiteDlg()
		{
			if(!QSMain.User.Permissions["database_maintenance"]) {
				MessageDialogHelper.RunWarningDialog("Доступ запрещён!", "У вас недостаточно прав для доступа к этой вкладке. Обратитесь к своему руководителю.", Gtk.ButtonsType.Ok);
				FailInitialize = true;
				return;
			}

			this.Build();
			TabName = "Обмен с интернет магазином";
			if(MainSupport.BaseParameters.All.ContainsKey(Exchange.OnlineStoreUrlParameterName))
				entrySitePath.Text = MainSupport.BaseParameters.All[Exchange.OnlineStoreUrlParameterName];
			if(MainSupport.BaseParameters.All.ContainsKey(Exchange.OnlineStoreLoginParameterName))
				entryUser.Text = MainSupport.BaseParameters.All[Exchange.OnlineStoreLoginParameterName];
			if(MainSupport.BaseParameters.All.ContainsKey(Exchange.OnlineStorePasswordParameterName))
				entryPassword.Text = MainSupport.BaseParameters.All[Exchange.OnlineStorePasswordParameterName];
		}

		protected void OnButtonRunToFileClicked(object sender, EventArgs e)
		{
			using(var uow = UnitOfWorkFactory.CreateWithoutRoot("Диалог «Обмен с сайтом» - кнопка «Экспортировать в файл»"))
			{
				var fileChooser = new Gtk.FileChooserDialog("Выберите папку для сохранения выгрузки",
					(Window)this.Toplevel,
				                                            Gtk.FileChooserAction.SelectFolder,
					"Отмена", ResponseType.Cancel,
					"Выбрать", ResponseType.Accept
				);

				if(fileChooser.Run() == (int)ResponseType.Cancel)
				{
					fileChooser.Destroy();
					return;
				}

				var directory = fileChooser.Filename;
				fileChooser.Destroy();

				var export = new Exchange(uow);
				export.ProgressUpdated += Export_ProgressUpdated;

				export.RunToDirectory(directory);

				if(UpdateErrors(export.Errors))
					return;

                UpdateResults(export.Results);
                progressbarTotal.Text = "Готово";
				progressbarTotal.Adjustment.Value = progressbarTotal.Adjustment.Upper;
			}
		}

		protected void OnEntrySitePathFocusOutEvent(object o, FocusOutEventArgs args)
		{
			MainSupport.BaseParameters.UpdateParameter(QSMain.ConnectionDB, Exchange.OnlineStoreUrlParameterName, entrySitePath.Text);
		}

		protected void OnEntryUserFocusOutEvent(object o, FocusOutEventArgs args)
		{
			MainSupport.BaseParameters.UpdateParameter(QSMain.ConnectionDB, Exchange.OnlineStoreLoginParameterName, entryUser.Text);
		}

		protected void OnEntryPasswordFocusOutEvent(object o, FocusOutEventArgs args)
		{
			MainSupport.BaseParameters.UpdateParameter(QSMain.ConnectionDB, Exchange.OnlineStorePasswordParameterName, entryPassword.Text);
		}

		protected void OnButtonExportToSiteClicked(object sender, EventArgs e)
		{
			using(var uow = UnitOfWorkFactory.CreateWithoutRoot("Диалог «Обмен с сайтом» - кнопка «Экспортировать каталог на сайт»")) {
				var export = new Exchange(uow);
				export.ProgressUpdated += Export_ProgressUpdated;

				export.RunToSite();

				if(UpdateErrors(export.Errors))
					return;

                UpdateResults(export.Results);
				progressbarTotal.Text = "Готово";
				progressbarTotal.Adjustment.Value = progressbarTotal.Adjustment.Upper;
			}
		}


		void Export_ProgressUpdated(object sender, EventArgs e)
		{
			var export = sender as Exchange;
			progressbarTotal.Text = export.CurrentTaskText + export.CurrentStepText;
			progressbarTotal.Adjustment.Upper = export.TotalTasks;
			progressbarTotal.Adjustment.Value = export.CurrentTask;
            UpdateErrors(export.Errors);
			QSMain.WaitRedraw();
		}

		/// <summary>
		/// Если метод вернул true, это значит что есть ошибки.
		/// </summary>
		private bool UpdateErrors(List<string> errors)
		{
			GtkScrolledWindowErrors.Visible = errors.Count > 0;
			if(errors.Count > 0) {
				TextTagTable textTags = new TextTagTable();
				var tag = new TextTag("Red");
				tag.Foreground = "red";
				textTags.Add(tag);
				TextBuffer tempBuffer = new TextBuffer(textTags);
				TextIter iter = tempBuffer.EndIter;
				tempBuffer.InsertWithTags(ref iter, String.Join("\n", errors), tag);
				textviewErrors.Buffer = tempBuffer;
				return true;
			}
			return false;
		}

		private void UpdateResults(List<string> results)
        {
            GtkScrolledWindowErrors.Visible = true;
            TextTagTable textResultTags = new TextTagTable();
            var tagResult = new TextTag("blue");
            tagResult.Foreground = "blue";
            textResultTags.Add(tagResult);
            TextBuffer tempBuffer = new TextBuffer(textResultTags);
            TextIter iter = tempBuffer.EndIter;
            tempBuffer.InsertWithTags(ref iter, String.Join("\n", results), tagResult);
            textviewErrors.Buffer = tempBuffer;
        }

		protected void OnButtonSyncOrdersClicked(object sender, EventArgs e)
		{
			using(var uow = UnitOfWorkFactory.CreateWithoutRoot("Диалог «Обмен с сайтом» - кнопка «Синхронизация заказов»")) {
				var export = new Exchange(uow);
				export.ProgressUpdated += Export_ProgressUpdated;

				export.OrdersSyncToSite();

				if(UpdateErrors(export.Errors))
					return;

				UpdateResults(export.Results);
				progressbarTotal.Text = "Готово";
				progressbarTotal.Adjustment.Value = progressbarTotal.Adjustment.Upper;
			}
		}
	}
}