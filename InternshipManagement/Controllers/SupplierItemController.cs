using Menager;
using Menager.Dtos.RequestDto;
using Menager.Dtos.ResponseDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SpareParts.Controllers
{
    [Route("api/supplierItems")]
    [ApiController]
    public class SupplierItemController : ControllerBase
    {
        private readonly ISpareParts _spareParts;
        public SupplierItemController(ISpareParts spareParts)
        {
            _spareParts = spareParts;
        }
        [HttpPost]
        public async Task<IActionResult> CreateSupplierItem(CreateSupplierItemRelationRequestDto requestDto)
        {
            var retval = await _spareParts.CreateItemSupplierRelation(requestDto);
            if (retval.Item2)
            {
                return Ok(retval.Item1);
            }
            return UnprocessableEntity(retval.Item1);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateSupplierItem(UpdateSupplierItemRequestDto requestDto)
        {
            var retval = await _spareParts.UpdateSupplierItem(requestDto);

            if (retval.Item2)
            {
                return Ok(retval.Item1);
            }
            return UnprocessableEntity(retval.Item1);

        }
        [HttpGet]
        public async Task<IActionResult> GetItemSuppliersWithItemId(Guid itemId)
        {
            return Ok(await _spareParts.GetItemSupplierByItemId(itemId));
        }
    }
}
