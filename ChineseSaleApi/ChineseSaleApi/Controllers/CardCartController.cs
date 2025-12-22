using Microsoft.AspNetCore.Mvc;
using ChineseSaleApi.Services;

namespace ChineseSaleApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CardCartController : ControllerBase
    {
        private readonly CardCartService _service;

        public CardCartController(CardCartService service)
        {
            _service = service;
        }
    }
}