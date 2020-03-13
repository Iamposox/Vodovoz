﻿using System;
using System.Collections.Generic;
using QS.Project.Journal.EntitySelector;
using Vodovoz.Domain.Orders;
using Vodovoz.Domain.Store;

namespace Vodovoz.TempAdapters
{
	public interface IOrderSelectorFactory
	{
		IEntitySelector CreateOrderSelectorForMovementDocument(bool IsOnlineStoreOrders, IEnumerable<OrderStatus> orderStatuses);
	}
}