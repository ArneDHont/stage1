using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspect.FireSafety.Shared
{
    public class FeedbackType
    {
        public int FeedbackTypeId { get; set; }
        public string Description { get; set; }

        public IList<EquipmentType> EquipmentTypes { get; set; }

    }
}
