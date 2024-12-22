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
        public async Task CreateSupplierItem(CreateSupplierItemRelationRequestDto requestDto)
        {
            await _spareParts.CreateItemSupplierRelation(requestDto);
        }
        [HttpPut]
        public async Task UpdateSupplierItem(UpdateSupplierItemRequestDto requestDto)
        {
            await _spareParts.UpdateSupplierItem(requestDto);
        }
        [HttpGet]
        public async Task<List<GetItemSuppliersWithItemIdResponseDto>> GetItemSuppliersWithItemId(Guid itemId)
        {
            return await _spareParts.GetItemSupplierByItemId(itemId);
        }
    }
}
