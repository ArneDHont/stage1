using Newtonsoft.Json;
using System.Collections.Generic;

namespace Inspect.Framework.Hypermedia
{
    public class UnprocessableEntityRepresentation : Representation
    {
        [JsonIgnore]
        public IEnumerable<ValidationErrorRepresentation> Errors
        {
            get
            {
                return this.GetEmbeddedEnumerable<ValidationErrorRepresentation>(nameof(Errors));
            }
            set
            {
                this.Embed(nameof(Errors), value, replace: true);
            }
        }
    }
}