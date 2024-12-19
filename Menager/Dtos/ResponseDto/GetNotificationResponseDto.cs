namespace Menager.Dtos.ResponseDto
{
    public class GetNotificationResponseDto
    {
        public Guid Id { get; set; }
        public Guid ResponsiblePersonId { get; set; }
        public string Description { get; set; }
        public int RelatedUserTypeId { get; set; }
        public bool HasRead { get; set; }

    }
}
