using Newtonsoft.Json;

namespace Inspect.Framework.Hypermedia
{
    public class OptionsRepresentation : Representation
    {
        public OptionsRepresentation() : base()
        {

        }

        public OptionsRepresentation(Representation other)
        {
            Embedded = other.Embedded;
            Links = other.Links;
        }
    }
}