using Microsoft.EntityFrameworkCore;

namespace Triathlon.Data
{
    public class TriathlonRaceTrackingContext : DbContext
    {
        public TriathlonRaceTrackingContext(DbContextOptions<TriathlonRaceTrackingContext> options) : base(options)
        {

        }

        public DbSet<Triathlon.Models.Race> Race { get; set; }

    }
}
