using Common;

namespace Domain
{
    public class Notification
    {
        private Notification()
        {

        }
        public Guid Id { get; private set; }
        public Guid DestinationPersonId { get; private set; }
        public Guid SourcePersonId { get; private set; }
        public string Description { get; private set; }
        public bool HasRead { get; private set; }
        public Notification(Guid destinationPersonId, Guid sourcePersonId, string description)
        {
            Id = Guid.NewGuid();
            DestinationPersonId = destinationPersonId;
            SourcePersonId = sourcePersonId;
            Description = description;

        }
        public void UpdateNotification(string description, bool hasRead)
        {
            Description = description;
            HasRead = hasRead;
        }
    }
}
