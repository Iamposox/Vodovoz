using System.Data.Bindings.Collections.Generic;
using System.Linq;
using NSubstitute;
using NUnit.Framework;
using Vodovoz.Domain.Client;
using Vodovoz.Domain.Orders;
using Vodovoz.Domain.Orders.Documents;
using Vodovoz.Domain.Orders.Documents.TransportInvoice;

namespace VodovozBusinessTests.Updaters {
    [TestFixture]
    public class TransportInvoiceDocumentUpdaterTests {
        
        #region UpdateDocumentMethod
        
        [Test(Description = "Проверка метода UpdateDocument при добавлении в пустой список документов (ветка true)")]
        public void TestUpdateMethodIfNeedCreateDocumentOrderWithoutDocument()
        {
            // arrange
            TransportInvoiceDocumentFactory invoiceContractDocumentFactoryMock = Substitute.For<TransportInvoiceDocumentFactory>();
            TransportInvoiceDocumentUpdater invoiceContractDocumentUpdater = new TransportInvoiceDocumentUpdater(invoiceContractDocumentFactoryMock);
            Counterparty counterpartyMock = Substitute.For<Counterparty>();
            counterpartyMock.TTNCount.Returns(1);
            SelfDeliveryOrder selfDeliveryOrderMock = Substitute.For<SelfDeliveryOrder>();
            selfDeliveryOrderMock.Counterparty.Returns(counterpartyMock);
            OrderItem orderItemMock = Substitute.For<OrderItem>();
            orderItemMock.Sum.Returns(500);
            GenericObservableList<OrderDocument> observableDocuments = new GenericObservableList<OrderDocument>();
            selfDeliveryOrderMock.ObservableOrderDocuments.Returns(observableDocuments);
            GenericObservableList<OrderItem> observableItems = new GenericObservableList<OrderItem>();
            selfDeliveryOrderMock.ObservableOrderItems.Returns(observableItems);
            selfDeliveryOrderMock.ObservableOrderItems.Add(orderItemMock);
            
            // act
            invoiceContractDocumentUpdater.UpdateDocument(selfDeliveryOrderMock);
            
            // assert
            Assert.True(selfDeliveryOrderMock.ObservableOrderDocuments.Any(x => x.Type == OrderDocumentType.TransportInvoice));
        }
        
        [Test(Description = "Проверка метода UpdateDocument при добавлении дубликата документа (ветка true)")]
        public void TestUpdateMethodIfNeedCreateDocumentAndOrderWithOrderDocument()
        {
            // arrange
            TransportInvoiceDocumentFactory invoiceContractDocumentFactoryMock = Substitute.For<TransportInvoiceDocumentFactory>();
            TransportInvoiceDocumentUpdater invoiceContractDocumentUpdater = new TransportInvoiceDocumentUpdater(invoiceContractDocumentFactoryMock);
            Counterparty counterpartyMock = Substitute.For<Counterparty>();
            counterpartyMock.TTNCount.Returns(1);
            SelfDeliveryOrder selfDeliveryOrderMock = Substitute.For<SelfDeliveryOrder>();
            selfDeliveryOrderMock.Counterparty.Returns(counterpartyMock);
            TransportInvoiceDocument transportInvoiceDocumentMock = Substitute.For<TransportInvoiceDocument>();
            transportInvoiceDocumentMock.Type.Returns(OrderDocumentType.TransportInvoice);
            OrderItem orderItemMock = Substitute.For<OrderItem>();
            orderItemMock.Sum.Returns(500);
            GenericObservableList<OrderDocument> observableDocuments = new GenericObservableList<OrderDocument>();
            selfDeliveryOrderMock.ObservableOrderDocuments.Returns(observableDocuments);
            selfDeliveryOrderMock.ObservableOrderDocuments.Add(transportInvoiceDocumentMock);
            GenericObservableList<OrderItem> observableItems = new GenericObservableList<OrderItem>();
            selfDeliveryOrderMock.ObservableOrderItems.Returns(observableItems);
            selfDeliveryOrderMock.ObservableOrderItems.Add(orderItemMock);
            
            // act
            invoiceContractDocumentUpdater.UpdateDocument(selfDeliveryOrderMock);
            
            // assert
            Assert.AreEqual(1, selfDeliveryOrderMock.ObservableOrderDocuments.Count);
        }
        
        [Test(Description = "Проверка метода UpdateDocument (ветка false)")]
        public void TestUpdateMethodIfDoNotNeedCreateDocumentAndOrderWithOrderDocument()
        {
            // arrange
            TransportInvoiceDocumentFactory invoiceContractDocumentFactoryMock = Substitute.For<TransportInvoiceDocumentFactory>();
            TransportInvoiceDocumentUpdater invoiceContractDocumentUpdater = new TransportInvoiceDocumentUpdater(invoiceContractDocumentFactoryMock);
            SelfDeliveryOrder selfDeliveryOrderMock = Substitute.For<SelfDeliveryOrder>();
            TransportInvoiceDocument transportInvoiceDocumentMock = Substitute.For<TransportInvoiceDocument>();
            transportInvoiceDocumentMock.Type.Returns(OrderDocumentType.TransportInvoice);
            GenericObservableList<OrderDocument> observableDocuments = new GenericObservableList<OrderDocument>();
            selfDeliveryOrderMock.ObservableOrderDocuments.Returns(observableDocuments);
            selfDeliveryOrderMock.ObservableOrderDocuments.Add(transportInvoiceDocumentMock);
            
           // act
           invoiceContractDocumentUpdater.UpdateDocument(selfDeliveryOrderMock);
            
            // assert
            Assert.AreEqual(0, selfDeliveryOrderMock.ObservableOrderDocuments.Count);
        }
        
