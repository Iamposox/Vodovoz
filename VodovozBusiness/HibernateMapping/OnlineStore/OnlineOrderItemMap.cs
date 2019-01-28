using System;
using FluentNHibernate.Mapping;
using Vodovoz.Domain.OnlineStore;

namespace Vodovoz.HibernateMapping.OnlineStore
{
	public class OnlineOrderItemMap : ClassMap<OnlineOrderItem>
	{
		public OnlineOrderItemMap()
		{
			Table("online_order_items");

			Id(x => x.Id).Column("id").GeneratedBy.Native();

			Map(x => x.OnlineStoreId).Column("online_store_guid");
			Map(x => x.Name).Column("name");
			Map(x => x.Price).Column("price");
			Map(x => x.Amount).Column("amount");
			Map(x => x.Sum).Column("sum");

			References(x => x.OnlineOrder).Column("online_order_id");
			References(x => x.OrderItem).Column("order_item_id");
			References(x => x.Nomenclature).Column("nomenclature_id");
			References(x => x.Units).Column("unit_id");
		}
	}
}
