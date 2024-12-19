namespace Menager.Dtos.RequestDto
{
    public class UpdateNotificationRequestDto
    {
        public string Description { get; set; }
        public int RelatedUserTypeId { get; set; }
        public bool HasRead { get; set; }
    }
}
