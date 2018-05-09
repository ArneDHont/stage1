using Inspect.Framework.Hypermedia;
using System;
using System.Collections.Generic;
using System.Text;
 

namespace Inspect.FireSafety.WebApi.Users
{
    public class UserRepresentation :  Representation
    {
        public string EmployeeNumber { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public string Team { get; set; }

        public bool Active { get; set; }

        public bool BRDW { get; set; }

        public int UserId { get; set; }
        public string PLG_Mail { get; set; }
    }
}
