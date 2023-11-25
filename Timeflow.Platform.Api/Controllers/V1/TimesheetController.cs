using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Net;
using Timeflow.Platform.Api.Boundary.Request.Class;
using Timeflow.Platform.Api.Boundary.Response;
using Timeflow.Platform.Api.UseCase.Interface;

namespace Timeflow.Platform.Api.Controllers.V1
{
    [Authorize]
    [ApiController]
    [ApiVersion("1.0")]
    [Produces("application/json")]
    [Route("api/{version:apiVersion}/timesheet")]
    public class TimesheetController : Controller
    {
        private readonly IBaseUseCase<IList<TimesheetResponse>> _getWeeklyTimesheetByUserId;

        public TimesheetController(IBaseUseCase<IList<TimesheetResponse>> getWeeklyTimesheetByUserId)
        {
            this._getWeeklyTimesheetByUserId = getWeeklyTimesheetByUserId;
        }

        /// <summary>
        /// This API returns a list of all task by userId or userId and date.
        /// </summary>
        ///<response code="401">Unauthorized</response>
        ///<response code="404">Resourse can't be found</response>
        ///<response code="400">The request is not valid according to requirements</response>
        ///<response code="500">Internal server error</response>
        ///<response code="200">Returns list of project based on userId</response>
        [HttpGet]
        [ActionName("user-id")]
        [Route("user-id/{userId}/date/{date:datetime}")]
        [ProducesResponseType(typeof(BaseErrorResponse), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(BaseErrorResponse), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(BaseErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(BaseErrorResponse), StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(typeof(IList<ProjectResponse>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetWeeklyTimesheetByUserId([FromRoute] Guid userId, [FromRoute] DateTime date)
        {
            TimesheetQuery request = new() { UserId = userId, Date = date };

            var timesheetList = await this._getWeeklyTimesheetByUserId.ExecuteAsync(request).ConfigureAwait(false);

            if (timesheetList == null)
            {
                return NotFound(new BaseErrorResponse((int)HttpStatusCode.NotFound, "No list of timesheet could be found for the provided user ID and date"));
            }

            return Ok(timesheetList);
        }
    }
}
