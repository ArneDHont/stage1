using AutoMapper;
using Inspect.Framework.Hypermedia;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http.Results;

namespace System.Web.Http
{
    public class HypermediaApiController : ApiController, IHypermediaController
    {
        private IHypermediaHandler mHypermediaHandler;

        private IMapper mMapper;

        public IHypermediaHandler Hypermedia
        {
            get
            {
                return mHypermediaHandler ?? (mHypermediaHandler = new WebApiHypermediaHandler());
            }
        }

        public IMapper Mapper
        {
            get
            {
                return mMapper ?? AutoMapper.Mapper.Instance;
            }
            set
            {
                mMapper = value;
            }
        }

        public virtual CollectionRepresentation<TRepresentation> CreateCollectionRepresentation<TRepresentation>(IEnumerable collection) where TRepresentation : Representation
        {
            var representations = Mapper.MapWithHypermedia<IEnumerable<TRepresentation>>(collection, Hypermedia);
            var collectionRepresentation = new CollectionRepresentation<TRepresentation>(representations);
            Hypermedia.ProcessRepresentation(collectionRepresentation);
            return collectionRepresentation;
        }

        public virtual CollectionRepresentation<TRepresentation> CreateCollectionRepresentation<TRepresentation>(IEnumerable collection, int totalCount, int? pageNumber, int? pageSize) where TRepresentation : Representation
        {
            var representations = Mapper.MapWithHypermedia<IEnumerable<TRepresentation>>(collection, Hypermedia);
            var collectionRepresentation = new CollectionRepresentation<TRepresentation>(representations, totalCount, pageNumber, pageSize);
            Hypermedia.ProcessRepresentation(collectionRepresentation);
            return collectionRepresentation;
        }

        public virtual TRepresentation CreateRepresentation<TRepresentation>(object source) where TRepresentation : Representation
        {
            return Mapper.MapWithHypermedia<TRepresentation>(source, Hypermedia);
        }

        protected internal virtual IHttpActionResult NoContent()
        {
            return ResponseMessage(Request.CreateResponse(HttpStatusCode.NoContent));
        }

        protected internal virtual OkNegotiatedContentResult<TRepresentation> Ok<TRepresentation>(object source) where TRepresentation : Representation
        {
            return Ok(CreateRepresentation<TRepresentation>(source));
        }

        protected internal virtual OkNegotiatedContentResult<CollectionRepresentation<TRepresentation>> Ok<TRepresentation>(IEnumerable source) where TRepresentation : Representation
        {
            return Ok(CreateCollectionRepresentation<TRepresentation>(source));
        }

        protected internal virtual OkNegotiatedContentResult<CollectionRepresentation<TRepresentation>> Ok<TRepresentation>(IEnumerable source, int totalCount, int? pageNumber, int? pageSize) where TRepresentation : Representation
        {
            return Ok(CreateCollectionRepresentation<TRepresentation>(source, totalCount, pageNumber, pageSize));
        }

        protected internal virtual IHttpActionResult Options(OptionsRepresentation result, params string[] allow)
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, result);
            // Don't know if there is a constant for the header
            response.Content.Headers.Add("Allow", allow);
            return ResponseMessage(response);
        }

        protected internal virtual IHttpActionResult Options(OptionsRepresentation result, params HttpMethod[] allow)
        {
            return Options(result, (allow ?? Enumerable.Empty<HttpMethod>()).Select(x => x.Method).ToArray());
        }

        protected internal virtual IHttpActionResult Options<TRepresentation>(object source, params string[] allow) where TRepresentation : Representation
        {
            TRepresentation representation = CreateRepresentation<TRepresentation>(source);
            OptionsRepresentation options = new OptionsRepresentation(representation);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, options);
            // Don't know if there is a constant for the header
            response.Content.Headers.Add("Allow", allow);
            return ResponseMessage(response);
        }

        protected internal virtual IHttpActionResult Options<TRepresentation>(object source, params HttpMethod[] allow) where TRepresentation : Representation
        {
            return Options<TRepresentation>(source, (allow ?? Enumerable.Empty<HttpMethod>()).Select(x => x.Method).ToArray());
        }
    }
}