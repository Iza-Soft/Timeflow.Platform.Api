using Timeflow.Platform.Infrastructure.Entities;
using Timeflow.Platform.Middleware.Dto;

namespace Timeflow.Platform.Middleware.Extensions.Factories
{
    public static class ProjectDtoFactory
    {
        public static IList<ProjectDto> ToDto(this IEnumerable<ProjectEntity> entity)
        {
            return new List<ProjectDto>() { new ProjectDto() };
        }
    }
}
