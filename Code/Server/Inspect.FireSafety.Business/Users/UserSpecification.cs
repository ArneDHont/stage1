using Inspect.FireSafety.Shared;
using Inspect.Framework.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Inspect.FireSafety.Business.Persons
{
    public class UserSpecification : IEntitySpecification<User>
    {
        public UserSpecification(string employeNumber)
        {
            EmployeeNumber = employeNumber;
        }

        public string EmployeeNumber { get; private set; }

        public Expression<Func<User, bool>> ToExpression()
        {
            return x => (x.EmployeeNumber == EmployeeNumber);
        }
    }
}
