using Microsoft.Extensions.Logging;
using EuropAssistance.Portugal.DRSA.Missioning.Service.Abstractions;
using EuropAssistance.Portugal.DRSA.Missioning.Models;
using System;

namespace EuropAssistance.Portugal.DRSA.Missioning.Service
{
    public class MissioningService : IMissioningService
    {
        private readonly ILogger<MissioningService> _logger;

        public MissioningService(ILogger<MissioningService> logger)
        {
            _logger = logger;
        }

        public ResponseMissioningModel UpsertMission(RequestMissioningModel missioningModel) => new ResponseMissioningModel()
        {
            extId = String.IsNullOrWhiteSpace(missioningModel.ExtId) ? Guid.NewGuid().ToString() : missioningModel.ExtId
        };

        public bool CancelMission(int missionId) => true;

        public ResponseProvidersModel GetProvider(int[] ids, string service) => new ResponseProvidersModel()
        {
            ExtId = Guid.NewGuid().ToString(),
            autoMissioning = false,
            Service = "TOW"
        };

    }
}
