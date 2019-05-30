using Microsoft.AspNetCore.Mvc;
using SpeedUpCoreWebApiExample.Interfaces;
using System.Threading.Tasks;

namespace SpeedUpCoreWebApiExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PricesController : ControllerBase
    {
        private readonly IPricesService _pricesService;

        public PricesController(IPricesService pricesService)
        {
            _pricesService = pricesService;
        }

        //GET /api/prices/1
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPricesAsync(int id)
        {
            return await _pricesService.GetPricesAsync(id);
        }
    }
}
