using Microsoft.AspNetCore.Mvc;'[
using System.Threading.Tasks;

namespace SpeedUpCoreWebApiExample.Interfaces
{
    public interface IProductsServices
    {
        Task<IActionResult> GetAllProductsAsync();
        Task<IActionResult> GetProductAsync(int productId);
        Task<IActionResult> FindProductsAsync(string sku);
        Task<IActionResult> DeleteProductAsync(int productId);

    
}
