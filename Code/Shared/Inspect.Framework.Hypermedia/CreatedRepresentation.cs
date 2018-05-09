using Newtonsoft.Json;

namespace Inspect.Framework.Hypermedia
{
    public class CreatedRepresentation : Representation
    {
        public CreatedRepresentation()
        {

        }

        public CreatedRepresentation(string location)
        {
            Location = new Link(location);
        }

        [JsonIgnore]
        public Link Location
        {
            get
            {
                return this.Links.GetLink(nameof(Location));
            }
            set
            {
                this.Links.Replace(nameof(Location), value);
            }
        }
    }
}