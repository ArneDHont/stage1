using Inspect.Framework.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspect.FireSafety.Shared
{
    public class AttachmentBinary : IObjectWithState
    {
        public int AttachmentId { get; set; }

        public Attachment Attachment { get; set; }

        public byte[] Data { get; set; }

        public IDictionary<string, object> OriginalValues { get; set; }
        public ObjectState State { get; set; }
    }
}
