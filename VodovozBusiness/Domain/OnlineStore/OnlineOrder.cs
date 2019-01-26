using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using NHibernate.Criterion;
using QS.DomainModel.Entity;

namespace Vodovoz.Domain.OnlineStore
{
	[Appellative(Gender = GrammaticalGender.Masculine,
		NominativePlural = "онлайн-заказы",
		Nominative = "онлайн-заказ"
	)]
	public class OnlineOrder : PropertyChangedBase, IDomainObject
	{
		#region Свойства
		public virtual int Id { get; set; }

		private string onlineStoreId;

		private Order order;

		[Display(Name = "Заказ")]
		public virtual Order Order {
			get { return order; }
			set { SetField(ref order, value); }
		}

		[Display(Name = "ID в интернет магазине")]
		public virtual string OnlineStoreId {
			get { return onlineStoreId; }
			set { SetField(ref onlineStoreId, value); }
		}

		private string number;

		[Display(Name = "Номер")]
		public virtual string Number {
			get { return number; }
			set { SetField(ref number, value); }
		}

		private DateTime date;

		[Display(Name = "Дата")]
		public virtual DateTime Date {
			get { return date; }
			set { SetField(ref date, value); }
		}

		private string operationType;

		[Display(Name = "ХозОперация")]
		public virtual string OperationType {
			get { return operationType; }
			set { SetField(ref operationType, value); }
		}

		private string role;

		[Display(Name = "Роль")]
		public virtual string Role {
			get { return role; }
			set { SetField(ref role, value); }
		}

		private string currency;

		[Display(Name = "Валюта")]
		public virtual string Currency {
			get { return currency; }
			set { SetField(ref currency, value); }
		}

		private decimal sum;

		[Display(Name = "Сумма")]
		public virtual decimal Sum {
			get { return sum; }
			set { SetField(ref sum, value); }
		}

		private TimeSpan time;

		[Display(Name = "Время")]
		public virtual TimeSpan Time {
			get { return time; }
			set { SetField(ref time, value); }
		}

		private string comments;

		[Display(Name = "Комментарий")]
		public virtual string Comments {
			get { return comments; }
			set { SetField(ref comments, value); }
		}

		private OnlineClient onlineClient;

		[Display(Name = "Клиент")]
		public virtual OnlineClient OnlineClient {
			get { return onlineClient; }
			set { SetField(ref onlineClient, value); }
		}

		private IList<OnlineOrderItem> items = new List<OnlineOrderItem>();

		[Display(Name = "Товары")]
		public virtual IList<OnlineOrderItem> Items {
			get { return items; }
			set { SetField(ref items, value); }
		}

		private DateTime? paymentDate;

		[Display(Name = "Дата оплаты")]
		public virtual DateTime? PaymentDate {
			get { return paymentDate; }
			set { SetField(ref paymentDate, value); }
		}

		private string paymentDocument;

		[Display(Name = "Номер платежного документа")]
		public virtual string PaymentDocument {
			get { return paymentDocument; }
			set { SetField(ref paymentDocument, value); }
		}

		private string paymentMethod;

		[Display(Name = "Метод оплаты")]
		public virtual string PaymentMethod {
			get { return paymentMethod; }
			set { SetField(ref paymentMethod, value); }
		}

		private bool orderPaid;

		[Display(Name = "Заказ оплачен")]
		public virtual bool OrderPaid {
			get { return orderPaid; }
			set { SetField(ref orderPaid, value); }
		}

		private bool canceled;

		[Display(Name = "Отменен")]
		public virtual bool Canceled {
			get { return canceled; }
			set { SetField(ref canceled, value); }
		}

		private bool finish;

		[Display(Name = "Финальный статус")]
		public virtual bool Finish {
			get { return finish; }
			set { SetField(ref finish, value); }
		}

		private string status;

		[Display(Name = "Статус заказа")]
		public virtual string Status {
			get { return status; }
			set { SetField(ref status, value); }
		}

		private DateTime dateOfStatusChange;

		[Display(Name = "Дата изменения статуса")]
		public virtual DateTime DateOfStatusChange {
			get { return dateOfStatusChange; }
			set { SetField(ref dateOfStatusChange, value); }
		}

		#endregion

		public OnlineOrder()
		{
		}
	}
}
