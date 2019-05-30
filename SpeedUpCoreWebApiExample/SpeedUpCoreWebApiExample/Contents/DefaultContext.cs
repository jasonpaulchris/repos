using Microsoft.EntityFrameworkCore;
using SpeedUpCoreWebApiExample.Models;

namespace SpeedUpCoreWebApiExample.Contexts
{
    public class DefaultContext : DbContext
    {
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Price> Prices { get; set; }

        public DefaultContext(DbContextOptions<DefaultContext> options) : base(options)
        {

        }
    }
}
