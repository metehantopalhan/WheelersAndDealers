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
        public async Task<IActionResult> CreatePurchaseOrder(CreatePurchaseOrderRequestDto requestDto)
        {
            var retval = await _spareParts.CreatePurchaseOrder(requestDto);
            if (retval.Item2)
            {
                return Ok(retval.Item1);
            }
            return UnprocessableEntity(retval.Item1);
        }

        [HttpGet]
        public async Task<IActionResult> GetPurchaseOrderById(Guid id)
        {
            await _spareParts.GetPurchaseOrderById(id);

            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdatePurchaseOrder(UpdatePurchaseOrderRequestDto requestDto)
        {
            var retval = await _spareParts.UpdatePurchaseOrder(requestDto);
            if (retval.Item2)
            {
                return Ok(retval.Item1);
            }
            return UnprocessableEntity(retval.Item1);
        }

    }
}
