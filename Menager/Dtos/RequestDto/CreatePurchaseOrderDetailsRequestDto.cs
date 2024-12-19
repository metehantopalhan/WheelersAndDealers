namespace Menager.Dtos.RequestDto
{
    public class CreatePurchaseOrderDetailsRequestDto
    {
        public int Quantity { get; set; }
        public double PurchaseOrderDetailPrice { get; set; }
        public Guid SupplierItemId { get; set; }

    }
}
