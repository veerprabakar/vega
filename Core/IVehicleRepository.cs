using System.Collections.Generic;
using System.Threading.Tasks;
using vega.Models.Vehicle;

namespace vega.Core
{
    public interface IVehicleRepository
    {
         Task<IEnumerable<Vehicle>> GetVehicle();

         Task<Vehicle> AddVehicle(Vehicle vehicle);
    }
}