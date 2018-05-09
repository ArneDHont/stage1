using AutoMapper;
using Inspect.FireSafety.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspect.FireSafety.WebApi.Users
{
    public class UserMapperProfile : Profile
    {
        public UserMapperProfile()
        {
            this.CreateHypermediaMap<User,UserRepresentation>();
        }
    }
}
