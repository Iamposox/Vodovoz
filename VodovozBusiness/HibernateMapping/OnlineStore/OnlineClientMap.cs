using System;
using FluentNHibernate.Mapping;
using Vodovoz.Domain.OnlineStore;

namespace Vodovoz.HibernateMapping.OnlineStore
{
	public class OnlineClientMap : ClassMap<OnlineClient>
	{
		public OnlineClientMap()
		{
			Table("online_client");

			Id(x => x.Id).Column("id").GeneratedBy.Native();

			Map(x => x.OnlineStoreId).Column("onlinestore_code");
			Map(x => x.Name).Column("name");
			Map(x => x.FullName).Column("full_name");
			Map(x => x.Role).Column("role");
			Map(x => x.LastName).Column("last_name");
			Map(x => x.FirstName).Column("first_name");

			References(x => x.Counterparty).Column("counterparty_id");
		}
	}
}
