using System;
using QS.DomainModel.UoW;
using Vodovoz.Domain.OnlineStore;

namespace Vodovoz.Repositories.OnlineStore
{
	public static class OnlineOrderRepository
	{
		internal static Func<IUnitOfWork, string, OnlineOrder> GetOrderByOnlineStoreIdTestGap;
		public static OnlineOrder GetOrderByOnlineStoreId(IUnitOfWork uow, string onlineStoreId)
		{
			if(GetOrderByOnlineStoreIdTestGap != null)
				return GetOrderByOnlineStoreIdTestGap(uow, onlineStoreId);

			return uow.Session.QueryOver<OnlineOrder>()
				.Where(x => x.OnlineStoreId == onlineStoreId)
				.SingleOrDefault();
		}
	}
}
