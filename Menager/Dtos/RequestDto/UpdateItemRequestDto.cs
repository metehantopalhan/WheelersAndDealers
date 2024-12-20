namespace Menager.Dtos.RequestDto
{
    public class UpdateItemRequestDto
    {
        public Guid UserId { get; set; }
        public Guid ItemId { get; set; }
        public string ItemName { get; set; }
        public int ItemType { get; set; }
        public string ItemDescription { get; set; }
        public string ProductCode { get; set; }
        public string GuaranteeTime { get; set; }
        public bool IsActive {  get; set; }
    }
}
