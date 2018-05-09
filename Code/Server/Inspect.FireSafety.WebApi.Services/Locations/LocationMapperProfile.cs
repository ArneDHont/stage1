using AutoMapper;
using Inspect.FireSafety.Shared;

namespace Inspect.FireSafety.WebApi.Locations
{
    public class LocationMapperProfile : Profile
    {
        public LocationMapperProfile()
        {
            this.CreateHypermediaMap<Location, LocationRepresentation>();
        }
    }
}