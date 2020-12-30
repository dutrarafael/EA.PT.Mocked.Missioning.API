using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using EuropAssistance.Portugal.DRSA.Missioning.Models;
using EuropAssistance.Portugal.DRSA.Missioning.Models.Base;
using EuropAssistance.Portugal.DRSA.Missioning.Service.Abstractions;
using System;
using Microsoft.AspNetCore.Http;
using System.Linq;

namespace EuropAssistance.Portugal.DRSA.Missioning.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [ApiVersion("1")]
    public class MissioningController : ControllerBase
    {

        private readonly ILogger<MissioningController> _logger;
        private readonly IMissioningService _missioningService;

        public MissioningController(ILogger<MissioningController> logger, IMissioningService missioningService)
        {
            _logger = logger;
            _missioningService = missioningService;
        }

        #region V1

        [HttpPost]
        [Route("v1/missions/{missionId}")]
        [ProducesResponseType(typeof(ResponseMissioningModel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpsertMission(int missionId, [FromBody] RequestMissioningModel requestModel)
        {
            _logger.Log(LogLevel.Information, $"Mission: {missionId},  {requestModel}");

            if (!ModelState.IsValid)
            {
                return BadRequest(new ResponseModel{
                    Messages = ModelState.SelectMany(mse => mse.Value?.Errors?.Select(me => me?.ErrorMessage))?.ToArray()
                });
            }

            return Ok(_missioningService.UpsertMission(requestModel));
        }

        [HttpGet]
        [Route("v1/providers/info")]
        [ProducesResponseType(typeof(ResponseProvidersModel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetProvider([FromQuery]int[] ext_ids, [FromQuery]string service)
        {
            _logger.Log(LogLevel.Information, $"Ids: {ext_ids},  Service: {service}");

            return Ok(_missioningService.GetProvider(ext_ids, service));
        }

        #endregion


        #region V2

        [HttpPost]
        [Route("v2/missions/{missionId}")]
        [ProducesResponseType(typeof(ResponseMissioningModel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpsertMissionV2(int missionId, [FromBody] RequestMissioningModel requestModel)
        {
            _logger.Log(LogLevel.Information, $"Mission: {missionId},  {requestModel}");

            if (!ModelState.IsValid)
            {
                return BadRequest(new ResponseModel
                {
                    Messages = ModelState.SelectMany(mse => mse.Value?.Errors?.Select(me => me?.ErrorMessage))?.ToArray()
                });
            }

            return Ok(_missioningService.UpsertMission(requestModel));
        }

        [HttpGet]
        [Route("v2/providers/info")]
        [ProducesResponseType(typeof(ResponseProvidersModel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetProviderV2([FromQuery] int[] ext_ids, [FromQuery] string service)
        {
            _logger.Log(LogLevel.Information, $"Ids: {ext_ids},  Service: {service}");

            return Ok(_missioningService.GetProvider(ext_ids, service));
        }

        #endregion

    }
}
