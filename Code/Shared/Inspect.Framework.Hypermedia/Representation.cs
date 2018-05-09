using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace Inspect.Framework.Hypermedia
{
    [JsonObject]
    public class Representation
    {
        public Representation()
        {
            Embedded = new EmbeddedRepresentationCollection();
            Links = new LinkCollection();
        }

        [JsonProperty("_embedded", Order = int.MinValue + 1)]
        public EmbeddedRepresentationCollection Embedded { get; protected set; }

        [JsonProperty("_links", Order = int.MinValue)]
        public LinkCollection Links { get; protected set; }

        public void Embed(string rel, Representation representation, bool replace = false)
        {
            if (replace)
            {
                this.Embedded.Replace(rel, representation);
            }
            else
            {
                if (!this.Embedded.Contains(representation))
                {
                    this.Embedded.Add(rel, representation);
                }
            }
        }

        public void Embed(string rel, Representation[] representationArray, bool replace = false)
        {
            if (replace)
            {
                this.Embedded.ReplaceRange(rel, representationArray);
            }
            else
            {
                var removedExisting = representationArray.Where(x => !this.Embedded.Contains(x)).ToArray();
                this.Embedded.AddRange(rel, removedExisting);
            }
        }

        public void Embed<TRepresentation>(string rel, IEnumerable<TRepresentation> collection, bool replace = false) where TRepresentation : Representation
        {
            TRepresentation[] representationArray = (collection ?? Enumerable.Empty<TRepresentation>()).ToArray();
            if (replace)
            {
                this.Embedded.ReplaceRange(rel, representationArray);
            }
            else
            {
                var removedExisting = representationArray.Where(x => !this.Embedded.Contains(x)).ToArray();
                this.Embedded.AddRange(rel, removedExisting);
            }
        }

        public Representation GetEmbedded(string rel)
        {
            return this.Embedded.GetEmbedded(rel);
        }

        public IEnumerable<Representation> GetEmbeddedEnumerable(string rel)
        {
            return this.Embedded.GetEmbeddedEnumerable(rel);
        }

        public IEnumerable<TRepresentation> GetEmbeddedEnumerable<TRepresentation>(string rel)
        {
            return this.Embedded.GetEmbeddedEnumerable(rel).Cast<TRepresentation>();
        }

        protected TRepresentation GetEmbedded<TRepresentation>(string rel) where TRepresentation : Representation
        {
            // TODO Check if cast is valid.
            return this.Embedded.GetEmbedded(rel) as TRepresentation;
        }

        public void Link(string rel, string href, bool replace = false)
        {
            if (replace)
            {
                this.Links.Replace(rel, new Link(href));
            }
            else
            {
                this.Links.Add(rel, new Link(href));
            }
        }

        public void Link(string rel, Link link, bool replace = false)
        {
            if (replace)
            {
                this.Links.Replace(rel, link);
            }
            else
            {
                if (!this.Links.Contains(link))
                {
                    this.Links.Add(rel, link);
                }
            }
        }

        public void Link(string rel, Link[] linkArray, bool replace = false)
        {
            if (replace)
            {
                this.Links.ReplaceRange(rel, linkArray);
            }
            else
            {
                var removedExisting = linkArray.Where(x => !this.Links.Contains(x)).ToArray();
                this.Links.AddRange(rel, removedExisting);
            }
        }

        public static Representation Empty()
        {
            return new Representation();
        }
    }
}