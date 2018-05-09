using Inspect.FireSafety.Data;
using Inspect.Framework.Business;

namespace Inspect.FireSafety.Business.EquipmentTypes
{
    public class EquipmentTypeBusinessComponent : BusinessComponent, IEquipmentTypeBusinessComponent
    {
        public EquipmentTypeBusinessComponent() : base(DataAccessComponentFactory.Instance.Create())
        {
        }
    }
}