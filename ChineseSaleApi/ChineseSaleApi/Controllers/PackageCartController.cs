    using Microsoft.AspNetCore.Mvc;
using ChineseSaleApi.Services;

namespace ChineseSaleApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PackageCartController : ControllerBase
    {
        private readonly PackageCartService _service;

        public PackageCartController(PackageCartService service)
        {
            _service = service;
        }
    }
}