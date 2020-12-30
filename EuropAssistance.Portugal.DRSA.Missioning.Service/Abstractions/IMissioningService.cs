using System;
using System.Collections.Generic;
using EuropAssistance.Portugal.DRSA.Missioning.Models;

namespace EuropAssistance.Portugal.DRSA.Missioning.Service.Abstractions
{
    public interface IMissioningService
    {
        ResponseMissioningModel UpsertMission(RequestMissioningModel missioningModel);
        bool CancelMission(int missionId);

        ResponseProvidersModel GetProvider(int[] ids, string service);

    }
}
