using System;
using System.Collections.Generic;
using System.Text;

namespace Inspect.FireSafety.Mobile.ControlRound.Models
{
    public class ControlRoundSellectedMessage
    {
        public int OrganisationUnitId { get; set; }
        public int LocationId { get; set; }
        public DateTime SelectedDate { get; set; }

        public ControlRoundSellectedMessage(int organisationUnitId, int locationId, DateTime selectedDate)
        {
            OrganisationUnitId = organisationUnitId;
            LocationId = locationId;
            SelectedDate = selectedDate;
        }


    }
}
