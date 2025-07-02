namespace Menager.Dtos.ResponseDto
{
    public class GetItemByParametersResponseDto
    {
        public Guid Id { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public int ItemModelId { get; set; }
        public double Price { get; set; }
        public byte[] Data { get; set; }
    }
}
