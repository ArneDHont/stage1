using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Inspect.FireSafety.WebApi.OrganisationUnits;
using System.Runtime.Serialization;

namespace Inspect.FireSafety.Mobile.ControlRound.Models
{
    public class OrganisationUnitModel
    {
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int OrganisationUnitId { get; set; }
    }
}
