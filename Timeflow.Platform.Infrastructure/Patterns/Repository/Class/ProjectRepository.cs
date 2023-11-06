using Microsoft.EntityFrameworkCore;
using Timeflow.Platform.Infrastructure.Entities;
using Timeflow.Platform.Infrastructure.Patterns.Repository.Abstract;
using Timeflow.Platform.Infrastructure.Patterns.Repository.Interface;

namespace Timeflow.Platform.Infrastructure.Patterns.Repository.Class
{
    public class ProjectRepository : AsyncRepository<ProjectEntity>, IProjectRepository
    {
        public ProjectRepository(DbContext dataContext) : base(dataContext)
        {
        }

        public async Task<IEnumerable<ProjectEntity>> GetAllProjectAsync() => await base.GetAllAsync();
    }
}
