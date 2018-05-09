using Inspect.Framework.Hypermedia;

namespace Inspect.FireSafety.WebApi.EquipmentTypes
{
    public class EquipmentTypeRepresentation : Representation
    {
        public int EquipmentTypeId { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }
    }
}