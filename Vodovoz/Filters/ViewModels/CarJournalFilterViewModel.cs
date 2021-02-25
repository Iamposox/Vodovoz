using System.Collections.Generic;
using QS.Project.Filter;
using QS.Project.Journal;
using Vodovoz.Domain.Logistic;

namespace Vodovoz.Filters.ViewModels
{
	public class CarJournalFilterViewModel : FilterViewModelBase<CarJournalFilterViewModel>, IJournalFilter
	{
		public CarJournalFilterViewModel()
		{
			includeVisitingMasters = true;
		}
		
		private bool includeArchive;
		public virtual bool IncludeArchive {
			get => includeArchive;
			set => UpdateFilterField(ref includeArchive, value);
		}
		
		private bool includeVisitingMasters;
		public bool IncludeVisitingMasters {
			get => includeVisitingMasters;
			set => UpdateFilterField(ref includeVisitingMasters, value);
		}
		
		private IList<CarTypeOfUse> restrictedCarTypesOfUse;
		public IList<CarTypeOfUse> RestrictedCarTypesOfUse {
			get => restrictedCarTypesOfUse;
			set => UpdateFilterField(ref restrictedCarTypesOfUse, value);
		}
	}
}
