using Inspect.FireSafety.Business.Persons;
using Inspect.FireSafety.Shared;
using Inspect.Framework.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspect.FireSafety.WebApi.Users
{
    public class UserParametersQuery : IEntityQuery<User>
    {
        public UserParametersQuery(string employeNumber)
        {
            EmployeeNumber = employeNumber;
           
        }

        public string EmployeeNumber { get; private set; }
        

        public IQueryable<User> Execute(IEntityQueryModel db)
        {
            var q = db.Queryable<User>().Where(new UserSpecification(EmployeeNumber));
            return q;
        }
    }
}
