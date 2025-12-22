using Microsoft.AspNetCore.Mvc;
using ChineseSaleApi.Services;
using ChineseSaleApi.Dto;

namespace ChineseSaleApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _service;

        public AddressController(IAddressService service)
        {
            _service = service;
        }
        //read
        [HttpGet]
        public async Task<IActionResult> GetAddressById(int id)
        {
            var address = await _service.GetAddressById(id);
            if (address == null)
            {
                return NotFound();
            }
            return Ok(address);
        }
        //create
        [HttpPost]
        [Route("user")]
        public async Task<IActionResult> AddAddressForUser([FromBody] CreateAddressForUserDto address)
        {
            await _service.AddAddressForUser(address);
            return CreatedAtAction(nameof(GetAddressById), address);
        }
        [HttpPost]
        [Route("donor")]
        public async Task<IActionResult> AddAddressForDonor([FromBody] CreateAddressForDonorDto address)
        {
            await _service.AddAddressForDonor(address);
            return CreatedAtAction(nameof(GetAddressById), address);
        }
        //update
    }
}