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
        public string TitleOfBill{ get; private set; }
        public string DestinationAddressDescription { get; private set; }
        public string BillDescription { get; private set; }
    }
}
