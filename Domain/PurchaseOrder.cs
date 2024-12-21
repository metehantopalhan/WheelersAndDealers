using Common;

namespace Domain
{
    public class PurchaseOrder
    {
        private PurchaseOrder()
        {

        }
        public Guid Id { get; private set; }
        public User User { get; private set; }
        public Guid UserId { get; private set; }
        public double PurchaseOrderPrice { get; private set; }
        public List<PurchaseOrderDetail> PurchaseOrderDetail = new();
        public DateTime PurchaseOrderDate { get; private set; }
        public string TitleOfDestinationAddress { get; private set; }
        public string TitleOfBill { get; private set; }
        public string DestinationAddressDescription { get; private set; }
        public string BillDescription { get; private set; }
        public PurchaseOrder(Guid userId, double purchaseOrderPrice, string titleOfDestinationAddress, string titleOfBill, string destinationAddressDescription, string billDescription)
        {
            Id = Guid.NewGuid();
            UserId = userId;
            PurchaseOrderPrice = purchaseOrderPrice;
            PurchaseOrderDate = DateTime.Now;
            TitleOfDestinationAddress = titleOfDestinationAddress;
            TitleOfBill = titleOfBill;
            DestinationAddressDescription = destinationAddressDescription;
        }
        public void AddPurchaseOrderDetail(Guid supplierItemId, Guid itemId, int quantity, double purchaseOrderDetailPrice)
        {
            PurchaseOrderDetail.Add(new PurchaseOrderDetail(Id, itemId, supplierItemId, quantity, purchaseOrderDetailPrice));
        }
    }
}
