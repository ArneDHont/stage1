using Inspect.FireSafety.Business.Equipment;
using Inspect.FireSafety.Data;
using Inspect.Framework.Business;
using System.Runtime.CompilerServices;

namespace Inspect.FireSafety.Business.Equipment
{
    public class EquipmentBusinessComponent : BusinessComponent, IEquipmentBusinessComponent
    {
        public EquipmentBusinessComponent() : base(DataAccessComponentFactory.Instance.Create())
        {
        }
    }
}