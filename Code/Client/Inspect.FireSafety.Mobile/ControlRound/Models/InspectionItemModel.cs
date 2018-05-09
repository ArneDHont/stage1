using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Text;


namespace Inspect.FireSafety.Mobile.ControlRound.Models
{
    public class InspectionItemModel
    {
        public EquipmentModel Equipment { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }

        public string Code { get; set; }
        public string Comments { get; set; }

        public Color Color { get; set; } = Color.Gray;
        public StatusTypes Status { get; set; } = StatusTypes.Not_Inspected;

        public override string ToString()
        {
            return Equipment.EquipmentLocation.Name+" : " +Equipment.EquipmentType.Name;
        }


    }
}
