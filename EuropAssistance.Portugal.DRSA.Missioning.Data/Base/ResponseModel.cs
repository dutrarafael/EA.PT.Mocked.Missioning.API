using System;
using System.Collections.Generic;
using System.Text;

namespace EuropAssistance.Portugal.DRSA.Missioning.Models.Base
{
    public class ResponseModel
    {
        public bool Success { get; set; }
        public Guid CorrelationId { get; set; }
        public string[] Messages { get; set; }
    }
}
