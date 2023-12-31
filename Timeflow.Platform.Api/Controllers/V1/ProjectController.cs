﻿using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
    [Route("api/{version:apiVersion}/project")]
    public class ProjectController : Controller
    {
        private readonly IBaseUseCase<IList<ProjectResponse>> _getProjectsByUserId;

        public ProjectController(IBaseUseCase<IList<ProjectResponse>> getProjectsByUserId)
        {
            this._getProjectsByUserId = getProjectsByUserId;
        }

        /// <summary>
        /// This API returns a list of all projects by userId.
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
        public async Task<IActionResult> GetByUserId([FromRoute] Guid userId) {

            ProjectQuery request = new() { UserId = userId };

            var projectList = await this._getProjectsByUserId.ExecuteAsync(request).ConfigureAwait(false);

            if (projectList == null)
            {
                return NotFound(new BaseErrorResponse((int)HttpStatusCode.NotFound, "No list of projects could be found for the provided user ID"));
            }

            return Ok(projectList);
        }
    }
}
