using Inspect.Framework.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspect.FireSafety.Shared
{
    public class Attachment : IObjectWithState
    {
        public int AttachmentId { get; set; }
        public string FileName { get; set; }
        public long Size { get; set; }
        public DateTime DateCreated { get; set; }
        public AttachmentBinary Binary { get; set; }

        public IDictionary<string, object> OriginalValues { get; set; }
        public ObjectState State { get; set; }

    }
}
