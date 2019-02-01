using NSubstitute;
using NUnit.Framework;
using QS.Dialog;
using System;
using System.Collections.Generic;
using System.Linq;
using Vodovoz.Domain.Client;
using Vodovoz.Domain.Goods;
using Vodovoz.Domain.OnlineStore;
using Vodovoz.Domain.Orders;

namespace VodovozBusinessTests.OnlineStore
{
	[TestFixture(TestOf = typeof(Order))]
	public class OrderTest
	{
		[Test(Description = "Проверка что в созданном из онлай заказа, заказе заполняется все необходимое.")]
		public void Order_NewOrderFromOnlineOrder_FillingRequiredCase()
		{
			var interactive = Substitute.For<IInteractiveMessage>();
			var counterparty = Substitute.For<Counterparty>();
			var onlineClient = Substitute.For<OnlineClient>();
			onlineClient.Counterparty = counterparty;

			var onlineOrder = Substitute.For<OnlineOrder>();
			onlineOrder.Comments.Returns("Комментарий");
			onlineOrder.Sum.Returns(450);
			onlineOrder.OnlineClient.Returns(onlineClient);

			var items = new List<OnlineOrderItem>();

			var nomenclature1 = Substitute.For<Nomenclature>();
			var item1 = Substitute.For<OnlineOrderItem>();
			item1.Nomenclature.Returns(nomenclature1);
			item1.Price = 100;
			item1.Amount = 3;
			items.Add(item1);

			var nomenclature2 = Substitute.For<Nomenclature>();
			var item2 = Substitute.For<OnlineOrderItem>();
			item2.Nomenclature.Returns(nomenclature2);
			item2.Price = 150;
			item2.Amount = 1;
			items.Add(item2);

			onlineOrder.Items.Returns(items);

			var order = new Order();
			order.NewOrderFromOnlineOrder(interactive, onlineOrder);

			Assert.That(order.Client, Is.EqualTo(counterparty));
			Assert.That(order.Comment, Is.EqualTo("Комментарий"));

			var orderItem1 = order.OrderItems.First(x => x.Nomenclature == nomenclature1);
			Assert.That(orderItem1.Count, Is.EqualTo(3));
			Assert.That(orderItem1.Price, Is.EqualTo(100));
			Assert.That(orderItem1.Sum, Is.EqualTo(300));

			var orderItem2 = order.OrderItems.First(x => x.Nomenclature == nomenclature2);
			Assert.That(orderItem2.Count, Is.EqualTo(1));
			Assert.That(orderItem2.Price, Is.EqualTo(150));
			Assert.That(orderItem2.Sum, Is.EqualTo(150));

			Assert.That(order.TotalSum, Is.EqualTo(450));
		}
	}
}