        #endregion

        #region AddExistingDocumentMethod

        [Test(Description = "Проверка метода AddExistingDocument без документов")]
        public void TestAddExistingDocumentMethodWithoutDocument()
        {
            // arrange
            TransportInvoiceDocumentFactory invoiceContractDocumentFactoryMock = Substitute.For<TransportInvoiceDocumentFactory>();
            TransportInvoiceDocumentUpdater invoiceContractDocumentUpdater = new TransportInvoiceDocumentUpdater(invoiceContractDocumentFactoryMock);
            SelfDeliveryOrder selfDeliveryOrderMock = Substitute.For<SelfDeliveryOrder>();
            TransportInvoiceDocument transportInvoiceDocumentMock = Substitute.For<TransportInvoiceDocument>();
            transportInvoiceDocumentMock.Type.Returns(OrderDocumentType.TransportInvoice);
            GenericObservableList<OrderDocument> observableDocuments = new GenericObservableList<OrderDocument>();
            selfDeliveryOrderMock.ObservableOrderDocuments.Returns(observableDocuments);
            
            // act
            invoiceContractDocumentUpdater.AddExistingDocument(selfDeliveryOrderMock, transportInvoiceDocumentMock);
            
            // assert
            Assert.True(selfDeliveryOrderMock.ObservableOrderDocuments.Any(x => x.Type == OrderDocumentType.TransportInvoice));
        }
        
        [Test(Description = "Проверка метода AddExistingDocument при добавлении дубликата документа")]
        public void TestAddExistingDocumentMethodAndOrderWithOrderDocument()
        {
            // arrange
            TransportInvoiceDocumentFactory invoiceContractDocumentFactoryMock = Substitute.For<TransportInvoiceDocumentFactory>();
            TransportInvoiceDocumentUpdater invoiceContractDocumentUpdater = new TransportInvoiceDocumentUpdater(invoiceContractDocumentFactoryMock);
            SelfDeliveryOrder selfDeliveryOrderMock = Substitute.For<SelfDeliveryOrder>();
            TransportInvoiceDocument transportInvoiceDocumentMock = Substitute.For<TransportInvoiceDocument>();
            transportInvoiceDocumentMock.Type.Returns(OrderDocumentType.TransportInvoice);
            TransportInvoiceDocument transportInvoiceDocumentMock2 = Substitute.For<TransportInvoiceDocument>();
            transportInvoiceDocumentMock2.Type.Returns(OrderDocumentType.TransportInvoice);
            GenericObservableList<OrderDocument> observableDocuments = new GenericObservableList<OrderDocument>();
            selfDeliveryOrderMock.ObservableOrderDocuments.Returns(observableDocuments);
            selfDeliveryOrderMock.ObservableOrderDocuments.Add(transportInvoiceDocumentMock);
            
            // act
            invoiceContractDocumentUpdater.AddExistingDocument(selfDeliveryOrderMock, transportInvoiceDocumentMock2);
            
            // assert
            Assert.AreEqual(1, selfDeliveryOrderMock.ObservableOrderDocuments.Count);
        }
        
        #endregion

        #region RemoveExistingDocumentMethod
        
        [Test(Description = "Проверка метода RemoveExistingDocument")]
        public void TestRemoveExistingDocumentMethodAndOrderWithOrderDocument()
        {
            // arrange
            TransportInvoiceDocumentFactory invoiceContractDocumentFactoryMock = Substitute.For<TransportInvoiceDocumentFactory>();
            TransportInvoiceDocumentUpdater invoiceContractDocumentUpdater = new TransportInvoiceDocumentUpdater(invoiceContractDocumentFactoryMock);
            SelfDeliveryOrder selfDeliveryOrderMock = Substitute.For<SelfDeliveryOrder>();
            TransportInvoiceDocument transportInvoiceDocumentMock = Substitute.For<TransportInvoiceDocument>();
            transportInvoiceDocumentMock.Type.Returns(OrderDocumentType.TransportInvoice);
            GenericObservableList<OrderDocument> observableDocuments = new GenericObservableList<OrderDocument>();
            selfDeliveryOrderMock.ObservableOrderDocuments.Returns(observableDocuments);
            selfDeliveryOrderMock.ObservableOrderDocuments.Add(transportInvoiceDocumentMock);
            
            // act
            invoiceContractDocumentUpdater.RemoveExistingDocument(selfDeliveryOrderMock, transportInvoiceDocumentMock);
            
            // assert
            Assert.AreEqual(0, selfDeliveryOrderMock.ObservableOrderDocuments.Count);
        }
        
        #endregion
    }
}