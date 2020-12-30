using System.ComponentModel.DataAnnotations;

namespace EuropAssistance.Portugal.DRSA.Missioning.Models
{
    public class RequestMissioningModel
    {
        [Required]
        public int ClaimId { get; set; }
        public string ExtId { get; set; }
        [Required]
        public string MissionType { get; set; }
        public string RefundReason { get; set; }
        public string OrganisedBy { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public string Benefit { get; set; }
        public string BenefitReferenceCode { get; set; }
        public string MessageToProvider { get; set; }
        [Required]
        public string Service { get; set; }
        [Required]
        public bool UseAutoMissioning { get; set; }
        [Required]
        public CostModel Cost { get; set; }
        [Required]
        public PickupTimeModel PickupTime { get; set; }
        public DriverModel Driver { get; set; }
        public VehicleModel Vehicle { get; set; }
        public VehicleLocationModel VehicleLocation { get; set; }
        [Required]
        public ProductModel Product { get; set; }
        public EventModel MissionEvent { get; set; }
        [Required]
        public ProviderModel Provider { get; set; }
        public DistancesModel Distances { get; set; }
        [Required]
        public ServiceLimitsModel ServiceLimits { get; set; }
    }
}
