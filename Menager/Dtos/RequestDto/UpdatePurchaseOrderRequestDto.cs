namespace Menager.Dtos.RequestDto
{
    public class UpdatePurchaseOrderRequestDto
    {
        public Guid Id { get; set; }
        public List<UpdatePurchaseOrderDetailRequestDto> UpdatePurchaseOrderList { get; set; } = new();
    }
}
