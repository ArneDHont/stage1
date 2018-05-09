using Inspect.Framework.Hypermedia;

namespace Inspect.FireSafety.WebApi.Equipment
{
    public class OrganisationUnitRepresentation : Representation
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public int OrganisationUnitId { get; set; }
    }
}