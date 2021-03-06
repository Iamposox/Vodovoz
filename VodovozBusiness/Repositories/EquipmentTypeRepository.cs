﻿using System.Collections.Generic;
using System.Linq;
using QS.DomainModel.UoW;
using Vodovoz.Domain;

namespace Vodovoz.Repositories
{
	public static class EquipmentTypeRepository
	{
		public static List<EquipmentType> GetPaidRentEquipmentTypes (IUnitOfWork uow)
		{
			var availableTypes = uow.Session.CreateCriteria (typeof(PaidRentPackage))
				.List<PaidRentPackage> ()
				.Select (p => p.EquipmentType)
				.Distinct ().ToList ();
			return availableTypes;
		}
	}
}

