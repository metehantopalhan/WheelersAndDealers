using Menager;
using Menager.Dtos.RequestDto;
using Menager.Dtos.ResponseDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SpareParts.Controllers
{
    [Route("api/notifications")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly ISpareParts _spareParts;
        public NotificationController(ISpareParts spareParts)
        {
            _spareParts = spareParts;
        }

        [HttpPost]
        public async Task<IActionResult> CreateNotification(CreateNotificationRequestDto requestDto)
        {
            await _spareParts.CreateNotification(requestDto);
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetNotificationById(Guid id)
        {
            return Ok(await _spareParts.GetNotificationsById(id));

        }

        [HttpPut]
        public async Task<IActionResult> UpdateNotification(UpdateNotificationRequestDto requestDto)
        {
            await _spareParts.UpdateNotification(requestDto);
            return Ok();
        }


    }
}
