using Inspect.FireSafety.Business.Persons;
using Inspect.FireSafety.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Inspect.FireSafety.WebApi.Users
{
    [RoutePrefix("fire-safety/users")]
    public class UserService : HypermediaApiController
    {
        private IUserBusinessComponent businessComponent;
        public IUserBusinessComponent BusinessComponent
        {
            get
            {
                return businessComponent ?? (businessComponent = new UserBusinessComponent());
            }
            set
            {
                businessComponent = value;
            }
        }

        public UserService()
        {
            this.IncludeHypermediaForUserCollectionRepresentation();
        }

        public UserService(IUserBusinessComponent businessComponent) : this()
        {
            this.businessComponent = businessComponent;
        }

        [HttpGet]
        [Route("",Name = nameof(UserCollectionGet))]
        public IHttpActionResult UserCollectionGet([FromUri]UserCollectionParameters parameters)
        {
            int totalCount = BusinessComponent.Count(new UserCollectionParametersSpecifications(parameters));
            IEnumerable<User> PersonsFromDataAccess = BusinessComponent.Get(new UserCollectionParamerssQuery(parameters));
            return Ok<UserRepresentation>(PersonsFromDataAccess, totalCount, parameters?.PageNumber, parameters?.PageSize);
        }

        [HttpGet]
        [Route("{employeenummer}", Name = nameof(UserGetByEmployeeNumber))]
        public IHttpActionResult UserGetByEmployeeNumber(string employeenummer)
        {
            var personFromDataAccess = BusinessComponent.SingleOrDefault(new UserParametersQuery(employeenummer));
            if (personFromDataAccess == null)
            {
                return NotFound();
            }
            return Ok<UserRepresentation>(personFromDataAccess);
        }

    }
}
