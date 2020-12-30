using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using EuropAssistance.Portugal.DRSA.Missioning.Models;
using Microsoft.AspNetCore.Http;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EuropAssistance.Portugal.DRSA.Missioning.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [ApiVersion("1")]
    public class MissionsController : ControllerBase
    {
        private readonly ILogger<MissionsController> _logger;

        public MissionsController(ILogger<MissionsController> logger)
        {
            _logger = logger;
        }

        #region V1

        [HttpPost]
        [Route("v1/{missionId}/cancellation")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        public void CancelMission(int missionId, [FromBody] RequestCancelMissionModel requestCancelMissionModel)
        {
            _logger.Log(LogLevel.Information, $"CancelMission: ID: {missionId},  Model: {requestCancelMissionModel}");
        }

        #endregion


        #region V2

        [HttpPost]
        [Route("v2/{missionId}/cancellation")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        public void CancelMissionV2(int missionId, [FromBody] RequestCancelMissionModel requestCancelMissionModel)
        {
            _logger.Log(LogLevel.Information, $"CancelMission: ID: {missionId},  Model: {requestCancelMissionModel}");
        }

        #endregion
    }
}
