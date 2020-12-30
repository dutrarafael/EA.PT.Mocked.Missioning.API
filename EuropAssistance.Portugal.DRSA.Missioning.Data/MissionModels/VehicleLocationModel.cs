using System;
using System.Collections.Generic;
using System.Text;

namespace EuropAssistance.Portugal.DRSA.Missioning.Models
{
    public class VehicleLocationModel
    {
        public PositionModel position { get; set; }
        public AddressModel address { get; set; }
        public bool coveredGarage { get; set; }
        public bool highway { get; set; }
        public HighwayLocationModel highwayLocation { get; set; }
        public string message { get; set; }

    }
}
