using System;
using System.Collections.Generic;
using System.Text;

namespace Inspect.Mobile.Framework.Xamarin.Security
{
    public interface IUser
    {
        string EmployeeNumber { get; set; }

        string LastName { get; set; }

        string FirstName { get; set; }

        string Team { get; set; }
        bool Active { get; set; }

        bool BRDW { get; set; }
        string PLG_Mail { get; set; }

        int UserId { get; set; }
    }
}
