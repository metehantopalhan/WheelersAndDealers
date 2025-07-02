namespace Menager.Dtos.RequestDto
{
    public class CreateItemRequestDto
    {
        public Guid UserId { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public int ItemTypeId { get; set; }
        public int ItemBrandId { get; set; }
        public int Price { get; set; }
        public int ItemModelId { get; set; }
        public byte[] Data { get; set; }
    }
}
