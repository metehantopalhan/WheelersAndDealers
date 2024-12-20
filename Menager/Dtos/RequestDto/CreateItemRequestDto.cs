namespace Menager.Dtos.RequestDto
{
    public class CreateItemRequestDto
    {
        public Guid UserId { get; set; }
        public string ItemName { get; set; }
        public int ItemType { get; set; }
        public string ItemDescription { get; set; }
        public string ProductCode { get; set; }
        public string GuaranteeTime { get; set; }
    }
}
