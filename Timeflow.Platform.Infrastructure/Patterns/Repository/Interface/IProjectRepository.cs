using Timeflow.Platform.Infrastructure.Entities;

namespace Timeflow.Platform.Infrastructure.Patterns.Repository.Interface
{
    public interface IProjectRepository : IAsyncRepository<ProjectEntity>
    {
        public Task<IEnumerable<ProjectEntity>> GetAllProjectAsync(Guid userId);
    }
}
