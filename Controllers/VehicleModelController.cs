using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vega.Controllers.Resources;
using vega.Models;
using vega.Persistence;

namespace vega.Controllers
{
    public class VehicleModelController: Controller
    {
        private readonly VegaDbContext context;
        private IMapper mapper;
        
        public VehicleModelController(VegaDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet("/api/vehicleModel/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {
            var makes = await context.Makes.Include(m => m.Models)
                                .ToListAsync();
            return mapper.Map<List<Make>, List<MakeResource>>(makes);
        }

        [HttpGet("/api/vehicleModel/features")]
        public async Task<IEnumerable<FeatureResources>> GetFeatures()
        {
            var features = await context.Features.ToListAsync();
            return mapper.Map<List<Feature>, List<FeatureResources>>(features);
        }
    }
}