using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using vega.Controllers.Resources;
using vega.Models;
using vega.Persistence;

namespace vega.Controllers
{
    public class VehicleController : Controller
    {
        private readonly VegaDbContext context;
        private IMapper mapper;

        public VehicleController(VegaDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet("/api/vehicle/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {
            var makes = await context.Makes.Include(m => m.Models)
                                .ToListAsync();
            return mapper.Map<List<Make>, List<MakeResource>>(makes);
        }

        [HttpGet("/api/vehicle/features")]
        public async Task<IEnumerable<MakeResource>> GetFeatures()
        {
            var makes = await context.Makes.Include(m => m.Models)
                                .ToListAsync();
            return mapper.Map<List<Make>, List<MakeResource>>(makes);
        }
    }
}