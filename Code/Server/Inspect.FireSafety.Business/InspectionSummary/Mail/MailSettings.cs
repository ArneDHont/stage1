using Inspect.FireSafety.Business.InspectionSummary.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspect.FireSafety.Business.InspectionSummary.Mail
{
    public  class MailConfiguration : IMailConfiguration
    {
        public string From { get { return Properties.MailSettings.Default.From; } }

        public string SummeryTo { get { return Properties.MailSettings.Default.SummeryTo; } }

        public string Cc { get { return Properties.MailSettings.Default.Cc; } }
        public string ReportTo { get { return Properties.MailSettings.Default.ReportTo; } }
    }
}
