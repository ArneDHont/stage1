using Inspect.FireSafety.Data;
using Inspect.Framework.Business;
using Inspect.Framework.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspect.FireSafety.Business.Attachment
{
    public class AttachmentBusinessComponent : BusinessComponent, IAttachmentBusinessComponent
    {
        public AttachmentBusinessComponent() : base(DataAccessComponentFactory.Instance.Create())
        {
        }
    }
}
