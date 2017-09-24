using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using vega.Controllers.Resources;
using vega.Models;
using vega.Core;
using vega.Models.Vehicle;
using System;

namespace vega.Controllers
{
    [Route("/api/vehicle")]
    public class VehicleController : Controller
    {
        private readonly IVehicleRepository repository;
        private IMapper mapper;
        
        public VehicleController(IVehicleRepository vehicleRepo, IMapper mapper)
        {
            this.repository = vehicleRepo;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateVehicle
        ([FromBody]VehicleResource vehicleResource)
        {
            throw new Exception();
            if( !ModelState.IsValid )
                return BadRequest(null);
                
            var vehicle = mapper.Map<VehicleResource, Vehicle>(vehicleResource);
            var retvehicle = await repository.AddVehicle(vehicle);
            return Ok(mapper.Map<Vehicle, VehicleResource>(retvehicle));
        }

        [HttpGet]
        public async Task<IEnumerable<Vehicle>> GetVehicle() => await repository.GetVehicle();
    }
}