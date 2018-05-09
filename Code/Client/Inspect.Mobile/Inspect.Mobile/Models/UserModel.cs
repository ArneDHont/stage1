using Inspect.Mobile.Framework.Xamarin.Security;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inspect.Mobile.Models
{
    public class UserModel : IUser
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
