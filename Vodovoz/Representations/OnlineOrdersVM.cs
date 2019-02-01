using System;
using Gamma.ColumnConfig;
using Gamma.Utilities;
using Gtk;
using NHibernate.Transform;
using QS.DomainModel.UoW;
using QSOrmProject.RepresentationModel;
using QSProjectsLib;
using Vodovoz.Domain.Client;
using Vodovoz.Domain.OnlineStore;
using Vodovoz.Domain.Orders;

namespace Vodovoz.Representations
{
	public class OnlineOrdersVM : RepresentationModelEntityBase<OnlineOrder, OnlineOrdersVMNode>
	{

		public OnlineOrdersVM()
		{
			UoW = UnitOfWorkFactory.CreateWithoutRoot("Представление онлайн заказы");
		}

		IColumnsConfig columnsConfig = FluentColumnsConfig<OnlineOrdersVMNode>.Create()
			.AddColumn("Номер").AddTextRenderer(node => node.Number)
			.AddColumn("Дата").AddTextRenderer(node => node.CreateDate)
			.AddColumn("Обработка").AddTextRenderer(node => node.NeedAction)
			.AddColumn("Статус").AddTextRenderer(node => node.OnlineStatus)
			.AddColumn("Клиент").AddTextRenderer(node => node.Client)
			.AddColumn("Сумма").AddTextRenderer(node => CurrencyWorks.GetShortCurrencyString(node.Sum))
			.AddColumn("Послед. изменения").AddTextRenderer(node => node.LastEditedTime != default(DateTime) ? node.LastEditedTime.ToString() : String.Empty)
			.AddColumn("Комментарий").AddTextRenderer(node => node.Comment)
			.RowCells().AddSetter<CellRendererText>((c, n) => c.Foreground = n.RowColor)
			.Finish();

		public override IColumnsConfig ColumnsConfig => columnsConfig;

		public override void UpdateNodes()
		{
			Order orderAlias = null;
			OnlineOrder onlineOrderAlias = null;
			OnlineClient onlineClientAlias = null;
			Counterparty counterpartyAlias = null;

			OnlineOrdersVMNode resultAlias = null;

			var query = UoW.Session.QueryOver<OnlineOrder>(() => onlineOrderAlias);

			var result = query
				.JoinAlias(o => o.Order, () => orderAlias, NHibernate.SqlCommand.JoinType.LeftOuterJoin)
				.JoinAlias(o => o.OnlineClient, () => onlineClientAlias)
				.JoinAlias(() => onlineClientAlias.Counterparty, () => counterpartyAlias, NHibernate.SqlCommand.JoinType.LeftOuterJoin)
				.SelectList(list => list
				   .Select(() => onlineOrderAlias.Id).WithAlias(() => resultAlias.Id)
				   .Select(() => onlineOrderAlias.Number).WithAlias(() => resultAlias.Number)
				   .Select(() => onlineOrderAlias.Date).WithAlias(() => resultAlias.Date)
				   .Select(() => onlineOrderAlias.Time).WithAlias(() => resultAlias.Time)
				   .Select(() => orderAlias.OrderStatus).WithAlias(() => resultAlias.StatusEnum)
				   .Select(() => onlineOrderAlias.Status).WithAlias(() => resultAlias.OnlineStatus)
				   .Select(() => onlineOrderAlias.DateOfStatusChange).WithAlias(() => resultAlias.LastEditedTime)
				   .Select(() => counterpartyAlias.Name).WithAlias(() => resultAlias.Counterparty)
				   .Select(() => onlineClientAlias.Name).WithAlias(() => resultAlias.CounterpartyOnline)
				   .Select(() => onlineClientAlias.FirstName).WithAlias(() => resultAlias.ClientFirstName)
				   .Select(() => onlineClientAlias.LastName).WithAlias(() => resultAlias.ClientLastName)
				   .Select(() => onlineOrderAlias.Sum).WithAlias(() => resultAlias.Sum)
				   .Select(() => onlineOrderAlias.Comments).WithAlias(() => resultAlias.Comment)
				   .Select(() => orderAlias.Id).WithAlias(() => resultAlias.OrderId)
				   .Select(() => onlineClientAlias.Id).WithAlias(() => resultAlias.OnlineClientId)
				   .Select(() => counterpartyAlias.Id).WithAlias(() => resultAlias.CounterpartyId)
				).OrderBy(x => x.DateOfStatusChange).Desc
				.TransformUsing(Transformers.AliasToBean<OnlineOrdersVMNode>())
				.List<OnlineOrdersVMNode>();

			SetItemsSource(result);
		}

		protected override bool NeedUpdateFunc(OnlineOrder updatedSubject)
		{
			return true;
		}
	}

	public class OnlineOrdersVMNode
	{
		public int Id { get; set; }

		[UseForSearch]
		[SearchHighlight]
		public string Number { get; set; }

		public OrderStatus? StatusEnum { get; set; }

		public string OnlineStatus { get; set; }

		public string NeedAction {
			get {
				if(CounterpartyId == null)
					return "Привяжите контрагента";
				if(OrderId == null)
					return "Создайте заказ";
				return StatusEnum.GetEnumTitle();
			}
		}

		public DateTime Date { get; set; }
		public TimeSpan Time { get; set; }

		public string CreateDate => (Date + Time).ToString("g");

		public int? OrderId { get; set; }
		public int? CounterpartyId { get; set; }
		public int? OnlineClientId { get; set; }

		public string Counterparty { get; set; }

		public string CounterpartyOnline { get; set; }

		[UseForSearch]
		[SearchHighlight]
		public string Client => String.IsNullOrWhiteSpace(Counterparty) ? CounterpartyOnline : Counterparty;

		public decimal Sum { get; set; }

		public string ClientFirstName { get; set; }
		public string ClientLastName { get; set; }

		[UseForSearch]
		[SearchHighlight]
		public string Comment { get; set; }

		public DateTime LastEditedTime { get; set; }

		public string RowColor {
			get {
				if(CounterpartyId == null)
					return "red";
				if(OrderId == null)
					return "orange";
				if(StatusEnum == OrderStatus.Canceled || StatusEnum == OrderStatus.DeliveryCanceled)
					return "grey";
				if(StatusEnum == OrderStatus.Closed)
					return "darkgreen";
				return "green";
			}
		}
	}
}
