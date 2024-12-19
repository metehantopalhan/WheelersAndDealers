namespace Menager.Dtos.RequestDto
{
    public class UpdateItemRequestDto
    {
        public string ItemName { get; set; }
        public int ItemType { get; set; }
        public string ItemDescription { get; set; }
        public string StockCode { get; set; }
        public bool IsActive {  get; set; }
    }
}
