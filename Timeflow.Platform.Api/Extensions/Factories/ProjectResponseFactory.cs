using Timeflow.Platform.Api.Boundary.Response;
using Timeflow.Platform.Middleware.Dto;

namespace Timeflow.Platform.Api.Extensions.Factories
{
    public static class ProjectResponseFactory
    {
        public static IList<ProjectResponseViewModel> ToResponse(this IList<ProjectDto> dto) 
        {
            return new List<ProjectResponseViewModel>() { new ProjectResponseViewModel() };
        }
    }
}
