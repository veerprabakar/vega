using AutoMapper;
using vega.Controllers.Resources;
using vega.Models;
using vega.Models.Vehicle;

namespace vega.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeResource>();
            CreateMap<Model, ModelResource>();
            CreateMap<Feature, FeatureResources>();
            CreateMap<Vehicle, VehicleResource>();

            //API to domain
            CreateMap<VehicleResource, Vehicle>();
        }        
    }
}