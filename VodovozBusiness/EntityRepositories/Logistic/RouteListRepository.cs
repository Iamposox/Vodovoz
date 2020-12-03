﻿using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Transform;
using QS.DomainModel.Entity;
using QS.DomainModel.UoW;
using Vodovoz.Core.DataService;
using Vodovoz.Domain;
using Vodovoz.Domain.Cash;
using Vodovoz.Domain.Client;
using Vodovoz.Domain.Documents;
using Vodovoz.Domain.Employees;
using Vodovoz.Domain.Goods;
using Vodovoz.Domain.Logistic;
using Vodovoz.Domain.Operations;
using Vodovoz.Domain.Orders;
using Vodovoz.Domain.Sale;
using Vodovoz.Domain.Store;
using Vodovoz.EntityRepositories.Subdivisions;
using Vodovoz.Repositories;

namespace Vodovoz.EntityRepositories.Logistic
{
	public class RouteListRepository : IRouteListRepository
	{
		public IList<RouteList> GetDriverRouteLists(IUnitOfWork uow, Employee driver, RouteListStatus status, DateTime date)
		{
			RouteList routeListAlias = null;

			return uow.Session.QueryOver<RouteList>(() => routeListAlias)
					  .Where(() => routeListAlias.Driver == driver)
					  .Where(() => routeListAlias.Status == status)
					  .Where(() => routeListAlias.Date == date)
					  .List();
		}

		public QueryOver<RouteList> GetRoutesAtDay(DateTime date)
		{
			return QueryOver.Of<RouteList>()
				.Where(x => x.Date == date);
		}

		public QueryOver<RouteList> GetRoutesAtDay(DateTime date, List<int> geographicGroupsIds)
		{
			GeographicGroup geographicGroupAlias = null;

			var query = QueryOver.Of<RouteList>()
								 .Where(x => x.Date == date)
								 ;

			if(geographicGroupsIds.Any()) {
				var routeListsWithGeoGroupsSubquery = QueryOver.Of<RouteList>()
															   .Left.JoinAlias(r => r.GeographicGroups, () => geographicGroupAlias)
															   .Where(() => geographicGroupAlias.Id.IsIn(geographicGroupsIds))
															   .Select(r => r.Id);
				query.WithSubquery.WhereProperty(r => r.Id).In(routeListsWithGeoGroupsSubquery);
			}

			return query;
		}

		public IList<GoodsInRouteListResult> GetGoodsAndEquipsInRL(
			IUnitOfWork uow,
			RouteList routeList,
			ISubdivisionRepository subdivisionRepository = null,
			Warehouse warehouse = null)
		{
			if(subdivisionRepository == null && warehouse != null) {
				throw new ArgumentNullException(nameof(subdivisionRepository));
			}

			List<GoodsInRouteListResult> result = new List<GoodsInRouteListResult>();

			if(warehouse != null) {
				var cashSubdivisions = subdivisionRepository.GetCashSubdivisions(uow);
				if(cashSubdivisions.Contains(warehouse.OwningSubdivision)) {
					var terminal = GetTerminalInRL(uow, routeList, warehouse);
					if(terminal != null)
						result.Add(terminal);
				}
				else {
					result.AddRange(GetGoodsInRLWithoutEquipments(uow, routeList).ToList());
					result.AddRange(GetEquipmentsInRL(uow, routeList).ToList());
				}
			}
			else {
				result.AddRange(GetGoodsInRLWithoutEquipments(uow, routeList).ToList());
				result.AddRange(GetEquipmentsInRL(uow, routeList).ToList());

				var terminal = GetTerminalInRL(uow, routeList);
				if(terminal != null)
					result.Add(terminal);
			}

			return result
				.GroupBy(x => x.NomenclatureId, x => x.Amount)
				.Select(x => new GoodsInRouteListResult {
						NomenclatureId = x.Key,
						Amount = x.Sum()
					}
				)
				.ToList();
		}

