using System;
using System.Collections.Generic;

namespace Inspect.Framework.Hypermedia
{
    public class NamedRelationEntry<TRelation>
    {
        public string Name { get; private set; }

        public bool IsInitializedAsArray { get; private set; }

        public IList<TRelation> Relations { get; private set; }

        public NamedRelationEntry(string name, TRelation[] relations)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            this.IsInitializedAsArray = true;
            this.Name = name;
            this.Relations = new List<TRelation>(relations);
        }

        public NamedRelationEntry(string name, TRelation relation)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            this.IsInitializedAsArray = false;
            this.Name = name;
            this.Relations = new List<TRelation>(new[] { relation });
        }
    }
}