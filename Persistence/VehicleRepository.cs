using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using vega.Models.Vehicle;
using vega.Core;

namespace vega.Persistence
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly VegaDbContext context;

        public VehicleRepository(VegaDbContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<Vehicle>> GetVehicle()
        {
            return await context.Vehicles.ToListAsync();
        }

        public async Task<Vehicle> AddVehicle(Vehicle vehicle)
        {
            context.Vehicles.Add(vehicle);
            await context.SaveChangesAsync();   
            return vehicle;
        }
    }
}