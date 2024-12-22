using Menager;
using Menager.Dtos.RequestDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SpareParts.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ISpareParts _spareParts;
        public UserController(ISpareParts spareParts)
        {
            _spareParts = spareParts;
        }
        [HttpGet]
        public async Task<Guid?> LoginForUser(string username, string password)
        {
            return await _spareParts.LoginForUser(username, password);
        }
        [HttpPost]
        public async Task CreateUser(CreateUserRequestDto requestDto)
        {
            await _spareParts.CreateUser(requestDto);
        }
        [HttpPut]
        public async Task UpdateUser(UpdateUserRequestDto requestDto)
        {
            await _spareParts.UpdateUser(requestDto);
        }

    }
}
