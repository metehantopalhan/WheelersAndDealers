using Menager;
using Menager.Dtos.RequestDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SpareParts.Controllers
{
    [Route("api/suppliers")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly ISpareParts _spareParts;
        public SupplierController(ISpareParts spareParts)
        {
            _spareParts = spareParts;
        }

        [HttpPut]
        public async Task UpdateSupplier(UpdateSuppplierRequestDto requestDto)
        {
            await _spareParts.UpdateSupplier(requestDto);
        }

        [HttpPost]
        public async Task CreateSupplier(CreateSupplierRequestDto requestDto)
        {
            await _spareParts.CreateSupplier(requestDto);
        }
        [HttpGet]
        public async Task<Guid?> LoginForSupplier(string email, string password)
        {
            return await _spareParts.LoginForSupplier(email, password);
        }
    }
}
