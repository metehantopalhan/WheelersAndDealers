using Menager;
using Menager.Dtos.RequestDto;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpareParts.Controllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PurchaseOrderController : ControllerBase
    {
        private readonly ISpareParts _spareparts;

        public PurchaseOrderController(ISpareParts spareParts)
        {
            _spareparts = spareParts;
        }

        [HttpPost]
        public async Task CreatePurchaseOrder(CreatePurchaseOrderRequestDto requestDto)
        {
            await _spareparts.CreatePurchaseOrder(requestDto);
        }


    }
}
