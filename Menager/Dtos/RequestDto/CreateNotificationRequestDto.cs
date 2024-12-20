namespace Menager.Dtos.RequestDto
{
    public class CreateNotificationRequestDto
    {
        public Guid UserId { get; set; }
        public Guid DestinatonPersonId { get; set; }
        public string Description { get; set; }
        public int RelatedUserTypeId {  get; set; }
    }
}
