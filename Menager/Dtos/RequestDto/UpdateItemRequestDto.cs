namespace Menager.Dtos.RequestDto
{
    public class UpdateItemRequestDto
    {
        public Guid UserId { get; set; }
        public Guid ItemId { get; set; }
        public string ItemName { get; set; }
        public int ItemTypeId { get; set; }
        public int ItemBrandId { get; set; }
        public int ItemModelId { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int Price { get; set; }

    }
}
