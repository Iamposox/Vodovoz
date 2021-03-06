﻿using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Dialect.Function;
using NHibernate.Transform;
using QS.DomainModel.UoW;
using Vodovoz.Domain.Documents;
using Vodovoz.Domain.Goods;
using Vodovoz.Domain.Operations;
using Vodovoz.Domain.Store;

namespace Vodovoz.EntityRepositories.Store
{
	public class WarehouseRepository : IWarehouseRepository
	{
		public IList<Warehouse> GetActiveWarehouse(IUnitOfWork uow)
		{
			return uow.Session.QueryOver<Warehouse>().WhereNot(x => x.IsArchive).List<Warehouse>();
		}

		public IList<Warehouse> WarehousesForPublishOnlineStore(IUnitOfWork uow)
		{
			return uow.Session.QueryOver<Warehouse>()
					  .WhereNot(x => x.IsArchive)
					  .Where(x => x.PublishOnlineStore)
					  .List<Warehouse>();
		}

		public IEnumerable<NomanclatureStockNode> GetWarehouseNomenclatureStock(IUnitOfWork uow, int warehouseId, IEnumerable<int> nomenclatureIds)
		{
			NomanclatureStockNode resultAlias = null;
			Nomenclature nomenclatureAlias = null;
			WarehouseMovementOperation warehouseOperation = null;

			IProjection incomeAmount = Projections.Sum(
				Projections.Conditional(
					Restrictions.Eq(Projections.Property(() => warehouseOperation.IncomingWarehouse.Id), warehouseId),
					Projections.Property(() => warehouseOperation.Amount),
					Projections.Constant(0M)
				)
			);

			IProjection writeoffAmount = Projections.Sum(
				Projections.Conditional(
					Restrictions.Eq(Projections.Property(() => warehouseOperation.WriteoffWarehouse.Id), warehouseId),
					Projections.Property(() => warehouseOperation.Amount),
					Projections.Constant(0M)
				)
			);

			IProjection stockProjection = Projections.SqlFunction(new SQLFunctionTemplate(NHibernateUtil.Decimal, "( IFNULL(?1, 0) - IFNULL(?2, 0) )"),
					NHibernateUtil.Int32,
					incomeAmount,
					writeoffAmount
			);

			return uow.Session.QueryOver(() => warehouseOperation)
				.Left.JoinAlias(() => warehouseOperation.Nomenclature, () => nomenclatureAlias)
				.Where(Restrictions.In(Projections.Property(() => warehouseOperation.Nomenclature.Id), nomenclatureIds.ToArray()))
				.SelectList(list => list
					.SelectGroup(() => nomenclatureAlias.Id).WithAlias(() => resultAlias.NomenclatureId)
					.Select(stockProjection).WithAlias(() => resultAlias.Stock)
				)
				.TransformUsing(Transformers.AliasToBean<NomanclatureStockNode>())
				.List<NomanclatureStockNode>();
		}

		public IEnumerable<NomanclatureStockNode> GetWarehouseNomenclatureStock(IUnitOfWork uow, int warehouseId)
		{
			NomanclatureStockNode resultAlias = null;
			Nomenclature nomenclatureAlias = null;
			WarehouseMovementOperation warehouseOperation = null;

			IProjection incomeAmount = Projections.Sum(
				Projections.Conditional(
					Restrictions.Eq(Projections.Property(() => warehouseOperation.IncomingWarehouse.Id), warehouseId),
					Projections.Property(() => warehouseOperation.Amount),
					Projections.Constant(0M)
				)
			);

			IProjection writeoffAmount = Projections.Sum(
				Projections.Conditional(
					Restrictions.Eq(Projections.Property(() => warehouseOperation.WriteoffWarehouse.Id), warehouseId),
					Projections.Property(() => warehouseOperation.Amount),
					Projections.Constant(0M)
				)
			);

			IProjection stockProjection = Projections.SqlFunction(new SQLFunctionTemplate(NHibernateUtil.Decimal, "( IFNULL(?1, 0) - IFNULL(?2, 0) )"),
					NHibernateUtil.Int32,
					incomeAmount,
					writeoffAmount
			);

			return uow.Session.QueryOver(() => warehouseOperation)
				.Left.JoinAlias(() => warehouseOperation.Nomenclature, () => nomenclatureAlias)
				.SelectList(list => list
					.SelectGroup(() => nomenclatureAlias.Id).WithAlias(() => resultAlias.NomenclatureId)
					.Select(stockProjection).WithAlias(() => resultAlias.Stock)
				)
				.TransformUsing(Transformers.AliasToBean<NomanclatureStockNode>())
				.List<NomanclatureStockNode>();
		}

		public IEnumerable<Nomenclature> GetDiscrepancyNomenclatures(IUnitOfWork uow, int warehouseId)
		{
			if(uow == null) {
				throw new ArgumentNullException(nameof(uow));
			}

			Nomenclature nomenclatureAlias = null;
			MovementDocument movementDocumentAlias = null;
			MovementDocumentItem movementDocumentItemAlias = null;

			return uow.Session.QueryOver(() => movementDocumentItemAlias)
				.Left.JoinAlias(() => movementDocumentItemAlias.Nomenclature, () => nomenclatureAlias)
				.Left.JoinAlias(() => movementDocumentItemAlias.Document, () => movementDocumentAlias)
				.Where(() => movementDocumentAlias.Status == MovementDocumentStatus.Discrepancy)
				.Where(() => movementDocumentAlias.FromWarehouse.Id == warehouseId)
				.Where(() => movementDocumentItemAlias.SendedAmount != movementDocumentItemAlias.ReceivedAmount)
				.Select(Projections.Entity(() => nomenclatureAlias))
				.List<Nomenclature>();
		}
	}
}
