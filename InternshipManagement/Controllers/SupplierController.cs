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
        public async Task<IActionResult> UpdateSupplier(UpdateSuppplierRequestDto requestDto)
        {
            var retval = await _spareParts.UpdateSupplier(requestDto);
            if (retval.Item2)
            {
                return Ok(retval.Item1);
            }
            return UnprocessableEntity(retval.Item1);
        }

        [HttpPost]
        public async Task<IActionResult> CreateSupplier(CreateSupplierRequestDto requestDto)
        {
            var retval = await _spareParts.CreateSupplier(requestDto);
            if (retval.Item2)
            {
                return Ok(retval.Item1);
            }
            return UnprocessableEntity(retval.Item1);
        }
        [HttpGet]
        public async Task<IActionResult> LoginForSupplier(string email, string password)
        {
            return Ok(await _spareParts.LoginForSupplier(email, password));
        }
    }
}
