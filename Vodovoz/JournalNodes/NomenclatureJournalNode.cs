﻿using System.Linq;
using QS.Project.Journal;
using Vodovoz.Domain.Goods;

namespace Vodovoz.JournalNodes
{
	public class NomenclatureJournalNode : JournalEntityNodeBase<Nomenclature>
	{
		public string Name { get; set; }
		public NomenclatureCategory Category { get; set; }
		public decimal InStock => Added - Removed;
		public int? Reserved { get; set; }
		public decimal Available => InStock - Reserved.GetValueOrDefault();
		public decimal Added { get; set; }
		public decimal Removed { get; set; }
		public string UnitName { get; set; }
		public short UnitDigits { get; set; }
		public bool IsEquipmentWithSerial { get; set; }
		public bool CalculateQtyOnStock { get; set; } = true;
		public string InStockText => UsedStock ? Format(InStock) : string.Empty;
		public string ReservedText => UsedStock && Reserved.HasValue ? Format(Reserved.Value) : string.Empty;
		public string AvailableText => UsedStock ? Format(Available) : string.Empty;

		string Format(decimal value) => string.Format("{0:F" + UnitDigits + "} {1}", value, UnitName);
		bool UsedStock => CalculateQtyOnStock && Nomenclature.GetCategoriesForGoods().Contains(Category);
	}
}