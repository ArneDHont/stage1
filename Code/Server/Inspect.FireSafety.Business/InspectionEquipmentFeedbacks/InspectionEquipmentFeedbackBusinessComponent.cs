using Inspect.FireSafety.Business.Equipment;
using Inspect.FireSafety.Data;
using Inspect.FireSafety.Shared;
using Inspect.Framework.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspect.FireSafety.Business.EquipmentFeedbacks
{
    public class InspectionEquipmentFeedbackBusinessComponent : BusinessComponent, IInspectionEquipmentFeedbackBusinessComponent
    {
        public InspectionEquipmentFeedbackBusinessComponent() : base(DataAccessComponentFactory.Instance.Create())
        {

        }

        public InspectionEquipmentFeedback Create(InspectionEquipmentFeedback entity)
        {
            Validate(entity);

            var equipment = SingleOrDefault<Shared.Equipment>(new EquipmentIdSpecification(entity.EquipmentId));
            equipment.DateVisualInspection = entity.TimeCompleted;
            equipment.Weight = entity.Weight;
            DataAccessComponent.Update(equipment);

            return DataAccessComponent.Create(entity);
        }

        public Shared.Attachment Create(Shared.Attachment entity)
        {
            Validate(entity);
            return DataAccessComponent.Create(entity);
        }

        public InspectionEquipmentFeedback Update(InspectionEquipmentFeedback entity)
        {
            Validate(entity);
            return DataAccessComponent.Update(entity);
        }
    }
}
