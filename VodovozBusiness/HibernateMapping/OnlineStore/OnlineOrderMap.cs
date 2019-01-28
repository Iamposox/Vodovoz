using FluentNHibernate.Mapping;
using NHibernate.Type;
using Vodovoz.Domain.OnlineStore;

namespace Vodovoz.HibernateMapping.OnlineStore
{
	public class OnlineOrderMap : ClassMap<OnlineOrder>
	{
		public OnlineOrderMap()
		{
			Table("online_order");

			Id(x => x.Id).Column("id").GeneratedBy.Native();

			Map(x => x.OnlineStoreId).Column("onlinestore_code");
			Map(x => x.Number).Column("number");
			Map(x => x.Date).Column("date");
			Map(x => x.Time).Column("time").CustomType<TimeAsTimeSpanType>();
			Map(x => x.OperationType).Column("operation_type");
			Map(x => x.Role).Column("role");
			Map(x => x.Currency).Column("currency");
			Map(x => x.Sum).Column("sum");
			Map(x => x.Comments).Column("comment");
			Map(x => x.PaymentDate).Column("payment_date");
			Map(x => x.PaymentDocument).Column("payment_document");
			Map(x => x.PaymentMethod).Column("payment_method");
			Map(x => x.OrderPaid).Column("order_paid");
			Map(x => x.Canceled).Column("canceled");
			Map(x => x.Finish).Column("finish");
			Map(x => x.Status).Column("status");
			Map(x => x.DateOfStatusChange).Column("date_of_staus_change");

			References(x => x.Order).Column("order_id");
			References(x => x.OnlineClient).Column("online_client_id");
		}
	}
}
