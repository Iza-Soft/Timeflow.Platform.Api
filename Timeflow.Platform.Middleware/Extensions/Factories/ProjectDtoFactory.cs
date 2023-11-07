using Timeflow.Platform.Infrastructure.Entities;
using Timeflow.Platform.Middleware.Dto;

namespace Timeflow.Platform.Middleware.Extensions.Factories
{
    public static class ProjectDtoFactory
    {
        public static IList<ProjectDto> ToResult(this IList<ProjectEntity> entities) 
        {
            return entities.Select(ToResult).ToList();
        }

        public static ProjectDto ToResult(this ProjectEntity entity) 
        {
            return new ProjectDto() { Id = entity.Id, UserId = entity.UserId, Title = entity.Title, Description = entity.Description, CreatedBy = entity.CreatedBy, CreatedDate = entity.CreatedDate };
        }
    }
}
