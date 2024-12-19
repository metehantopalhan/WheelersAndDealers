namespace Menager.Dtos.ResponseDto
{
    public class GetItemByIdResponseDto
    {
        public Guid Id { get; set; }
        public string ItemName { get; set; }
        public bool IsActive { get; set; }
        public int ItemTypeId { get; set; }
        public string ItemDescription { get; set; }
        public string StockCode { get; set; }
        public string GuaranteeTime { get; set; }
        public string? ImageName { get; set; }
        public byte[]? Data { get; set; }
        public string SearchText { get; set; }
        public List<SupplierItemListResponseDto> SupplierItemLists = new();
    }
}
