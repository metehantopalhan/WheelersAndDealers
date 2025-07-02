using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menager.Dtos.ResponseDto
{
    public class GetMessageListResponseDto
    {
        public Guid SenderUserId { get; set; }
        public Guid ReceiverUserId { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public string SenderUserName { get; set; }
    }
}
