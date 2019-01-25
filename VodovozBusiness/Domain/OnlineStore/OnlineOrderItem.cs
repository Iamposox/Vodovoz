using System;
using System.ComponentModel.DataAnnotations;
using QS.DomainModel.Entity;
using QSBusinessCommon.Domain;
using Vodovoz.Domain.Goods;
using Vodovoz.Domain.Orders;

namespace Vodovoz.Domain.OnlineStore
{
	[Appellative(Gender = GrammaticalGender.Masculine,
		NominativePlural = "строки онлайн-заказа",
		Nominative = "строка онлайн-заказа"
	)]
	public class OnlineOrderItem : PropertyChangedBase, IDomainObject
	{
		#region Свойства
		public virtual int Id { get; set; }

		private string onlineStoreId;

		[Display(Name = "ID в интернет магазине")]
		public virtual string OnlineStoreId {
			get { return onlineStoreId; }
			set { SetField(ref onlineStoreId, value); }
		}

		private OrderItem orderItem;

		[Display(Name = "Строка заказа")]
		public virtual OrderItem OrderItem {
			get { return orderItem; }
			set { SetField(ref orderItem, value); }
		}

		private Nomenclature nomenclature;

		[Display(Name = "Номенклатура")]
		public virtual Nomenclature Nomenclature {
			get { return nomenclature; }
			set { SetField(ref nomenclature, value); }
		}

		private string name;

		[Display(Name = "Наименование")]
		public virtual string Name {
			get { return name; }
			set { SetField(ref name, value); }
		}

		private MeasurementUnits units;

		[Display(Name = "БазоваяЕдиница")]
		public virtual MeasurementUnits Units {
			get { return units; }
			set { SetField(ref units, value); }
		}

		private decimal price;

		[Display(Name = "ЦенаЗаЕдиницу")]
		public virtual decimal Price {
			get { return price; }
			set { SetField(ref price, value); }
		}

		private int amount;

		[Display(Name = "Количество")]
		public virtual int Amount {
			get { return amount; }
			set { SetField(ref amount, value); }
		}

		private decimal sum;

		[Display(Name = "Сумма")]
		public virtual decimal Sum {
			get { return sum; }
			set { SetField(ref sum, value); }
		}

		#endregion

		public OnlineOrderItem()
		{
		}

		public OnlineOrderItem(Nomenclature nomenclature)
		{
			this.nomenclature = nomenclature;
		}
	}
}
