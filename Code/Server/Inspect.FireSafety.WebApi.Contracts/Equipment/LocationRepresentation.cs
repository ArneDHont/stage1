using Inspect.Framework.Hypermedia;
using Newtonsoft.Json;

namespace Inspect.FireSafety.WebApi.Equipment
{
    public class LocationRepresentation : Representation
    {
        public string Name { get; set; }

        [JsonIgnore]
        public OrganisationUnitRepresentation OrganisationUnit
        {
            get
            {
                return GetEmbedded<OrganisationUnitRepresentation>(nameof(OrganisationUnit));
            }
            set
            {
                Embed(nameof(OrganisationUnit), value, true);
            }
        }

        public int OrganisationUnitId { get; set; }

        public int LocationId { get; set; }
    }
}