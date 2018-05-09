using Inspect.FireSafety.Shared;
using Inspect.Framework.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspect.FireSafety.WebApi.Users
{
    public class UserCollectionParamerssQuery : IEntityQuery<User>
    {
        public UserCollectionParamerssQuery(UserCollectionParameters parameters = null)
        {
            Parameters = parameters;
        }

        public UserCollectionParameters Parameters { get; private set; }

        public IQueryable<User> Execute(IEntityQueryModel db)
        {
            var q = db.Queryable<User>();
            q = q.OrderBy(x => x.UserId);
            return q;
        }
    }
}
