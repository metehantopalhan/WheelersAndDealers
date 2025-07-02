namespace Menager.Dtos.RequestDto
{
    public class CreateMessageRequestDto
    {
        public Guid SenderUserId { get; set; }
        public Guid ReceiverUserId { get; set; }
        public string Description { get; set; }
    }
}
