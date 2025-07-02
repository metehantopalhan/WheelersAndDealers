using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Message
    {
        public Guid Id { get; set; }
        public Guid SenderUserId { get; set; }
        public Guid ReceiverUserId { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public Message(Guid senderUserId, Guid receiverUserId, string description)
        {
            Id = Guid.NewGuid();
            SenderUserId = senderUserId;
            ReceiverUserId = receiverUserId;
            Description = description;
            CreateDate = DateTime.Now;
        }
    }
}
