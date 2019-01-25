using System;
using QS.DomainModel.UoW;
using Vodovoz.Domain.OnlineStore;

namespace Vodovoz.Repositories.OnlineStore
{
	public static class OnlineClientRepository
	{
		internal static Func<IUnitOfWork, string, OnlineClient> GetClientByOnlineStoreIdTestGap;
		public static OnlineClient GetClientByOnlineStoreId(IUnitOfWork uow, string onlineStoreId)
		{
			if(GetClientByOnlineStoreIdTestGap != null)
				return GetClientByOnlineStoreIdTestGap(uow, onlineStoreId);

			return uow.Session.QueryOver<OnlineClient>()
				.Where(x => x.OnlineStoreId == onlineStoreId)
				.SingleOrDefault();
		}
	}
}
