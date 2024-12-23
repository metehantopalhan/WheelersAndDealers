namespace Menager.Dtos.RequestDto
{
    public class UpdateNotificationRequestDto
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public bool HasRead { get; set; }
    }
}
