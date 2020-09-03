using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using QS.Print;
using QS.Report;
using Vodovoz.Core.DataService;
using Vodovoz.Domain.Client;

namespace Vodovoz.Domain.Orders.Documents
{
	public class CoolerWarrantyDocument : OrderDocument, IPrintableRDLDocument
	{
		#region implemented abstract members of OrderDocument
		public virtual ReportInfo GetReportInfo()
		{
			return new ReportInfo {
				Title = $"Гарантийный талон на кулера №{WarrantyFullNumber}",
				Identifier = "Documents.CoolerWarranty",
				Parameters = new Dictionary<string, object> {
					{ "order_id", Order.Id },
					{ "agreement_id",  AdditionalAgreementId },
					{ "warranty_full_number", WarrantyFullNumber },
					{ "organization_id", new BaseParametersProvider().GetCashlessOrganisationId }
				}
			};
		}
		public virtual Dictionary<object, object> Parameters { get; set; }
		#endregion

		public override OrderDocumentType Type => OrderDocumentType.CoolerWarranty;

		public override DateTime? DocumentDate => Order?.DeliveryDate;

		public override string Name => String.Format("Гарантийный талон на кулера №{0}", WarrantyFullNumber);

		int copiesToPrint = 1;
		public override int CopiesToPrint {
			get => copiesToPrint;
			set => copiesToPrint = value;
		}

		public override PrinterType PrintType => PrinterType.RDL;

		CounterpartyContract contract;

		[Display(Name = "Договор")]
		public virtual CounterpartyContract Contract {
			get => contract;
			set => SetField(ref contract, value);
		}

		int additionalAgreementId;

		[Display(Name = "Доп. соглашение")]
		public virtual int AdditionalAgreementId {
			get => additionalAgreementId;
			set => SetField(ref additionalAgreementId, value);
		}

		int warrantyNumber;

		[Display(Name = "Номер гарантийного талона")]
		public virtual int WarrantyNumber {
			get => warrantyNumber;
			set => SetField(ref warrantyNumber, value);
		}

		public virtual string WarrantyFullNumber {
			get {
				if(contract == null)
					return "";
				if(additionalAgreementId == 0)
					return String.Format("{0}/Г-{1}", contract.Id, warrantyNumber);
				return String.Format("{0}/{1}-{2}/Г-{3}", contract.Id, AdditionalAgreementId.GetTypePrefix(additionalAgreement.Type), additionalAgreement.AgreementNumber, warrantyNumber);
			}
		}
		
		public static string GetTypePrefix(AgreementType type)
		{
			switch (type)
			{
				case AgreementType.DailyRent:
					return "АС";
				case AgreementType.NonfreeRent:
					return "АМ";
				case AgreementType.FreeRent:
					return "Б";
				case AgreementType.Repair:
					return "Т";
				case AgreementType.WaterSales:
					return "В";
				case AgreementType.EquipmentSales:
					return "П";
			}
		}
	}
}

