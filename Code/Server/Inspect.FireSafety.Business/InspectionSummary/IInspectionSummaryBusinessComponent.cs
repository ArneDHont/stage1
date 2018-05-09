using Inspect.Framework.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspect.FireSafety.Business.InspectionSummary
{
    public interface IInspectionSummaryBusinessComponent : IBusinessComponent, ICanCreate<Shared.InspectionSummary>, ICanNotify<Shared.InspectionSummary>
    {
        Mail.MailService MailService { get; set; }
    }
}
