using System;
using System.Collections.Generic;
using System.Text;

namespace EuropAssistance.Portugal.DRSA.Missioning.Models
{
    public class ExtraCostsModel
    {
        public string type { get; set; }
        public int quantity { get; set; }
        public UnitCostModel unitCost { get; set; }
        public string comment { get; set; }
        public string paidBy { get; set; }

    }
}
