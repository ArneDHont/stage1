using Inspect.FireSafety.Shared;
using Inspect.Framework.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspect.FireSafety.Business.EquipmentFeedbacks
{
    public interface IInspectionEquipmentFeedbackBusinessComponent : IBusinessComponent, ICanCreate<InspectionEquipmentFeedback> , ICanCreate<Shared.Attachment>, ICanUpdate<InspectionEquipmentFeedback>
    {
    }
}
