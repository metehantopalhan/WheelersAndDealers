using Common;

namespace Menager.Dtos.ResponseDto
{
    public class GetItemByIdResponseDto
    {
        public Guid Id { get; private set; }
        public Guid SellerUserId { get; set; }
        public string ItemName { get; set; }
        public double Price { get; set; }
        public int ItemBrandId
        {
            get; set;
        }

        public int ItemTypeId
        {
            get; set;
        }
        public bool IsActive { get; set; }
        public string ItemDescription { get; set; }
        public string? ImageName { get; set; }
        public byte[]? Data { get; set; }
        public string SearchText { get; set; }
        public int ItemModelId
        {
            get; set;
        }
    }
}
