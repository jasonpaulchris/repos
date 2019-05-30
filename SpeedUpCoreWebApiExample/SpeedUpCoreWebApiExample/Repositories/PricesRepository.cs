using Microsoft.EntityFrameworkCore;
using SpeedUpCoreWebApiExample.Contexts;
using SpeedUpCoreWebApiExample.Interfaces;
using SpeedUpCoreWebApiExample.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpeedUpCoreWebApiExample.Repositories
{
    public class PricesRepository : IPricesRepository
    {
        private readonly DefaultContext _context;

        public PricesRepository(DefaultContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Price>> GetPricesAsync(int productId)
        {
            return await _context.Prices.Where(p => p.ProductId == productId).ToListAsync();
        }
    }
}
