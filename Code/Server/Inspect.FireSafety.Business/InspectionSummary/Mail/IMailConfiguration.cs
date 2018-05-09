using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspect.FireSafety.Business.InspectionSummary.Mail
{
    public interface IMailConfiguration
    {
        string From { get; }

        string SummeryTo { get; }

        string Cc { get; }
        string ReportTo { get; }
    }
}
