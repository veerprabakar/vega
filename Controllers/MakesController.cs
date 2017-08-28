using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vega.Controllers.Resources;
using vega.Models;
using vega.Persistence;

namespace vega.Controllers
{
    public class MakesController : Controller
    {
        private readonly VegaDbContext context;
        private IMapper mapper;

        public MakesController(VegaDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {
            var makes = await context.Makes.Include(m => m.Models)
                                .ToListAsync();
            return mapper.Map<List<Make>, List<MakeResource>>(makes);
        }

        // [HttpGet("/api/makes/id")]
        // public async Task<IEnumerable<MakeResource>> GetMakes(int id)
        // {
        //     var makes = await context.Makes
        //                         .Where( w => w.Id.Equals(id))
        //                         .Include(m => m.Models)
        //                         .ToListAsync();

        //     return mapper.Map<List<Make>, List<MakeResource>>(makes);
        // }
    }
}