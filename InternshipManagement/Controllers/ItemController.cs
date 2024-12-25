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
        [HttpGet]
        public async Task<IActionResult> GetItemByParameters(string? searchText, bool? isActive, int skip, int take)
        {
            return Ok(await _spareParts.GetItemByParameters(searchText, isActive, skip, take));
        }

    }
}
