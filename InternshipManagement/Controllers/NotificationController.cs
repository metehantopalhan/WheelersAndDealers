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
        public async Task CreateNotification(CreateNotificationRequestDto requestDto)
        {
            await _spareParts.CreateNotification(requestDto);
        }
        [HttpGet]
        public async Task<GetPurchaseOrderByIdResponseDto> GetNotificationById(Guid id)
        {
            return await _spareParts.GetPurchaseOrderById(id);

        }

        [HttpPut]
        public async Task UpdatePurchaseOrder(UpdatePurchaseOrderRequestDto requestDto)
        {
            await _spareParts.UpdatePurchaseOrder(requestDto);
        }
    }
}
