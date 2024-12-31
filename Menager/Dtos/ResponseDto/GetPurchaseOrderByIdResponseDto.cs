namespace Menager.Dtos.ResponseDto
{
    public class GetPurchaseOrderByIdResponseDto
    {
        public string TitleOfDestinationAddress { get; set; }
        public string TitleOfBill { get; set; }
        public string DestinationAddressDescription { get; set; }
        public string BillDescription { get; set; }
        public DateTime PurchaseOrderDate { get; set; }
        public List<PurchaseOrderDetailResponseDto> PurchaseOrderDetailList { get; set; } = new();

    }
}
