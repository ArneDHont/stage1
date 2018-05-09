using AutoMapper;
using Inspect.FireSafety.WebApi.Contracts.InspectionSummary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspect.FireSafety.WebApi.InspectionSummary
{
    public class InspectionSummaryMapperProfile : Profile
    {
        public InspectionSummaryMapperProfile()
        {
            this.CreateHypermediaMap<Shared.InspectionSummary, InspectionSummaryRepresentation>();
            CreateMap<InspectionSummaryRepresentationForCreation, Shared.InspectionSummary>();
        }
    }
}
