using Inspect.FireSafety.Data;
using Inspect.FireSafety.Shared;
using Inspect.Framework.Business;
using Inspect.Framework.Data;
using Inspect.Mobile.Framework.Xamarin.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Inspect.FireSafety.Business.InspectionSummary.Mail;

namespace Inspect.FireSafety.Business.InspectionSummary
{
    public class InspectionSummaryBusinessComponent : BusinessComponent, IInspectionSummaryBusinessComponent
    {
               

        public MailService MailService { get ; set ; }

        private static readonly ILogger sLogger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public InspectionSummaryBusinessComponent() : base(DataAccessComponentFactory.Instance.Create())
        {
        }

        public Shared.InspectionSummary Create(Shared.InspectionSummary entity)
        {
            Validate(entity);
            return DataAccessComponent.Create(entity);
        }


        void ICanNotify<Shared.InspectionSummary>.Notify(Shared.InspectionSummary entity)
        {            
            MailService.SendMails(entity);
        }
       
    }
}