		public IList<GoodsInRouteListResult> GetGoodsInRLWithoutEquipments(IUnitOfWork uow, RouteList routeList)
		{
			GoodsInRouteListResult resultAlias = null;
			Vodovoz.Domain.Orders.Order orderAlias = null;
			OrderItem orderItemsAlias = null;
			Nomenclature OrderItemNomenclatureAlias = null;

			var ordersQuery = QueryOver.Of(() => orderAlias);

			var routeListItemsSubQuery = QueryOver.Of<RouteListItem>()
				.Where(r => r.RouteList.Id == routeList.Id)
				.Where(r => !r.WasTransfered || (r.WasTransfered && r.NeedToReload))
				.Select(r => r.Order.Id);
			ordersQuery.WithSubquery.WhereProperty(o => o.Id).In(routeListItemsSubQuery).Select(o => o.Id);

			var orderitemsQuery = uow.Session.QueryOver<OrderItem>(() => orderItemsAlias)
				.WithSubquery.WhereProperty(i => i.Order.Id).In(ordersQuery)
				.JoinAlias(() => orderItemsAlias.Nomenclature, () => OrderItemNomenclatureAlias)
				.Where(() => OrderItemNomenclatureAlias.Category.IsIn(Nomenclature.GetCategoriesForShipment()));

			return orderitemsQuery.SelectList(list => list
				.SelectGroup(() => OrderItemNomenclatureAlias.Id).WithAlias(() => resultAlias.NomenclatureId)
				.SelectSum(() => orderItemsAlias.Count).WithAlias(() => resultAlias.Amount))
			    .TransformUsing(Transformers.AliasToBean<GoodsInRouteListResult>())
				.List<GoodsInRouteListResult>();
		}

		public IList<GoodsInRouteListResult> GetEquipmentsInRL(IUnitOfWork uow, RouteList routeList)
		{
			GoodsInRouteListResult resultAlias = null;
			Vodovoz.Domain.Orders.Order orderAlias = null;
			OrderEquipment orderEquipmentAlias = null;
			Nomenclature OrderEquipmentNomenclatureAlias = null;

			//Выбирается список Id заказов находящихся в МЛ
			var ordersQuery = QueryOver.Of<Vodovoz.Domain.Orders.Order>(() => orderAlias);
			var routeListItemsSubQuery = QueryOver.Of<RouteListItem>()
				.Where(r => r.RouteList.Id == routeList.Id)
				.Where(r => !r.WasTransfered || (r.WasTransfered && r.NeedToReload))
				.Select(r => r.Order.Id);
			ordersQuery.WithSubquery.WhereProperty(o => o.Id).In(routeListItemsSubQuery).Select(o => o.Id);

			var orderEquipmentsQuery = uow.Session.QueryOver<OrderEquipment>(() => orderEquipmentAlias)
				.WithSubquery.WhereProperty(i => i.Order.Id).In(ordersQuery)
				.Where(() => orderEquipmentAlias.Direction == Direction.Deliver)
				.JoinAlias(() => orderEquipmentAlias.Nomenclature, () => OrderEquipmentNomenclatureAlias);
				
			return orderEquipmentsQuery
				.SelectList(list => list
				   .SelectGroup(() => OrderEquipmentNomenclatureAlias.Id).WithAlias(() => resultAlias.NomenclatureId)
							.Select(Projections.Sum(
					   Projections.Cast(NHibernateUtil.Decimal, Projections.Property(() => orderEquipmentAlias.Count)))).WithAlias(() => resultAlias.Amount)
				)
				.TransformUsing(Transformers.AliasToBean<GoodsInRouteListResult>())
				.List<GoodsInRouteListResult>();
		}
		
		public GoodsInRouteListResult GetTerminalInRL(IUnitOfWork uow, RouteList routeList, Warehouse warehouse = null) {
			CarLoadDocumentItem carLoadDocumentItemAlias = null;
			
			var terminalId = new BaseParametersProvider().GetNomenclatureIdForTerminal;
			var needTerminal = routeList.Addresses.Any(x => x.Order.PaymentType == PaymentType.Terminal);

			var loadedTerminal = uow.Session.QueryOver<CarLoadDocument>()
			                        .JoinAlias(x => x.Items, () => carLoadDocumentItemAlias)
			                        .Where(() => carLoadDocumentItemAlias.Nomenclature.Id == terminalId)
			                        .And(x => x.RouteList.Id == routeList.Id)
			                        .List();
			
			if (needTerminal || loadedTerminal.Any()) {
				var terminal = uow.GetById<Nomenclature>(terminalId);
				int amount = 1;

				if(warehouse == null) {
					return new GoodsInRouteListResult {
						NomenclatureId = terminalId,
						Amount = amount
					};
				}


				if(StockRepository.NomenclatureInStock(uow, warehouse.Id, new int[] { terminal.Id }).Any()) {
					return new GoodsInRouteListResult {
						NomenclatureId = terminalId,
						Amount = amount
					};
				}
			}

			return null;
		}

