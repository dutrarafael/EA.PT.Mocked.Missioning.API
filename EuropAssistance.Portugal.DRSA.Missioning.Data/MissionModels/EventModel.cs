using System;
using System.Collections.Generic;
using System.Text;

namespace EuropAssistance.Portugal.DRSA.Missioning.Models
{
    public class EventModel
    {
        public DateTime occurredAt { get; set; }
        public string code { get; set; }
        public int nbPersons { get; set; }
        public bool personWithSpecialNeeds { get; set; }
        public VehiclePositionModel vehiclePosition { get; set; }
        public string vehicleCondition { get; set; }
        public string circumstances { get; set; }

    }
}
