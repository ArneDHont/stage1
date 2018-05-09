using AutoMapper;
using Inspect.FireSafety.Shared;

namespace Inspect.FireSafety.WebApi.EquipmentTypes
{
    public class EquipmentTypeMapperProfile : Profile
    {
        public EquipmentTypeMapperProfile()
        {
            this.CreateHypermediaMap<EquipmentType, EquipmentTypeRepresentation>();
        }
    }
}