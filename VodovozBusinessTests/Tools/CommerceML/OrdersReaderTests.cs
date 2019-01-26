using System;
using System.Linq;
using NSubstitute;
using NUnit.Framework;
using QS.DomainModel.UoW;
using QSBusinessCommon.Domain;
using QSBusinessCommon.Repository;
using Vodovoz.Domain.Goods;
using Vodovoz.Repositories.OnlineStore;
using Vodovoz.Repository;
using Vodovoz.Tools.CommerceML;

namespace VodovozBusinessTests.Tools.CommerceML
{
	[TestFixture(TestOf = typeof(OrdersReader))]
	public class OrdersReaderTests
	{
		[Test(Description = "Проверка парсинга всех необходимых полей")]
		public void ReadAllRequiredFieldsTest()
		{
			var xml = "<?xml version=\"1.0\" encoding=\"windows-1251\"?>\n<КоммерческаяИнформация ВерсияСхемы=\"2.01\" ДатаФормирования=\"2019-01-25\"><Документ><Ид>2204</Ид><Номер>2204</Номер><Дата>2018-12-10</Дата><ХозОперация>Заказ товара</ХозОперация><Роль>Продавец</Роль><Валюта>руб</Валюта><Курс>1</Курс><Сумма>650</Сумма><Время>12:18:00</Время><Комментарий>Заказ №7</Комментарий><Контрагенты><Контрагент><Ид>2202</Ид><Наименование>Иван\u00a0Проверочкин</Наименование><ПолноеНаименование>Иван\u00a0Проверочкин</ПолноеНаименование><Роль>Покупатель</Роль><Фамилия>Проверочкин</Фамилия><Имя>Иван</Имя></Контрагент></Контрагенты><Товары><Товар><Ид>\n\t\t\t\tORDER_DELIVERY\n\t\t\t</Ид><Наименование>\n\t\t\t\tДоставка заказа\n\t\t\t</Наименование><БазоваяЕдиница Код=\"796\" НаименованиеПолное=\"Штука\" МеждународноеСокращение=\"PCE\">\n\t\t\t\tшт\n\t\t\t</БазоваяЕдиница><ЦенаЗаЕдиницу>200</ЦенаЗаЕдиницу><Количество>\n\t\t\t\t1\n\t\t\t</Количество><Сумма>200</Сумма><ЗначенияРеквизитов><ЗначениеРеквизита><Наименование>\n\t\t\t\t\t\tВидНоменклатуры\n\t\t\t\t\t</Наименование><Значение>\n\t\t\t\t\t\tУслуга\n\t\t\t\t\t</Значение></ЗначениеРеквизита><ЗначениеРеквизита><Наименование>\n\t\t\t\t\t\tТипНоменклатуры\n\t\t\t\t\t</Наименование><Значение>\n\t\t\t\t\t\tУслуга\n\t\t\t\t\t</Значение></ЗначениеРеквизита></ЗначенияРеквизитов></Товар><Товар><Ид>a54d2ff8-7e6d-43c6-aef5-40d46f16e488</Ид><ИдКаталога>79ecd59a-403b-4bac-809d-738d4e146b84</ИдКаталога><Наименование>Вода 19 л \"Весёлый Водовоз PREMIUM Кислородная\"</Наименование><БазоваяЕдиница Код=\"796\" НаименованиеПолное=\"Штука\" МеждународноеСокращение=\"PCE\">шт</БазоваяЕдиница><ЦенаЗаЕдиницу>225</ЦенаЗаЕдиницу><Сумма>450</Сумма><Количество>2</Количество><Единица>шт</Единица><Коэффициент>1</Коэффициент><ЗначенияРеквизитов><ЗначениеРеквизита><Наименование>ВидНоменклатуры</Наименование><Значение>Товар</Значение></ЗначениеРеквизита><ЗначениеРеквизита><Наименование>ТипНоменклатуры</Наименование><Значение>Товар</Значение></ЗначениеРеквизита></ЗначенияРеквизитов></Товар></Товары><ЗначенияРеквизитов><ЗначениеРеквизита><Наименование>Дата оплаты</Наименование><Значение>2018-12-13</Значение></ЗначениеРеквизита><ЗначениеРеквизита><Наименование>Номер платежного документа</Наименование><Значение>33561</Значение></ЗначениеРеквизита><ЗначениеРеквизита><Наименование>Метод оплаты</Наименование><Значение>Счет для юр. лиц</Значение></ЗначениеРеквизита><ЗначениеРеквизита><Наименование>Заказ оплачен</Наименование><Значение>false</Значение></ЗначениеРеквизита><ЗначениеРеквизита><Наименование>Отменен</Наименование><Значение>false</Значение></ЗначениеРеквизита><ЗначениеРеквизита><Наименование>Финальный статус</Наименование><Значение>false</Значение></ЗначениеРеквизита><ЗначениеРеквизита><Наименование>Статус заказа</Наименование><Значение>Доставляется</Значение></ЗначениеРеквизита><ЗначениеРеквизита><Наименование>Дата изменения статуса</Наименование><Значение>2018-12-13 11:25</Значение></ЗначениеРеквизита></ЗначенияРеквизитов></Документ></КоммерческаяИнформация>";

			var uow = Substitute.For<IUnitOfWork>();
			var exchange = Substitute.For<Exchange>(uow);
			var reader = new OrdersReader(exchange);
			var nomenclature1 = Substitute.For<Nomenclature>();
			nomenclature1.Id.Returns(1);
			nomenclature1.Name.Returns("Доставка заказа");
			var nomenclature2 = Substitute.For<Nomenclature>();
			nomenclature2.Id.Returns(2);
			nomenclature2.OnlineStoreGuid.Returns(Guid.Parse("a54d2ff8-7e6d-43c6-aef5-40d46f16e488"));
			var pce = Substitute.For<MeasurementUnits>();
			pce.OKEI.Returns("796");

			OnlineOrderRepository.GetOrderByOnlineStoreIdTestGap = (u, id) => null;
			OnlineClientRepository.GetClientByOnlineStoreIdTestGap = (u, id) => null;
			NomenclatureRepository.GetNomenclatureForDeliveryTestGap = (u) => nomenclature1;
			NomenclatureRepository.GetNomenclatureByOnlineStoreGuidTestGap = (u, guid) => guid == nomenclature2.OnlineStoreGuid ? nomenclature2 : null;
			MeasurementUnitsRepository.GetUnitsByOKEITestGap = (u, id) => pce;

			reader.Read(xml);

			var order = reader.Orders.First();
			Assert.That(order.OnlineStoreId, Is.EqualTo("2204"));
			Assert.That(order.Number, Is.EqualTo("2204"));
			Assert.That(order.OperationType, Is.EqualTo("Заказ товара"));
			Assert.That(order.Date, Is.EqualTo(new DateTime(2018, 12, 10)));
			Assert.That(order.Time, Is.EqualTo(new TimeSpan(12, 18, 0)));
			Assert.That(order.Comments, Is.EqualTo("Заказ №7"));
			Assert.That(order.Sum, Is.EqualTo(650));

			Assert.That(order.PaymentDate, Is.EqualTo(new DateTime(2018, 12, 13)));
			Assert.That(order.PaymentDocument, Is.EqualTo("33561"));
			Assert.That(order.PaymentMethod, Is.EqualTo("Счет для юр. лиц"));
			Assert.That(order.OrderPaid, Is.EqualTo(false));
			Assert.That(order.Canceled, Is.EqualTo(false));
			Assert.That(order.Finish, Is.EqualTo(false));
			Assert.That(order.Status, Is.EqualTo("Доставляется"));
			Assert.That(order.DateOfStatusChange, Is.EqualTo(new DateTime(2018, 12, 13, 11, 25, 0)));

			var client = order.OnlineClient;
			Assert.That(client.OnlineStoreId, Is.EqualTo("2202"));
			Assert.That(client.Name, Is.EqualTo("Иван\u00a0Проверочкин"));//Тут мы получаем в качестве пробела символ неразрывного пробела так передет umi
			Assert.That(client.FullName, Is.EqualTo("Иван\u00a0Проверочкин"));
			Assert.That(client.LastName, Is.EqualTo("Проверочкин"));
			Assert.That(client.FirstName, Is.EqualTo("Иван"));
			Assert.That(client.Role, Is.EqualTo("Покупатель"));

			var item1 = order.Items[0];
			Assert.That(item1.Nomenclature, Is.EqualTo(nomenclature1));
			Assert.That(item1.Amount, Is.EqualTo(1));
			Assert.That(item1.Price, Is.EqualTo(200));
			Assert.That(item1.Sum, Is.EqualTo(200));
			Assert.That(item1.Units, Is.EqualTo(pce));

			var item2 = order.Items[1];
			Assert.That(item2.Nomenclature, Is.EqualTo(nomenclature2));
			Assert.That(item2.Amount, Is.EqualTo(2));
			Assert.That(item2.Price, Is.EqualTo(225));
			Assert.That(item2.Sum, Is.EqualTo(450));
			Assert.That(item2.Units, Is.EqualTo(pce));
		}

		[TearDown]
		public void RemoveStaticGaps()
		{
			OnlineOrderRepository.GetOrderByOnlineStoreIdTestGap = null;
			OnlineClientRepository.GetClientByOnlineStoreIdTestGap = null;
			NomenclatureRepository.GetNomenclatureForDeliveryTestGap = null;
			NomenclatureRepository.GetNomenclatureByOnlineStoreGuidTestGap = null;
			MeasurementUnitsRepository.GetUnitsByOKEITestGap = null;
		}
	}
}
