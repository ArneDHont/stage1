using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspect.FireSafety.Shared
{
    public class User
    {
        public string EmployeeNumber { get; set; }
        public string LastName { get; set; }

        public string FirstName { get; set; }
        public string FullName {
            get{
                return FirstName +" "+ LastName;
            }
        } 
        public string Team { get; set; }
        public bool Active { get; set; }
        public bool BRDW { get; set; }
        public int UserId { get; set; }
        public string PLG_Mail { get; set; }



    }
}

