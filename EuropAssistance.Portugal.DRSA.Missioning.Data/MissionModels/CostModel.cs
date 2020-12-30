using System;
using System.Collections.Generic;
using System.Text;

namespace EuropAssistance.Portugal.DRSA.Missioning.Models
{
    public class CostModel
    {
        public ServiceCostModel serviceCost { get; set; }
        public IList<ExtraCostsModel> extraCosts { get; set; }
        public OvercostRootModel overcost { get; set; }

    }
}
