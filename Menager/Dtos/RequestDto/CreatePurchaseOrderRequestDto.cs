namespace Menager.Dtos.RequestDto
{
    public class CreatePurchaseOrderRequestDto
    {
        public Guid UserId { get; set; }
        public double PurchaseOrderPrice { get; set; }
        public string TitleOfDestinationAddress { get; set; }
        public string TitleOfBill { get; set; }
        public string DestinationAddressDescription { get; set; }
        public string BillDescription { get; set; }
        public List<CreatePurchaseOrderDetailsRequestDto> PurchaseOrderDetailList = new();
        
    }
}
