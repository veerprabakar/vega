using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using vega.Controllers.Resources;
using vega.Models;
using vega.Persistence;
using vega.Models.Vehicle;

namespace vega.Controllers
{
    [Route("/api/vehicle")]
    public class VehicleController : Controller
    {
        private readonly VegaDbContext context;
        private IMapper mapper;
        
        public VehicleController(VegaDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateVehicle([FromBody]VehicleResource vehicleResource)
        {
            if( !ModelState.IsValid)
                return BadRequest(ModelState);

            // if(true)
            // {
            //     ModelState.AddModelError("...", "error");
            //     return BadRequest(ModelState);
            // }

            var vehicle = mapper.Map<VehicleResource, Vehicle>(vehicleResource);
            context.Vehicles.Add(vehicle);
            await context.SaveChangesAsync();           
            return Ok(mapper.Map<Vehicle, VehicleResource>(vehicle));
        }
    }
}