using Inspect.FireSafety.Data;
using Inspect.Framework.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspect.FireSafety.Business.FeedbackTypes
{
    public class FeedbackTypeBusinessComponent : BusinessComponent, IFeedbackTypeBusinessComponent 
    {
        public FeedbackTypeBusinessComponent() : base(DataAccessComponentFactory.Instance.Create())
        {
        }
    }
}
