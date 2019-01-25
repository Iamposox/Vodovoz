using System;
using System.ComponentModel.DataAnnotations;
using QS.DomainModel.Entity;
using Vodovoz.Domain.Client;

namespace Vodovoz.Domain.OnlineStore
{

	[Appellative(Gender = GrammaticalGender.Masculine,
		NominativePlural = "клиенты интернет-магазина",
		Nominative = "клиент интернет-магазика"
	)]
	public class OnlineClient : PropertyChangedBase, IDomainObject
	{
		#region Свойства

		public virtual int Id { get; set; }

		private string onlineStoreId;

		[Display(Name = "ID в интернет магазине")]
		public virtual string OnlineStoreId {
			get { return onlineStoreId; }
			set { SetField(ref onlineStoreId, value); }
		}

		string name;

		[Display(Name = "Название")]
		public virtual string Name {
			get { return name; }
			set { SetField(ref name, value, () => Name); }
		}

		private string fullName;

		[Display(Name = "Полное наименование")]
		public virtual string FullName {
			get { return fullName; }
			set { SetField(ref fullName, value); }
		}

		private string role;

		[Display(Name = "Роль")]
		public virtual string Role {
			get { return role; }
			set { SetField(ref role, value); }
		}

		private string lastName;

		[Display(Name = "Фамилия")]
		public virtual string LastName {
			get { return lastName; }
			set { SetField(ref lastName, value); }
		}

		private string firstName;

		[Display(Name = "Имя")]
		public virtual string FirstName {
			get { return firstName; }
			set { SetField(ref firstName, value); }
		}

		private Counterparty counterparty;

		[Display(Name = "Привязанный контрагент")]
		public virtual Counterparty Counterparty {
			get { return counterparty; }
			set { SetField(ref counterparty, value); }
		}

		#endregion

		public OnlineClient()
		{
		}
	}
}
