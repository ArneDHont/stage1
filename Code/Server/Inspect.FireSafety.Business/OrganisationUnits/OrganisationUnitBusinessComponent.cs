using Inspect.FireSafety.Data;
using Inspect.Framework.Business;

namespace Inspect.FireSafety.Business.OrganisationUnits
{
    public class OrganisationUnitBusinessComponent : BusinessComponent, IOrganisationUnitBusinessComponent
    {
        public OrganisationUnitBusinessComponent() : base(DataAccessComponentFactory.Instance.Create())
        {
        }
    }
}