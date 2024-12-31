using Common;

namespace Domain
{
    public class PurchaseOrderDetail
    {
        private PurchaseOrderDetail()
        {

        }
        public Guid Id { get; private set; }
        public Guid ItemId { get; private set; }
        public Guid PurchaseOrderId { get; private set; }
        public PurchaseOrder PurchaseOrder { get; private set; }
        public Guid SupplierItemId { get; private set; }
        public SupplierItem SupplierItem { get; private set; }
        public int Quantity { get; private set; }
        public CargoStatus CargoStatus { get; private set; }
        public int CargoStatusId
        {
            get; private set;
        }
        public string? DestinationBranch { get; private set; }
        public string? CargoNumber { get; private set; }
        public double PurchaseOrderDetailPrice { get; private set; }
        public PurchaseOrderDetailStatus PurchaseOrderDetailStatus { get; private set; }
        public int PurchaseOrderDetailStatusId
        {
            get; private set;
        }
        internal PurchaseOrderDetail(Guid purchaseOrderId, Guid itemId, Guid supplierItemId, int quantity, double purchaseOrderDetailPrice)
        {
            Id = Guid.NewGuid();
            PurchaseOrderId = purchaseOrderId;
            ItemId = itemId;
            SupplierItemId = supplierItemId;
            Quantity = quantity;
            PurchaseOrderDetailStatusId = (int)PurchaseOrderDetailStatus.Pending;
            CargoStatusId = (int)CargoStatus.OrderTaken;
            PurchaseOrderDetailPrice = purchaseOrderDetailPrice;

        }
        public void UpdatePurchaseOrderDetail(int cargoStatusId, string destinationBranch, string cargoNumber, int purchaseOrderDetailStatusId)
        {
            CargoStatusId = cargoStatusId;
            DestinationBranch = destinationBranch;
            CargoNumber = cargoNumber;
            PurchaseOrderDetailStatusId = purchaseOrderDetailStatusId;
        }
    }
}