		public IList<GoodsLoadedListResult> AllGoodsLoaded(IUnitOfWork UoW, RouteList routeList, CarLoadDocument excludeDoc = null)
		{
			CarLoadDocument docAlias = null;
			CarLoadDocumentItem docItemsAlias = null;
			Nomenclature nomenclatureAlias = null;
			GoodsLoadedListResult inCarLoads = null;

			var loadedQuery = UoW.Session.QueryOver<CarLoadDocument>(() => docAlias)
				.Where(d => d.RouteList.Id == routeList.Id);
			if(excludeDoc != null)
				loadedQuery.Where(d => d.Id != excludeDoc.Id);

			var loadedlist = loadedQuery
				.JoinAlias(d => d.Items, () => docItemsAlias)
				.JoinAlias(() => docItemsAlias.Nomenclature, () => nomenclatureAlias)
				.SelectList(list => list
				   .SelectGroup(() => docItemsAlias.Nomenclature.Id).WithAlias(() => inCarLoads.NomenclatureId)
				   .Select(() => nomenclatureAlias.Category).WithAlias(() => inCarLoads.NomenclatureCategory)
				   .SelectSum(() => docItemsAlias.Amount).WithAlias(() => inCarLoads.Amount)
				).TransformUsing(Transformers.AliasToBean<GoodsLoadedListResult>())
				.List<GoodsLoadedListResult>();
			return loadedlist;
		}

		public List<ReturnsNode> GetReturnsToWarehouse(IUnitOfWork uow, int routeListId, NomenclatureCategory[] categories, int[] excludeNomenclatureIds = null)
		{
			List<ReturnsNode> result = new List<ReturnsNode>();
			Nomenclature nomenclatureAlias = null;
			ReturnsNode resultAlias = null;
			Equipment equipmentAlias = null;
			CarUnloadDocumentItem carUnloadItemsAlias = null;
			WarehouseMovementOperation movementOperationAlias = null;

			var returnableQuery = uow.Session.QueryOver<CarUnloadDocument>().Where(doc => doc.RouteList.Id == routeListId)
				.JoinAlias(doc => doc.Items, () => carUnloadItemsAlias)
				.JoinAlias(() => carUnloadItemsAlias.WarehouseMovementOperation, () => movementOperationAlias)
				.Where(Restrictions.IsNotNull(Projections.Property(() => movementOperationAlias.IncomingWarehouse)))
				.JoinAlias(() => movementOperationAlias.Nomenclature, () => nomenclatureAlias)
				.Where(() => !nomenclatureAlias.IsSerial)
				.Where(() => nomenclatureAlias.Category.IsIn(categories));
			if(excludeNomenclatureIds != null)
				returnableQuery.Where(() => !nomenclatureAlias.Id.IsIn(excludeNomenclatureIds));

			var returnableItems =
				returnableQuery.SelectList(list => list
					.SelectGroup(() => nomenclatureAlias.Id).WithAlias(() => resultAlias.NomenclatureId)
					.Select(() => nomenclatureAlias.Name).WithAlias(() => resultAlias.Name)
					.Select(() => false).WithAlias(() => resultAlias.Trackable)
					.Select(() => nomenclatureAlias.Category).WithAlias(() => resultAlias.NomenclatureCategory)
					.SelectSum(() => movementOperationAlias.Amount).WithAlias(() => resultAlias.Amount)
								  )
				.TransformUsing(Transformers.AliasToBean<ReturnsNode>())
				.List<ReturnsNode>();

			var returnableQueryEquipment = uow.Session.QueryOver<CarUnloadDocument>().Where(doc => doc.RouteList.Id == routeListId)
				.JoinAlias(doc => doc.Items, () => carUnloadItemsAlias)
				.JoinAlias(() => carUnloadItemsAlias.WarehouseMovementOperation, () => movementOperationAlias)
				.Where(Restrictions.IsNotNull(Projections.Property(() => movementOperationAlias.IncomingWarehouse)))
				.JoinAlias(() => movementOperationAlias.Equipment, () => equipmentAlias)
				.JoinAlias(() => equipmentAlias.Nomenclature, () => nomenclatureAlias)
				.Where(() => nomenclatureAlias.Category.IsIn(categories));
			if(excludeNomenclatureIds != null)
				returnableQueryEquipment.Where(() => !nomenclatureAlias.Id.IsIn(excludeNomenclatureIds));

			var returnableEquipment =
				returnableQueryEquipment.SelectList(list => list
					.Select(() => equipmentAlias.Id).WithAlias(() => resultAlias.Id)
					.SelectGroup(() => nomenclatureAlias.Id).WithAlias(() => resultAlias.NomenclatureId)
					.Select(() => nomenclatureAlias.Name).WithAlias(() => resultAlias.Name)
					.Select(() => nomenclatureAlias.IsSerial).WithAlias(() => resultAlias.Trackable)
					.Select(() => nomenclatureAlias.Category).WithAlias(() => resultAlias.NomenclatureCategory)
					.SelectSum(() => movementOperationAlias.Amount).WithAlias(() => resultAlias.Amount)
					.Select(() => nomenclatureAlias.Type).WithAlias(() => resultAlias.EquipmentType)
									  )
				.TransformUsing(Transformers.AliasToBean<ReturnsNode>())
				.List<ReturnsNode>();

			result.AddRange(returnableItems);
			result.AddRange(returnableEquipment);
			DomainHelper.FillPropertyByEntity<ReturnsNode, Nomenclature>(uow, result, x => x.NomenclatureId, (node, nom) => node.Nomenclature = nom);
			return result;
		}

