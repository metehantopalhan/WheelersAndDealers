namespace Menager.Dtos.RequestDto
{
    public class GetItemByParametersRequestDto
    {
        public string? SearchText { get; set; }
        public bool? IsActive { get; set; }
        public int Skip { get; set; }
        public int Take { get; set; }
        public int? ItemType { get; set; }
        public int? ItemModelId { get; set; }
        public int? BrandId { get; set; }
    }
}
