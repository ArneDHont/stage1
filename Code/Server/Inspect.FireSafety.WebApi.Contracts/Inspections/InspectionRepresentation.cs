using Inspect.FireSafety.WebApi.Equipment;
using Inspect.Framework.Hypermedia;
using Newtonsoft.Json;

namespace Inspect.FireSafety.WebApi.Inspections
{
    public class InspectionRepresentation : Representation
    {
        public string Description { get; set; }

        [JsonIgnore]
        public EquipmentRepresentation Equipment
        {
            get
            {
                return GetEmbedded<EquipmentRepresentation>(nameof(Equipment));
            }
            set
            {
                Embed(nameof(Equipment), value, true);
            }
        }

        public string Title { get; set; }
    }
}