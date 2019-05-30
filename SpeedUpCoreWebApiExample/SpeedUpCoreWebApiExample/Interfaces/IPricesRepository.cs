using SpeedUpCoreWebApiExample.Models;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace SpeedUpCoreWebApiExample.Interfaces
{
    public interface IPricesRepository
    {
        Task<IEnumerable<Price>> GetPricesAsync(int productId);
    }
}
