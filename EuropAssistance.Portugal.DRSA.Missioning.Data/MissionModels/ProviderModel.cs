using System;
using System.Collections.Generic;
using System.Text;

namespace EuropAssistance.Portugal.DRSA.Missioning.Models
{
    public class ProviderModel
    {
        public string type { get; set; }
        public string extId { get; set; }
        public string affiliate { get; set; }
        public string name { get; set; }
        public LocationModel location { get; set; }

    }
}
