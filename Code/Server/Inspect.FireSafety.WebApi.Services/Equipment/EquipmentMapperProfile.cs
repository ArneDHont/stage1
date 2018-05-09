using AutoMapper;
using Inspect.FireSafety.Shared;
using Inspect.FireSafety.WebApi.Contracts.Equipment;
using Inspect.FireSafety.WebApi.FeedbackTypes;
using Inspect.FireSafety.WebApi.Users;

namespace Inspect.FireSafety.WebApi.Equipment
{
    public class EquipmentMapperProfile : Profile
    {
        public EquipmentMapperProfile()
        {
            this.CreateHypermediaMap<Shared.Equipment, EquipmentRepresentation>();
            this.CreateHypermediaMap<EquipmentLocation, EquipmentLocationRepresentation>();
            this.CreateHypermediaMap<Location, LocationRepresentation>();
            this.CreateHypermediaMap<OrganisationUnit, OrganisationUnitRepresentation>();
            this.CreateHypermediaMap<User, UserRepresentation>();
            this.CreateHypermediaMap<FeedbackType, FeedbackTypeRepresentation>();
            this.CreateHypermediaMap<EquipmentIdentification, EquipmentIdentificationRepresentation>();
        }
    }
}