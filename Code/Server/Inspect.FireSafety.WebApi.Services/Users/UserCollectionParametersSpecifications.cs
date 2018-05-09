using Inspect.FireSafety.Shared;
using Inspect.Framework.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Inspect.FireSafety.WebApi.Users
{
    public class UserCollectionParametersSpecifications : IEntitySpecification<User>
    {
        public UserCollectionParametersSpecifications(UserCollectionParameters parameters = null)
        {
            Parameters = parameters;
        }

        public UserCollectionParameters Parameters { get; private set; }

        public Expression<Func<User, bool>> ToExpression()
        {
            return EntitySpecification.Default<User>().ToExpression();
        }
    }
}
