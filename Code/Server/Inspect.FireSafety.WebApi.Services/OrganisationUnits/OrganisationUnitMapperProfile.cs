using AutoMapper;
using Inspect.FireSafety.Shared;

namespace Inspect.FireSafety.WebApi.OrganisationUnits
{
    public class OrganisationUnitMapperProfile : Profile
    {
        public OrganisationUnitMapperProfile()
        {
            this.CreateHypermediaMap<OrganisationUnit, OrganisationUnitRepresentation>();
        }
    }
}