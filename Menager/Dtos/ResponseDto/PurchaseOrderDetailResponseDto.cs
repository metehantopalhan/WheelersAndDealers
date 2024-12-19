namespace Menager.Dtos.ResponseDto
{
    public class PurchaseOrderDetailResponseDto
    {
        public Guid Id { get; set; }
        public Guid PurchaseOrderId { get; set; }
        public Guid SupplierItemId { get; set; }
        public int Quantity { get; set; }
        public int CargoStatusId { get; set; }
        public string? DestinationBranch { get; set; }
        public string? CargoNumber { get; set; }
        public double PurchaseOrderDetailPrice { get; set; }
        public int PurchaseOrderDetailStatusId { get; set; }
    }
}
