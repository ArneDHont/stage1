﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspect.FireSafety.WebApi.Contracts.Equipment
{
    public class EquipmentIdentificationRepresentation
    {
        public long EquipmentIdentificationId { get; set; }
        public long EquipmentId { get; set; }
        public string Value { get; set; }
    }
}
