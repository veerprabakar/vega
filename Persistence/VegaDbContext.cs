using Microsoft.EntityFrameworkCore;
using vega.Models;
using vega.Models.Vehicle;

namespace vega.Persistence
{
    public class VegaDbContext: DbContext
    {
        public DbSet<Make> Makes { get; set; }
        public DbSet<Feature> Features { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }

        public VegaDbContext(DbContextOptions<VegaDbContext> options): base(options)
        {
            
        }
    }
}