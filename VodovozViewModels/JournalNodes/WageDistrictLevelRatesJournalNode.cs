﻿using QS.Project.Journal;
using Vodovoz.Domain.WageCalculation;

namespace Vodovoz.JournalNodes
{
	public class WageDistrictLevelRatesJournalNode : JournalEntityNodeBase<WageDistrictLevelRates>
	{
		public string IsArchiveString => IsArchive ? "Да" : "Нет";
		public string IsDefaultLevelString => IsDefaultLevel ? "Да" : string.Empty;
		public string RowColor => IsArchive ? "grey" : "black";

		public string Name { get; set; }
		public bool IsArchive { get; set; }
		public bool IsDefaultLevel{ get; set; }
	}
}