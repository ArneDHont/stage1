using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Inspect.Framework.Hypermedia
{
    public class NamedRelationCollection<TRelation> : KeyedCollection<string, NamedRelationEntry<TRelation>>
    {
        public static string NormalizeName(string name)
        {
            StringBuilder nameBuilder = new StringBuilder();
            char[] array = name.Trim('-').ToCharArray();

            for (int i = 0; i < array.Length; i++)
            {
                if ((char.IsUpper(array[i]) || array[i] == '-') && i != 0 && array[i - 1] != '-')
                {
                    nameBuilder.Append('-');
                }
                if (array[i] != '-')
                {
                    nameBuilder.Append(char.ToLowerInvariant(array[i]));
                }
            }
            return nameBuilder.ToString();
        }

        public void Add(string name, TRelation relation)
        {
            if (!EqualityComparer<TRelation>.Default.Equals(default(TRelation), relation))
            {
                string normalizedName = NormalizeName(name);
                if (this.Contains(normalizedName))
                {
                    this[normalizedName].Relations.Add(relation);
                }
                else
                {
                    NamedRelationEntry<TRelation> relationEntry = new NamedRelationEntry<TRelation>(normalizedName, relation);
                    this.Add(relationEntry);
                }
            }
        }

        public void AddRange(string name, TRelation[] relationArray)
        {
            if (!EqualityComparer<TRelation[]>.Default.Equals(default(TRelation[]), relationArray) && relationArray.Length > 0)
            {
                string normalizedName = NormalizeName(name);
                if (this.Contains(normalizedName))
                {
                    foreach (TRelation link in relationArray)
                    {
                        this[normalizedName].Relations.Add(link);
                    }
                }
                else
                {
                    NamedRelationEntry<TRelation> relation = new NamedRelationEntry<TRelation>(normalizedName, relationArray);
                    this.Add(relation);
                }
            }
        }

        public bool Contains(TRelation relation)
        {
            return this.Any(x => x.Relations.Any(l => ReferenceEquals(l, relation)));

        }

        public void Replace(string name, TRelation relation)
        {
            string normalizedName = NormalizeName(name);
            if (this.Contains(normalizedName))
            {
                this.Remove(normalizedName);
            }
            if (!EqualityComparer<TRelation>.Default.Equals(default(TRelation), relation))
            {
                NamedRelationEntry<TRelation> relationEntry = new NamedRelationEntry<TRelation>(normalizedName, relation);
                this.Add(relationEntry);
            }
        }

        public void ReplaceRange(string name, TRelation[] relationArray)
        {
            string normalizedName = NormalizeName(name);
            if (this.Contains(normalizedName))
            {
                this.Remove(normalizedName);
            }
            if (!EqualityComparer<TRelation[]>.Default.Equals(default(TRelation[]), relationArray) && relationArray.Length > 0)
            {
                NamedRelationEntry<TRelation> relationEntry = new NamedRelationEntry<TRelation>(normalizedName, relationArray);
                this.Add(relationEntry);
            }
        }

        public TRelation GetRelation(string name)
        {
            string normalizedName = NormalizeName(name);
            IEnumerable<TRelation> enumerable = Enumerable.Empty<TRelation>();
            if (this.Contains(normalizedName))
            {
                enumerable = this[normalizedName].Relations;
            }

            return Enumerable.SingleOrDefault(enumerable);
        }

        public IEnumerable<TRelation> GetRelationEnumerable(string name)
        {
            string normalizedName = NormalizeName(name);
            if (this.Contains(normalizedName))
            {
                return this[normalizedName].Relations;
            }
            else
            {
                return Enumerable.Empty<TRelation>();
            }
        }

        protected override string GetKeyForItem(NamedRelationEntry<TRelation> item)
        {
            return item.Name;
        }
    }
}