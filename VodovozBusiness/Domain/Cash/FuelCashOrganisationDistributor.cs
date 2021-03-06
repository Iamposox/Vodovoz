using System;
using QS.DomainModel.UoW;
using Vodovoz.Domain.Documents;
using Vodovoz.Domain.Employees;
using Vodovoz.Domain.Logistic;
using Vodovoz.Domain.Operations;
using Vodovoz.Services;

namespace Vodovoz.Domain.Cash
{
    public class FuelCashOrganisationDistributor
    {
        private readonly ICashDistributionCommonOrganisationProvider cashDistributionCommonOrganisationProvider;

        public FuelCashOrganisationDistributor(ICashDistributionCommonOrganisationProvider cashDistributionCommonOrganisationProvider)
        {
            this.cashDistributionCommonOrganisationProvider =
                cashDistributionCommonOrganisationProvider ?? throw new ArgumentNullException(nameof(cashDistributionCommonOrganisationProvider));
        }

        public void DistributeCash(IUnitOfWork uow, FuelDocument fuelDoc)
        {
            var org = cashDistributionCommonOrganisationProvider.GetCommonOrganisation(uow);
            
            var operation = new OrganisationCashMovementOperation
            {
                Organisation = org,
                OperationTime = DateTime.Now,
                Amount = -fuelDoc.PayedForFuel.Value
            };
            
            var fuelCashDistributionDoc = new FuelExpenseCashDistributionDocument
            {
                Author = fuelDoc.Author,
                CreationDate = DateTime.Now,
                Organisation = org,
                FuelDocument = fuelDoc,
                Employee = fuelDoc.Driver,
                LastEditor = fuelDoc.LastEditor,
                LastEditedTime = DateTime.Now,
                Expense = fuelDoc.FuelCashExpense,
                OrganisationCashMovementOperation = operation,
                Amount = operation.Amount
            };
            
            Save(operation, fuelCashDistributionDoc, uow);
        }
        
        private void Save(OrganisationCashMovementOperation operation, FuelExpenseCashDistributionDocument document, IUnitOfWork uow)
        {
            uow.Save(operation);
            uow.Save(document);
        }
        
        public void UpdateRecords(IUnitOfWork uow, FuelExpenseCashDistributionDocument document, Expense expense, Employee editor)
        {
            UpdateFuelExpenseCashDistributionDocument(document, expense, editor);
            UpdateOrganisationCashMovementOperation(document.OrganisationCashMovementOperation, expense);
            Save(document.OrganisationCashMovementOperation, document, uow);
        }
        
        private void UpdateFuelExpenseCashDistributionDocument(FuelExpenseCashDistributionDocument doc, Expense expense, Employee editor)
        {
            doc.LastEditor = editor;
            doc.LastEditedTime = DateTime.Now;
            doc.Amount = -expense.Money;
        }

        private void UpdateOrganisationCashMovementOperation(OrganisationCashMovementOperation operation, Expense expense)
        {
            operation.Amount = -expense.Money;
            operation.OperationTime = DateTime.Now;
        }
    }
}