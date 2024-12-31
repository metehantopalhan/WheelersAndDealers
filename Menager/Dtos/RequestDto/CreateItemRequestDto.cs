namespace Menager.Dtos.RequestDto
{
    public class CreateItemRequestDto
    {
        public Guid UserId { get; set; }
        public string ItemName { get; set; }
        public int ItemTypeId { get; set; }
        public int CarBrandId { get; set; }
        public string ItemDescription { get; set; }
        public string ProductCode { get; set; }
        public string GuaranteeTime { get; set; }
        public string Category { get; set; }
        public string Origin { get; set; }
        public DateTime Year { get; set; }
    }
}
