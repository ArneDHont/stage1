using AutoMapper;
using Inspect.FireSafety.Shared;
using Inspect.FireSafety.WebApi.EquipmentFeedbacks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspect.FireSafety.WebApi.InspectionEquipmentFeedbacks
{
    public class EquipmentFeedbackMapperProfile : Profile
    {
        public  EquipmentFeedbackMapperProfile()
        {
            this.CreateHypermediaMap<InspectionEquipmentFeedback, InspectionEquipmentFeedbackRepresentation>();
            CreateMap<InspectionEquipmentFeedbackRepresentationForCreation, InspectionEquipmentFeedback>();
            this.CreateHypermediaMap<InspectionEquipmentFeedbackAttachment, InspectionEquipmentFeedbackAttachmentRepresentation>();
            CreateMap<InspectionEquipmentFeedbackAttachmentRepresentationForCreation, InspectionEquipmentFeedbackAttachment>();
        }
        
    }
}
