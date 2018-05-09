using Inspect.FireSafety.WebApi.Locations;
using Inspect.Framework.Hypermedia;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Inspect.FireSafety.WebApi.OrganisationUnits
{
    public class OrganisationUnitRepresentation : Representation
    {
        public string Code { get; set; }

        [JsonIgnore]
        public IEnumerable<LocationRepresentation> Locations
        {
            get
            {
                return GetEmbeddedEnumerable<LocationRepresentation>(nameof(Locations));
            }
            set
            {
                Embed(nameof(Locations), value, true);
            }
        }

        public string Name { get; set; }

        public int OrganisationUnitId { get; set; }
    }
}