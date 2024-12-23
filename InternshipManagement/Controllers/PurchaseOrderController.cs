using Menager;
using Menager.Dtos.RequestDto;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpareParts.Controllers
{

    [Route("api/purchaseOrder")]
    [ApiController]
    public class PurchaseOrderController : ControllerBase
    {
        private readonly ISpareParts _spareParts;

        public PurchaseOrderController(ISpareParts spareParts)
        {
            _spareParts = spareParts;
        }

        [HttpPost]
        public async Task CreatePurchaseOrder(CreatePurchaseOrderRequestDto requestDto)
        {
            await _spareParts.CreatePurchaseOrder(requestDto);
        }

        [HttpGet]
        public async Task GetPurchaseOrderById(Guid id)
        {
            await _spareParts.GetNotificationsById(id);

        }

        [HttpPut]
        public async Task UpdateNotification(UpdateNotificationRequestDto requestDto)
        {
            await _spareParts.UpdateNotification(requestDto);
        }

    }
}
