using Timeflow.Platform.Infrastructure.Entities;

namespace Timeflow.Platform.Infrastructure.Patterns.Repository.Interface
{
    public interface IProjectRepository : IAsyncRepository<ProjectEntity>
    {
        public Task<IList<ProjectEntity>> GetAllProjectAsync(Guid userId);
    }
}
