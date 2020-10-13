using System.Linq;

namespace Vodovoz.Domain.Orders.Documents.OrderContract {
    public class OrderContractDocumentUpdater : OrderDocumentUpdaterBase {

        private readonly OrderContractDocumentFactory documentFactory;
        
        public override OrderDocumentType DocumentType => OrderDocumentType.Contract;

        public OrderContractDocumentUpdater(OrderContractDocumentFactory documentFactory) {
            this.documentFactory = documentFactory;
        }

        private OrderContract CreateNewDocument() {
            return documentFactory.Create();
        }

        private bool NeedCreateDocument(OrderBase order) {
            if (order.Contract != null)
                return true;

            return false;
        }
        
        public override void UpdateDocument(OrderBase order) {
            if (NeedCreateDocument(order)) {
                var contract =
                    order.ObservableOrderDocuments.OfType<OrderContract>().SingleOrDefault();
                
                if(contract == null)
                    AddDocument(order, CreateNewDocument());
                else if (contract.Contract.Id != order.Contract.Id)
                    contract.Contract = order.Contract;
            }
            else {
                var contract =
                    order.ObservableOrderDocuments.OfType<OrderContract>().SingleOrDefault();

                if (contract != null) {
                    RemoveDocument(order, contract);
                }
            }
        }

        public override void AddExistingDocument(OrderBase order, OrderDocument existingDocument) {
            AddDocument(order, existingDocument);
        }

        public override void RemoveExistingDocument(OrderBase order, OrderDocument existingDocument) {
            RemoveDocument(order, existingDocument);
        }
    }
}