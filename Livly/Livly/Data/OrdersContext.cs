using Microsoft.EntityFrameworkCore;

namespace Livly.Data
{
    public class OrdersContext : DbContext
    {
        public OrdersContext(DbContextOptions<OrdersContext> options) : base(options) { }
        public OrdersContext() { }
        public DbSet<Orders> Orders
        {
            get; set;
        }
    }
}