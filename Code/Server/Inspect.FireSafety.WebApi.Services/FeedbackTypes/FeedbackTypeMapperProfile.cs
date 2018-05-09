using AutoMapper;
using Inspect.FireSafety.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspect.FireSafety.WebApi.FeedbackTypes
{
    public class FeedbackTypeMapperProfile : Profile
    {
        public FeedbackTypeMapperProfile()
        {
            this.CreateHypermediaMap<FeedbackType,FeedbackTypeRepresentation>();
        }
    }
}
