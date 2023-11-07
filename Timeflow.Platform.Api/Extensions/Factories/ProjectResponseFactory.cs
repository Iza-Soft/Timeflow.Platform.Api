using Timeflow.Platform.Api.Boundary.Response;
using Timeflow.Platform.Infrastructure.Entities;
using Timeflow.Platform.Middleware.Dto;

namespace Timeflow.Platform.Api.Extensions.Factories
{
    public static class ProjectResponseFactory
    {
        public static IList<ProjectResponseViewModel> ToResult(this IList<ProjectDto> entities)
        {
            return entities.Select(ToResult).ToList();
        }

        public static ProjectResponseViewModel ToResult(this ProjectDto entity)
        {
            return new ProjectResponseViewModel() { Id = entity.Id, UserId = entity.UserId, Title = entity.Title, Description = entity.Description };
        }
    }
}
