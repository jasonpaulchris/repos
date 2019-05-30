using Microsoft.AspNetCore.Mvc;
using SpeedUpCoreWebApiExample.Interfaces;
using System.Threading.Tasks;

namespace SpeedUpCoreWebApiExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly IProductsServices _productsService;

        public ProductsController(IProductsServices productsServices)
        {
            _productsService = productsServices;
        }

        //GET /api/products
        [HttpGet]
        public async Task<IActionResult> GetAllProductsAsync()
        {
            return await _productsService.GetAllProductsAsync();
        }

        //GET /api/products/5
        [HttpGet("id")]
        public async Task<IActionResult> GetProductAsync(int id)
        {
            return await _productsService.GetProductAsync(id);
        }

        //GET /api/products/find
        [HttpGet("find/{sku}")]
        public async Task<IActionResult> FindProductsAsync(string sku)
        {
            return await _productsService.FindProductsAsync(sku);
        }

        //DELETE /api/products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductAsync(int id)
        {
            return await _productsService.DeleteProductAsync(id);
        }
    }
}