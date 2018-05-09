using Inspect.Framework.Hypermedia.Json;
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;

namespace Inspect.Framework.Hypermedia
{
    [JsonConverter(typeof(LinkCollectionJsonConverter))]
    public class LinkCollection : IEnumerable<NamedRelationEntry<Link>>
    {
        private NamedRelationCollection<Link> mRelationCollection = new NamedRelationCollection<Link>();

        public Link Self
        {
            get
            {
                return this.GetLink(nameof(Self));
            }
            set
            {
                this.Replace(nameof(Self), value);
            }
        }

        public int Count
        {
            get
            {
                return mRelationCollection.Count;
            }
        }

        public void Add(string rel, Link link)
        {
            mRelationCollection.Add(rel, link);
        }

        public void AddRange(string rel, Link[] linkArray)
        {
            mRelationCollection.AddRange(rel, linkArray);
        }

        public void Clear()
        {
            mRelationCollection.Clear();
        }

        public bool Contains(Link link)
        {
            return mRelationCollection.Contains(link);
        }

        public bool ContainsRelation(string rel)
        {
            return mRelationCollection.Contains(rel);
        }

        public IEnumerator<NamedRelationEntry<Link>> GetEnumerator()
        {
            return mRelationCollection.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public Link GetLink(string relation)
        {
            return mRelationCollection.GetRelation(relation);
        }

        public IEnumerable<Link> GetLinkEnumerable(string relation)
        {
            return mRelationCollection.GetRelationEnumerable(relation);
        }

        public void Replace(string rel, Link link)
        {
            mRelationCollection.Replace(rel, link);
        }

        public void ReplaceRange(string rel, Link[] linkArray)
        {
            mRelationCollection.ReplaceRange(rel, linkArray);
        }
    }
}