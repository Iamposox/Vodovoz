using System;
using System.Collections.Generic;
using QS.DomainModel.UoW;

namespace Vodovoz.Services
{
	public interface IAvailableCashSubdivisionProvider
	{
		IEnumerable<Subdivision> GetAllAvailableCashSubdivisions(IUnitOfWork uow);
		IEnumerable<Subdivision> GetAvailableCashSubdivisions(IUnitOfWork uow, params Type[] cashDocumentTypes);
	}
}
