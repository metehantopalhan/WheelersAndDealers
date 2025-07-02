using Menager;
using Menager.Dtos.RequestDto;
using Menager.Dtos.ResponseDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SpareParts.Controllers
{
    [Route("api/items")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly ISpareParts _spareParts;
        public ItemController(ISpareParts spareParts)
        {
            _spareParts = spareParts;
        }

        [HttpPost]
        public async Task<IActionResult> CreateItem(CreateItemRequestDto requestDto)
        {
            var retval = await _spareParts.CreateItem(requestDto);
            if (retval.Item2)
            {
                return Ok(retval.Item1);
            }
            return UnprocessableEntity(retval.Item1);
        }
        [HttpGet("id")]
        public async Task<IActionResult> GetItemById(Guid id)
        {
            return Ok(await _spareParts.GetItemById(id));
        }

        [HttpGet("userId")]
        public async Task<IActionResult> GetItemListByUserId(Guid id)
        {
            return Ok(await _spareParts.GetItemListByUserId(id));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateItem(UpdateItemRequestDto requestDto)
        {
            var retval = await _spareParts.UpdateItem(requestDto);
            if (retval.Item2)
            {
                return Ok(retval.Item1);
            }
            return UnprocessableEntity(retval.Item1);
        }
        [HttpPost("parameters")]
        public async Task<IActionResult> GetItemByParameters(GetItemByParametersRequestDto requestDto)
        {
            return Ok(await _spareParts.GetItemByParameters(requestDto.SearchText, requestDto.IsActive, requestDto.Skip, requestDto.Take, requestDto.ItemType, requestDto.ItemModelId, requestDto.BrandId));
        }

    }
}
