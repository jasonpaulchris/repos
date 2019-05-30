using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace SpeedUpCoreWebApiExample.Interfaces
{
    public interface IPricesService
    {
        Task<IActionResult> GetPricesAsync(int productId);
    }
}
