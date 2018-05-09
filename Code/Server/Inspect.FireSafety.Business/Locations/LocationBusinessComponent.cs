using Inspect.FireSafety.Data;
using Inspect.Framework.Business;

namespace Inspect.FireSafety.Business.Locations
{
    public class LocationBusinessComponent : BusinessComponent, ILocationBusinessComponent
    {
        public LocationBusinessComponent() : base(DataAccessComponentFactory.Instance.Create())
        {

        }
    }
}