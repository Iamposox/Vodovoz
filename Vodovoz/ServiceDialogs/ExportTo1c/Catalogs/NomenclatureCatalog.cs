﻿using System;
using System.Collections.Generic;
using System.Linq;
using Gamma.Utilities;
using Vodovoz.Domain.Goods;

namespace Vodovoz.ExportTo1c.Catalogs
{
	public class NomenclatureCatalog:GenericCatalog<Nomenclature>
	{
		public NomenclatureCatalog(ExportData exportData)
			:base(exportData)
		{			
		}
		protected override string Name
		{
			get{return "Номенклатура";}
		}

		public override ReferenceNode CreateReferenceTo(Nomenclature nomenclature)
		{
			int id = GetReferenceId(nomenclature);

			if(String.IsNullOrWhiteSpace(nomenclature.Code1c))
				exportData.Errors.Add($"Для номенклатуры {nomenclature.Id} - '{nomenclature.Name}' не заполнен код 1с.");

			return new ReferenceNode(id,
				new PropertyNode("Код",
					Common1cTypes.String,
			                     nomenclature.Code1c
				),
				new PropertyNode("ЭтоГруппа",
					Common1cTypes.Boolean
				)
			);
		}

		protected override PropertyNode[] GetProperties(Nomenclature nomenclature)
		{
			var properties = new List<PropertyNode>();
			properties.Add(
				new PropertyNode("Наименование",
					Common1cTypes.String,
					nomenclature.Name
				)
			);

			if(nomenclature.Folder1C == null)
				exportData.Errors.Add($"Для номенклатуры {nomenclature.Id} - '{nomenclature.Name}' не заполнена папка 1с.");
			else {
				properties.Add(
					new PropertyNode("Родитель",
						Common1cTypes.ReferenceNomenclature,	
					                 exportData.NomenclatureGroupCatalog.CreateReferenceTo(nomenclature.Folder1C)
					)
				);
			}

			if (nomenclature.Unit != null)
			{
				properties.Add(
					new PropertyNode("ЕдиницаИзмерения",
						Common1cTypes.ReferenceMeasurementUnit,
						exportData.MeasurementUnitCatalog.CreateReferenceTo(nomenclature.Unit)
					)
				);
			}
			else
			{
				properties.Add(
					new PropertyNode("ЕдиницаИзмерения",
						Common1cTypes.ReferenceMeasurementUnit
					)
				);
			}
			properties.Add(
				new PropertyNode("Комментарий",
					Common1cTypes.String
				)
			);
			properties.Add(
				new PropertyNode("НомерГТД",
					"СправочникСсылка.НомераГТД"
				)
			);

			var vat = nomenclature.VAT.GetAttribute<Value1cType>().Value;

			properties.Add(
				new PropertyNode("ВидСтавкиНДС",
					Common1cTypes.EnumVATTypes,
					vat
				)
			);

			var isService = !Nomenclature.GetCategoriesForGoods().Contains(nomenclature.Category);

			if (isService)
				properties.Add(
					new PropertyNode("Услуга",
						Common1cTypes.Boolean,
						"true"
					)
				);
			else
				properties.Add(
					new PropertyNode("Услуга",
						Common1cTypes.Boolean
					)
				);

			if (isService)
				properties.Add(
					new PropertyNode("ВидНоменклатуры",
						Common1cTypes.ReferenceNomenclatureType,
						exportData.NomenclatureTypeCatalog.CreateReferenceTo(NomenclatureType1c.ServicesType)
					)
				);
			else
				properties.Add(
					new PropertyNode("ВидНоменклатуры",
						Common1cTypes.ReferenceNomenclatureType,
						exportData.NomenclatureTypeCatalog.CreateReferenceTo(NomenclatureType1c.GoodsType)
					)
				);

			properties.Add(
				new PropertyNode("НаименованиеПолное",
					Common1cTypes.String,
				                 nomenclature.OfficialName
				)
			);
			return properties.ToArray();
		}			
	}
}