		/// <summary>
		/// Возвращает список товаров возвращенного на склад по номенклатурам
		/// </summary>
		public List<ReturnsNode> GetReturnsToWarehouse(IUnitOfWork uow, int routeListId, params int[] nomenclatureIds)
		{
			List<ReturnsNode> result = new List<ReturnsNode>();
			Nomenclature nomenclatureAlias = null;
			ReturnsNode resultAlias = null;
			Equipment equipmentAlias = null;
			CarUnloadDocument carUnloadAlias = null;
			CarUnloadDocumentItem carUnloadItemsAlias = null;
			WarehouseMovementOperation movementOperationAlias = null;

			var returnableQuery = QueryOver.Of<CarUnloadDocument>(() => carUnloadAlias)
				   .JoinAlias(() => carUnloadAlias.Items, () => carUnloadItemsAlias)
				   .JoinAlias(() => carUnloadItemsAlias.WarehouseMovementOperation, () => movementOperationAlias)
				   .JoinAlias(() => movementOperationAlias.Nomenclature, () => nomenclatureAlias)
				   .Where(Restrictions.IsNotNull(Projections.Property(() => movementOperationAlias.IncomingWarehouse)))
				   .Where(() => !nomenclatureAlias.IsSerial)
				   .Where(() => carUnloadAlias.RouteList.Id == routeListId)
				   .Where(() => nomenclatureAlias.Id.IsIn(nomenclatureIds))
				   .GetExecutableQueryOver(uow.Session);

			var returnableItems = returnableQuery.SelectList
			(
				list => list.SelectGroup(() => nomenclatureAlias.Id).WithAlias(() => resultAlias.NomenclatureId)
					.Select(() => nomenclatureAlias.Name).WithAlias(() => resultAlias.Name)
					.Select(() => false).WithAlias(() => resultAlias.Trackable)
					.Select(() => nomenclatureAlias.Category).WithAlias(() => resultAlias.NomenclatureCategory)
					.Select(() => carUnloadItemsAlias.DefectSource).WithAlias(() => resultAlias.DefectSource)
					.SelectSum(() => movementOperationAlias.Amount).WithAlias(() => resultAlias.Amount)
			)
			.TransformUsing(Transformers.AliasToBean<ReturnsNode>())
			.List<ReturnsNode>();

			var returnableQueryEquipment = uow.Session.QueryOver<CarUnloadDocument>(() => carUnloadAlias)
				.JoinAlias(() => carUnloadAlias.Items, () => carUnloadItemsAlias)
				.JoinAlias(() => carUnloadItemsAlias.WarehouseMovementOperation, () => movementOperationAlias)
				.JoinAlias(() => movementOperationAlias.Equipment, () => equipmentAlias)
				.JoinAlias(() => equipmentAlias.Nomenclature, () => nomenclatureAlias)
				.Where(Restrictions.IsNotNull(Projections.Property(() => movementOperationAlias.IncomingWarehouse)))
				.Where(() => carUnloadAlias.RouteList.Id == routeListId)
				.Where(() => nomenclatureAlias.Id.IsIn(nomenclatureIds))
				;
			

			var returnableEquipment =
				returnableQueryEquipment.SelectList(list => list
					.Select(() => equipmentAlias.Id).WithAlias(() => resultAlias.Id)
					.SelectGroup(() => nomenclatureAlias.Id).WithAlias(() => resultAlias.NomenclatureId)
					.Select(() => nomenclatureAlias.Name).WithAlias(() => resultAlias.Name)
					.Select(() => nomenclatureAlias.IsSerial).WithAlias(() => resultAlias.Trackable)
					.Select(() => nomenclatureAlias.Category).WithAlias(() => resultAlias.NomenclatureCategory)
					.SelectSum(() => movementOperationAlias.Amount).WithAlias(() => resultAlias.Amount)
					.Select(() => nomenclatureAlias.Type).WithAlias(() => resultAlias.EquipmentType)
					.Select(() => carUnloadItemsAlias.DefectSource).WithAlias(() => resultAlias.DefectSource)
									  )
				.TransformUsing(Transformers.AliasToBean<ReturnsNode>())
				.List<ReturnsNode>();

			result.AddRange(returnableItems);
			result.AddRange(returnableEquipment);
			DomainHelper.FillPropertyByEntity<ReturnsNode, Nomenclature>(uow, result, x => x.NomenclatureId, (node, nom) => node.Nomenclature = nom);
			return result;
		}

