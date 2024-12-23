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
        public async Task CreateItem(CreateItemRequestDto requestDto)
        {
            await _spareParts.CreateItem(requestDto);
        }
        [HttpGet("id")]
        public async Task<GetItemByIdResponseDto> GetItemById(Guid id)
        {
            return await _spareParts.GetItemById(id);
        }
        [HttpPut]
        public async Task UpdateItem(UpdateItemRequestDto requestDto)
        {
            await _spareParts.UpdateItem(requestDto);
        }
        [HttpGet]
        public async Task<List<GetItemByParametersResponseDto>> GetItemByParameters(string? searchText, bool? isActive, int skip, int take)
        {
            return await _spareParts.GetItemByParameters(searchText, isActive, skip, take);
        }

    }
}
