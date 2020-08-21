using System;
using System.Collections.Generic;
using QS.DomainModel.UoW;
using Vodovoz.Domain.Permissions;
using Vodovoz.Services;
using System.Linq;
using Vodovoz.Domain.Cash;

namespace Vodovoz.ServicesImplementations
{
	public class AvailableCashSubdivisionProvider : IAvailableCashSubdivisionProvider
	{
		public IEnumerable<Subdivision> GetAllAvailableCashSubdivisions(IUnitOfWork uow)
		{
			return GetAvailableCashSubdivisions(uow, new[] { typeof(Income), typeof(Expense) , typeof(AdvanceReport) });
		}

		public IEnumerable<Subdivision> GetAvailableCashSubdivisions(IUnitOfWork uow, params Type[] cashDocumentTypes)
		{
			var validationResult = EntitySubdivisionForUserPermissionValidator.Validate(uow, cashDocumentTypes);

			var subdivisionsList = new List<Subdivision>();
			foreach(var item in cashDocumentTypes) {
				subdivisionsList.AddRange(validationResult
					.Where(x => x.GetPermission(item).Read)
					.Select(x => x.Subdivision)
				);
			}

			return subdivisionsList.Distinct();
		}
	}
}
