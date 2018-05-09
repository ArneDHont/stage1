using Inspect.FireSafety.Business.FeedbackTypes;
using Inspect.FireSafety.Shared;

using Inspect.Framework.Hypermedia;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
namespace Inspect.FireSafety.WebApi.FeedbackTypes
{
    [RoutePrefix("fire-safety/feedback-types")]
    public class FeedbackTypeService : HypermediaApiController
    {
        private IFeedbackTypeBusinessComponent businessComponent;

        public FeedbackTypeService()
        {            
            this.IncludeHypermediaForFeedbackTypeCollectionRepresentation();
        }

        public FeedbackTypeService(IFeedbackTypeBusinessComponent businessComponent) : this()
        {
            this.businessComponent = businessComponent;
        }

        public IFeedbackTypeBusinessComponent BusinessComponent
        {
            get
            {
                return businessComponent ?? (businessComponent = new FeedbackTypeBusinessComponent());
            }
            set
            {
                businessComponent = value;
            }
        }

        [HttpGet]
        [Route("", Name = nameof(FeedbackTypesCollectionGet))]
        public IHttpActionResult FeedbackTypesCollectionGet([FromUri]FeedbackTypeCollectionParameters parameters)
        {
            int totalCount = BusinessComponent.Count(new FeedbackTypeCollectionParametersSpecification(parameters));
            IEnumerable<FeedbackType> FeedBackTypesFromDataAccess = BusinessComponent.Get(new FeedbackTypeCollectionParametersQuery(parameters));
            return Ok<FeedbackTypeRepresentation>(FeedBackTypesFromDataAccess, totalCount, parameters?.PageNumber, parameters?.PageSize);
        }

        [HttpGet]
        [Route("{id}", Name = nameof(FeedbackTypesGetById))]
        public IHttpActionResult FeedbackTypesGetById(int id, [FromUri]FeedbackTypeParameters parameters)
        {
            var feedbackTypeFromDataAccess = BusinessComponent.SingleOrDefault(new FeedbackTypeParametersQuery(id, parameters));
            if (feedbackTypeFromDataAccess == null)
            {
                return NotFound();
            }
            return Ok<FeedbackTypeRepresentation>(feedbackTypeFromDataAccess);
        }

    }
}
