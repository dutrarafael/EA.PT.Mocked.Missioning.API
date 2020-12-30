using System;
using System.Collections.Generic;
using System.Text;

namespace EuropAssistance.Portugal.DRSA.Missioning.Models
{
    public class RequestCancelMissionModel
    {
        public string reasonCode { get; set; }
        public bool withCost { get; set; }

    }
}
