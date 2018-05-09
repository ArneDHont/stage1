using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Inspect.Framework.Hypermedia
{
    public class CollectionRepresentation<TRepresentation> : Representation
        where TRepresentation : Representation
    {
        public CollectionRepresentation()
        {
        }

        public CollectionRepresentation(IEnumerable<TRepresentation> elements)
        {
            if (elements != null)
            {
                this.Embed(nameof(Elements), elements);
                TotalCount = elements.Count();
            }
        }

        public CollectionRepresentation(IEnumerable<TRepresentation> elements, int totalCount, int? currentPage, int? pageSize) : this(elements)
        {
            if (elements != null)
            {
                this.Embed(nameof(Elements), elements);
            }

            TotalCount = totalCount;
            CurrentPage = currentPage;
            if (pageSize != null)
            {
                PageSize = pageSize;
                TotalPages = (int)Math.Ceiling(totalCount / (double)pageSize);
            }
        }

        public int? CurrentPage { get; set; }

        [JsonIgnore]
        public IEnumerable<TRepresentation> Elements
        {
            get
            {
                return this.GetEmbeddedEnumerable<TRepresentation>(nameof(Elements));
            }
        }

        public bool HasNext
        {
            get
            {
                return CurrentPage > TotalPages;
            }
        }

        public bool HasPrevious
        {
            get
            {
                return CurrentPage > 1;
            }
        }

        public int? PageSize { get; set; }

        public int TotalCount { get; set; }

        public int? TotalPages { get; set; }

        public void CopyFrom(CollectionRepresentation<TRepresentation> collection)
        {
            this.TotalCount = collection.TotalCount;
            this.CurrentPage = collection.CurrentPage;
            this.PageSize = collection.PageSize;
            this.TotalPages = collection.TotalPages;
            this.Embed(nameof(Elements), collection.Elements);
        }
    }
}