using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace Timeflow.Platform.Api.Controllers.V2
{
    [ApiController]
    [ApiVersion("2.0")]
    [Produces("application/json")]
    [Route("api/{version:apiVersion}/test")]
    public class TestController : Controller
    {
        /// <summary>
        /// This API returns a list of all projects.
        /// </summary>
        /// <response code="200">Returns list of weather forecast</response>
        /// <response code="400">Noway, just for demonstration</response>
        [HttpGet]
        //public async Task<IActionResult> GetAll([FromBody] ProjectRequest project)
        public async Task<string> GetAllProjects()
        {
            return await Task.Run(() => "Test method call successful");

        }
    }
}