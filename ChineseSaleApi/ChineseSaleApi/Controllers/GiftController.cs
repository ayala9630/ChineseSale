using Microsoft.AspNetCore.Mvc;
using ChineseSaleApi.Services;

namespace ChineseSaleApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GiftController : ControllerBase
    {
        private readonly GiftService _service;

        public GiftController(GiftService service)
        {
            _service = service;
        }
    }
}