		public int BottlesUnloadedByCarUnloadedDocuments(IUnitOfWork uow, int emptyBottleId, int routeListId, params int[] exceptDocumentIds) {

			WarehouseMovementOperation movementOperationAlias = null;

			var returnableQuery = OrderItemsReturnedToAllWarehouses(uow, routeListId, emptyBottleId).GetExecutableQueryOver(uow.Session);
			var result = returnableQuery.WhereNot(x => x.Id.IsIn(exceptDocumentIds))
										.SelectList(list => list.SelectSum(() => movementOperationAlias.Amount))
										.SingleOrDefault<decimal>()
										;
			return (int)result;
		}

		public QueryOver<CarUnloadDocument> OrderItemsReturnedToAllWarehouses(IUnitOfWork uow, int routeListId, params int[] nomenclatureIds)
		{
			List<ReturnsNode> result = new List<ReturnsNode>();
			Nomenclature nomenclatureAlias = null;
			CarUnloadDocumentItem carUnloadItemsAlias = null;
			WarehouseMovementOperation movementOperationAlias = null;
			CarUnloadDocument carUnloadAlias = null;

			

			var returnableQuery = QueryOver.Of<CarUnloadDocument>()
										   .Where(doc => doc.RouteList.Id == routeListId)
										   .JoinAlias(doc => doc.Items, () => carUnloadItemsAlias)
										   .JoinAlias(() => carUnloadItemsAlias.WarehouseMovementOperation, () => movementOperationAlias)
										   .Where(Restrictions.IsNotNull(Projections.Property(() => movementOperationAlias.IncomingWarehouse)))
										   .JoinAlias(() => movementOperationAlias.Nomenclature, () => nomenclatureAlias)
										   .Where(() => !nomenclatureAlias.IsSerial)
										   .Where(() => nomenclatureAlias.Id.IsIn(nomenclatureIds));

			return returnableQuery;
		}

		public IEnumerable<CarLoadDocument> GetCarLoadDocuments(IUnitOfWork uow, int routelistId)
		{
			return uow.Session.QueryOver<CarLoadDocument>()
			   .Where(x => x.RouteList.Id == routelistId)
			   .List();
		}

		public RouteList GetRouteListByOrder(IUnitOfWork uow, Domain.Orders.Order order)
		{
			RouteList routeListAlias = null;
			RouteListItem routeListItemAlias = null;
			return uow.Session.QueryOver(() => routeListAlias)
							  .Left.JoinAlias(() => routeListAlias.Addresses, () => routeListItemAlias)
							  .Where(() => routeListItemAlias.Order.Id == order.Id)
							  .List()
							  .FirstOrDefault();
		}

		public bool RouteListWasChanged(RouteList routeList)
		{
			using(var uow = UnitOfWorkFactory.CreateWithoutRoot()) {
				var actualRouteList = uow.GetById<RouteList>(routeList.Id);
				return actualRouteList.Version != routeList.Version;
			}
		}
	}

	#region DTO

	public class ReturnsNode
	{
		public int Id { get; set; }
		public Nomenclature Nomenclature { get; set; }
		public NomenclatureCategory NomenclatureCategory { get; set; }
		public int NomenclatureId { get; set; }
		public string Name { get; set; }
		public decimal Amount { get; set; }
		public bool Trackable { get; set; }
		public EquipmentType EquipmentType { get; set; }
		public DefectSource DefectSource { get; set; }
		
		public string Serial {
			get {
				if(Trackable)
					return Id > 0 ? Id.ToString() : "(не определен)";
				return string.Empty;
			}
		}

		public bool Returned {
			get => Amount > 0;
			set => Amount = value ? 1 : 0;
		}
	}

	public class GoodsInRouteListResult
	{
		public int NomenclatureId { get; set; }
		public decimal Amount { get; set; }
	}

	public class GoodsLoadedListResult
	{
		public int NomenclatureId { get; set; }
		public NomenclatureCategory NomenclatureCategory { get; set; }
		public decimal Amount { get; set; }
	}

	#endregion
}