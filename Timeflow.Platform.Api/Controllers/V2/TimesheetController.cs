using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Timeflow.Platform.Api.Boundary.Request.Class;
using Timeflow.Platform.Api.Boundary.Response;

namespace Timeflow.Platform.Api.Controllers.V2
{
    [ApiController]
    [ApiVersion("2.0")]
    [Produces("application/json")]
    [Route("api/{version:apiVersion}/timesheet")]
    public class TimesheetController : Controller
    {
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
        [Route("user-id/{userId}")]
        [ProducesResponseType(typeof(BaseErrorResponse), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(BaseErrorResponse), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(BaseErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(BaseErrorResponse), StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(typeof(IList<ProjectResponse>), StatusCodes.Status200OK)]
        public IActionResult GetByUserId([FromRoute] TimesheetRequestViewModelV2 model)
        {
            return View();
        }
    }
}