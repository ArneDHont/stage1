using Inspect.Framework.Hypermedia;
using Newtonsoft.Json;

namespace Inspect.FireSafety.WebApi.Equipment
{
    public class EquipmentLocationRepresentation : Representation
    {
        public string Code { get; set; }

        public string Description { get; set; }

        [JsonIgnore]
        public long EquipmentId { get; set; }

        [JsonIgnore]
        public LocationRepresentation Location
        {
            get
            {
                return GetEmbedded<LocationRepresentation>(nameof(Location));
            }
            set
            {
                Embed(nameof(Location), value, true);
            }
        }

        public int LocationId { get; set; }

        public string Name { get; set; }

        public string Number { get; set; }

        public int OrderNumber { get; set; }

        public string Suffix { get; set; }
    }
}