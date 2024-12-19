using Common;

namespace Domain
{
    public class Notification
    {
        private Notification()
        {

        }
        public Guid Id { get; private set; }
        public Guid ResponsiblePersonId { get; private set; }
        public string Description { get; private set; }
        public UserType UserType { get; private set; }
        public int RelatedUserTypeId
        {
            get { return (int)this.UserType; }
            set { UserType = (UserType)value; }
        }
        public bool HasRead { get; private set; }
    }
}
