using Inspect.Mobile.Framework.Xamarin.Security;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inspect.FireSafety.Mobile.ControlRound.Models
{
    public class UserModel : IUser
    {
        public UserModel()
        {
        }

        public UserModel(IUser userModel)
        {
            this.Active = userModel.Active;
            this.BRDW = userModel.BRDW;
            this.EmployeeNumber = userModel.EmployeeNumber;
            this.FirstName = userModel.FirstName;
            this.LastName = userModel.LastName;
            this.Team = userModel.Team;
            this.UserId = userModel.UserId;
        }

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
