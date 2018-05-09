using Inspect.Framework.Hypermedia.Json;
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;

namespace Inspect.Framework.Hypermedia
{
    [JsonConverter(typeof(EmbeddedRepresentationCollectionJsonConverter))]
    public class EmbeddedRepresentationCollection : IEnumerable<NamedRelationEntry<Representation>>
    {
        private NamedRelationCollection<Representation> mRelationCollection = new NamedRelationCollection<Representation>();

        public int Count
        {
            get
            {
                return mRelationCollection.Count;
            }
        }

        public void Add(string rel, Representation resource)
        {
            mRelationCollection.Add(rel, resource);
        }

        public void AddRange(string rel, Representation[] resourceArray)
        {
            mRelationCollection.AddRange(rel, resourceArray);
        }

        public void Clear()
        {
            mRelationCollection.Clear();
        }

        public bool Contains(Representation resource)
        {
            return mRelationCollection.Contains(resource);
        }

        public bool ContainsRelation(string relation)
        {
            return mRelationCollection.Contains(relation);
        }

        public IEnumerator<NamedRelationEntry<Representation>> GetEnumerator()
        {
            return mRelationCollection.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerable<Representation> GetEmbeddedEnumerable(string relation)
        {
            return mRelationCollection.GetRelationEnumerable(relation);
        }

        public void Replace(string rel, Representation representation)
        {
            mRelationCollection.Replace(rel, representation);
        }

        public void ReplaceRange(string rel, Representation[] representationArray)
        {
            mRelationCollection.ReplaceRange(rel, representationArray);
        }

        public Representation GetEmbedded(string relation)
        {
            return mRelationCollection.GetRelation(relation);
        }
    }
}