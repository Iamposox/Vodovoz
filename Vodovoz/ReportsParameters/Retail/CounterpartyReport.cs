﻿using System;
using System.Collections.Generic;
using QS.Dialog;
using QS.Dialog.GtkUI;
using QS.DomainModel.UoW;
using QS.Project.Journal.EntitySelector;
using QS.Report;
using QS.Services;
using QSReport;
using Vodovoz.Domain.Client;
using Vodovoz.Domain.Retail;
using Vodovoz.Domain.Sale;

namespace Vodovoz.ReportsParameters.Retail
{
    [System.ComponentModel.ToolboxItem(true)]
    public partial class CounterpartyReport : SingleUoWWidgetBase, IParametersWidget
    {
        public CounterpartyReport(IEntityAutocompleteSelectorFactory salesChannelSelectorFactory,
            IEntityAutocompleteSelectorFactory districtSelectorFactory, IUnitOfWorkFactory unitOfWorkFactory,
            IInteractiveService interactiveService)
        {
            this.Build();
            UoW = unitOfWorkFactory.CreateWithoutRoot();
            ConfigureView(salesChannelSelectorFactory, districtSelectorFactory, interactiveService);
        }

        public string Title => $"Отчет по контрагентам розницы";

        public event EventHandler<LoadReportEventArgs> LoadReport;

        private void ConfigureView(IEntityAutocompleteSelectorFactory salesChannelSelectorFactory,
            IEntityAutocompleteSelectorFactory districtSelectorFactory,
            IInteractiveService interactiveService)
        {
            buttonCreateReport.Clicked += (sender, e) => OnUpdate(interactiveService, true);
            yEntitySalesChannel.SetEntityAutocompleteSelectorFactory(salesChannelSelectorFactory);
            yEntityDistrict.SetEntityAutocompleteSelectorFactory(districtSelectorFactory);
            yenumPaymentType.ItemsEnum = typeof(PaymentType);
            yenumPaymentType.SelectedItem = PaymentType.cash;
        }

        private ReportInfo GetReportInfo()
        {
                var parameters = new Dictionary<string, object> {
                { "create_date", ydateperiodpickerCreate.StartDateOrNull },
                { "sales_channel_id", (yEntitySalesChannel.Subject as SalesChannel)?.Id ?? 0},
                { "district", (yEntityDistrict.Subject as District)?.Id ?? 0 },
                { "payment_type", (yenumPaymentType.SelectedItemOrNull)}
            };

            return new ReportInfo
            {
                Identifier = "Retail.CounterpartyReport",
                Parameters = parameters
            };
        }

        void OnUpdate(IInteractiveService interactiveService, bool hide = false)
        {
            if (Validate(interactiveService))
            {
                LoadReport?.Invoke(this, new LoadReportEventArgs(GetReportInfo(), hide));
            }
        }

        bool Validate(IInteractiveService interactiveService)
        {
            string errorString = string.Empty;
            if (!(ydateperiodpickerCreate.StartDateOrNull.HasValue &&
                ydateperiodpickerCreate.EndDateOrNull.HasValue))
            {
                errorString = "Не выбран период";
                interactiveService.ShowMessage(ImportanceLevel.Error, errorString);
                return false;
            }

            return true;
        }
    }
}
