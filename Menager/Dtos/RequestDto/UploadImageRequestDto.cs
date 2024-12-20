namespace Menager.Dtos.RequestDto
{
    public class UploadImageRequestDto
    {
        public Guid Id { get; set; }
        public byte[]? ImageData { get; set; }
    }
}
