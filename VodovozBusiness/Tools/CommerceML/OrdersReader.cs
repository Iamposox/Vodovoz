using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using QS.DomainModel.UoW;
using QSBusinessCommon.Repository;
using Vodovoz.Domain.Goods;
using Vodovoz.Domain.OnlineStore;
using Vodovoz.Repositories.OnlineStore;
using Vodovoz.Repository;

namespace Vodovoz.Tools.CommerceML
{
	public class OrdersReader
	{
		private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
		IUnitOfWork UoW;
		Exchange Exchange;

		public List<OnlineOrder> Orders = new List<OnlineOrder>();
		public List<OnlineClient> OnlineClients = new List<OnlineClient>();

		public OrdersReader(Exchange exchange)
		{
			Exchange = exchange;
			UoW = Exchange.UOW;
		}

		public void Read(string xml)
		{
			XmlDocument content = new XmlDocument();
			content.LoadXml(xml);

			foreach(XmlNode node in content.SelectNodes("/КоммерческаяИнформация/Документ")) {
				#region Основная инфа
				var operationType = node.SelectSingleNode("ХозОперация").InnerText;
				if(operationType != "Заказ товара") {
					var msg = $"Не умеем разбирать документы с ХозОперация='{operationType}', поэтому пропускаем.";
					logger.Error(msg);
					Exchange.Errors.Add(msg);
					continue;
				}
				var onlineId = node.SelectSingleNode("Ид").InnerText;
				var order = OnlineOrderRepository.GetOrderByOnlineStoreId(UoW, onlineId);
				if(order == null) {
					order = new OnlineOrder();
					order.OnlineStoreId = onlineId;
				}
				order.Number = node.SelectSingleNode("Номер").InnerText;
				var dateText = node.SelectSingleNode("Дата").InnerText;
				order.Date = DateTime.Parse(dateText);
				var timeText = node.SelectSingleNode("Время").InnerText;
				order.Time = TimeSpan.Parse(timeText);
				order.OperationType = node.SelectSingleNode("ХозОперация").InnerText;
				order.Role = node.SelectSingleNode("Роль").InnerText;
				order.Currency = node.SelectSingleNode("Валюта").InnerText;
				order.Sum = decimal.Parse(node.SelectSingleNode("Сумма").InnerText);
				order.Comments = node.SelectSingleNode("Комментарий").InnerText;
				#endregion
				#region Контрагент
				var counterpartyNode = node.SelectSingleNode("Контрагенты/Контрагент");
				var clientOnlineId = counterpartyNode.SelectSingleNode("Ид").InnerText;
				OnlineClient onlineClient = OnlineClients.FirstOrDefault(x => x.OnlineStoreId == clientOnlineId);
				if(onlineClient == null)
					onlineClient = OnlineClientRepository.GetClientByOnlineStoreId(UoW, clientOnlineId);
				if(onlineClient == null) {
					onlineClient = new OnlineClient();
					onlineClient.OnlineStoreId = clientOnlineId;
					OnlineClients.Add(onlineClient);
				}
				onlineClient.Name = counterpartyNode.SelectSingleNode("Наименование").InnerText.Trim();
				onlineClient.FullName = counterpartyNode.SelectSingleNode("ПолноеНаименование").InnerText;
				onlineClient.Role = counterpartyNode.SelectSingleNode("Роль").InnerText;
				onlineClient.LastName = counterpartyNode.SelectSingleNode("Фамилия").InnerText;
				onlineClient.FirstName = counterpartyNode.SelectSingleNode("Имя").InnerText;
				order.OnlineClient = onlineClient;
				#endregion
				#region Товары
				var notProcessedItems = order.Items.ToList();
				foreach(XmlNode itemNode in node.SelectNodes("Товары/Товар")) {
					var goodsId = itemNode.SelectSingleNode("Ид").InnerXml.Trim();
					Nomenclature nomenclature;
					if(goodsId == "ORDER_DELIVERY") {
						nomenclature = NomenclatureRepository.GetNomenclatureForDelivery(UoW);
					} else {
						nomenclature = NomenclatureRepository.GetNomenclatureByOnlineStoreGuid(UoW, goodsId);
					}
					if(nomenclature == null) {
						var msg = $"Товар со следующими характеристиками был пропущен так как не найден в справочнике:\n{itemNode.InnerText}";
						logger.Error(msg);
						Exchange.Errors.Add(msg);
						continue;
					}
					var item = order.Items.FirstOrDefault(x => x.Nomenclature.Id == nomenclature.Id);
					if(item == null) {
						item = new OnlineOrderItem(nomenclature);
						order.AddItem(item);
					} else
						notProcessedItems.Remove(item);
					item.Price = decimal.Parse(itemNode.SelectSingleNode("ЦенаЗаЕдиницу").InnerXml);
					item.Amount = int.Parse(itemNode.SelectSingleNode("Количество").InnerXml);
					item.Sum = decimal.Parse(itemNode.SelectSingleNode("Сумма").InnerXml);
					item.Units = MeasurementUnitsRepository.GetUnitsByOKEI(UoW, itemNode.SelectSingleNode("БазоваяЕдиница/@Код").InnerText);
				}
				notProcessedItems.ForEach(x => order.Items.Remove(x));
				#endregion
				#region Значения реквизитов
				var requisites = node.SelectSingleNode("ЗначенияРеквизитов");
				DateTime paymentDate;
				if(DateTime.TryParse(requisites.SelectSingleNode("ЗначениеРеквизита[Наименование='Дата оплаты']/Значение").InnerText, out paymentDate))
					order.PaymentDate = paymentDate;
				order.PaymentDocument = requisites.SelectSingleNode("ЗначениеРеквизита[Наименование='Номер платежного документа']/Значение").InnerText;
				order.PaymentMethod = requisites.SelectSingleNode("ЗначениеРеквизита[Наименование='Метод оплаты']/Значение").InnerText;
				order.OrderPaid = XmlConvert.ToBoolean(requisites.SelectSingleNode("ЗначениеРеквизита[Наименование='Заказ оплачен']/Значение").InnerText);
				order.Canceled = XmlConvert.ToBoolean(requisites.SelectSingleNode("ЗначениеРеквизита[Наименование='Отменен']/Значение").InnerText);
				order.Finish = XmlConvert.ToBoolean(requisites.SelectSingleNode("ЗначениеРеквизита[Наименование='Финальный статус']/Значение").InnerText);
				order.Status = requisites.SelectSingleNode("ЗначениеРеквизита[Наименование='Статус заказа']/Значение").InnerText;
				order.DateOfStatusChange = DateTime.Parse(requisites.SelectSingleNode("ЗначениеРеквизита[Наименование='Дата изменения статуса']/Значение").InnerText);
				#endregion
				Orders.Add(order);
			}

			//public void Read(string xml)
			//{
			//	XmlDocument content = new XmlDocument();
			//	content.LoadXml(xml);

			//	foreach(XmlNode node in content.SelectNodes("/КоммерческаяИнформация/Документ")) {
			//		#region Основная инфа
			//		var operationType = node.SelectSingleNode("ХозОперация").InnerText;
			//		if(operationType != "Заказ товара") {
			//			var msg = $"Не умеем разбирать документы с ХозОперация='{operationType}', поэтому пропускаем.";
			//			logger.Error(msg);
			//			Exchange.Errors.Add(msg);
			//			continue;
			//		}
			//		var onlineId = node.SelectSingleNode("Ид").InnerText;
			//		var order = OrderRepository.GetOrderByOnlineStoreId(UoW, onlineId);
			//		if(order == null) {
			//			order = new Domain.Orders.Order();
			//			order.OrderSource = Domain.Orders.OrderSource.OnlineStore;
			//			order.OnlineStoreId = onlineId;
			//		}
			//		var dateText = node.SelectSingleNode("Дата").InnerText;
			//		var date = DateTime.Parse(dateText);
			//		var timeText = node.SelectSingleNode("Время").InnerText;
			//		var time = TimeSpan.Parse(timeText);
			//		order.CreateDate = date + time;
			//		order.Comment = node.SelectSingleNode("Комментарий").InnerText;
			//		#endregion
			//		#region Контрагент
			//		var counterpartyNode = node.SelectSingleNode("Контрагенты/Контрагент");
			//		var clientOnlineId = counterpartyNode.SelectSingleNode("Ид").InnerText;
			//		OnlineClient onlineClient = OnlineClients.FirstOrDefault(x => x.OnlineStoreId == clientOnlineId);
			//		if(onlineClient == null)
			//			onlineClient = OnlineClientRepository.GetClientByOnlineStoreId(UoW, clientOnlineId);
			//		if(onlineClient == null) {
			//			onlineClient = new OnlineClient();
			//			onlineClient.OnlineStoreId = clientOnlineId;
			//			OnlineClients.Add(onlineClient);
			//		}
			//		onlineClient.Name = counterpartyNode.SelectSingleNode("Наименование").InnerText;
			//		onlineClient.FullName = counterpartyNode.SelectSingleNode("ПолноеНаименование").InnerText;
			//		onlineClient.Role = counterpartyNode.SelectSingleNode("Роль").InnerText;
			//		onlineClient.LastName = counterpartyNode.SelectSingleNode("Фамилия").InnerText;
			//		onlineClient.FirstName = counterpartyNode.SelectSingleNode("Имя").InnerText;
			//		#endregion
			//		#region Товары
			//		var notProcessedItems = order.OrderItems.ToList();
			//		foreach(XmlNode itemNode in node.SelectNodes("Товары/Товар")) {
			//			var goodsId = itemNode.SelectSingleNode("Ид").InnerXml.Trim();
			//			Nomenclature nomenclature;
			//			if(goodsId == "ORDER_DELIVERY") {
			//				nomenclature = NomenclatureRepository.GetNomenclatureForDelivery(UoW);
			//			} else {
			//				nomenclature = NomenclatureRepository.GetNomenclatureByOnlineStoreGuid(UoW, goodsId);
			//			}
			//			if(nomenclature == null) {
			//				var msg = $"Товар со следующими характеристиками был пропущен так как не найден в справочнике:\n{itemNode.InnerText}";
			//				logger.Error(msg);
			//				Exchange.Errors.Add(msg);
			//				continue;
			//			}
			//			var amount = int.Parse(itemNode.SelectSingleNode("Количество").InnerXml);
			//			var item = order.OrderItems.FirstOrDefault(x => x.Nomenclature.Id == nomenclature.Id);
			//			if(item == null) {
			//				item = order.AddAnyGoodsNomenclatureForSale(nomenclature, cnt: amount);
			//			} else
			//				notProcessedItems.Remove(item);
			//			item.Price = decimal.Parse(itemNode.SelectSingleNode("ЦенаЗаЕдиницу").InnerXml);
			//			item.Count = amount;
			//		}
			//		notProcessedItems.ForEach(order.RemoveItem);
			//		#endregion
			//		#region Значения реквизитов
			//		#endregion
			//		Orders.Add(order);
			//	}
			//}
		}
	}
}
