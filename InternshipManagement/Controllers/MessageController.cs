using Menager;
using Menager.Dtos.RequestDto;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace SpareParts.Controllers
{
    [Route("api/messages")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly ISpareParts _spareParts;

        public MessageController(ISpareParts spareParts)
        {
            _spareParts = spareParts;
        }

        [HttpGet]
        public async Task<IActionResult> GetMessageList(Guid senderUserId, Guid receiverUserId)
        {
            return Ok(await _spareParts.GetMessageList(senderUserId, receiverUserId));
        }

        [HttpGet("messages")]
        public async Task<IActionResult> GetMessageListForUser(Guid receiverUserId)
        {
            return Ok(await _spareParts.GetMessageListForUser(receiverUserId));
        }

        [HttpPost]
        public async Task<IActionResult> CreateMessage(CreateMessageRequestDto requestDto)
        {
            await _spareParts.CreateMessage(requestDto);
            return Ok();
        }
    }
}
