using Newtonsoft.Json;
using System;

namespace Inspect.Framework.Hypermedia
{
    [JsonObject]
    public class Link
    {
        [JsonConstructor]
        public Link()
        {

        }

        public Link(string href)
        {
            if (href == null)
            {
                throw new ArgumentNullException(nameof(href));
            }
            this.Href = href;
        }

        public Link(Uri href)
        {
            if (href == null)
            {
                throw new ArgumentNullException(nameof(href));
            }
            this.Href = href.ToString();
        }

        [JsonProperty("deprication")]
        public string Deprication { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("templated")]
        public bool Templated { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        public Uri AsUri(UriKind uriKind = UriKind.Relative)
        {
            return new Uri(this.Href, uriKind);
        }
    }
}