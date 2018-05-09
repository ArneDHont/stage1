using Inspect.Framework.Hypermedia;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inspect.FireSafety.WebApi.FeedbackTypes
{
    public class FeedbackTypeRepresentation : Representation
    {
        public int FeedbackTypeId { get; set; }
        public string Description { get; set; }

    }
}
