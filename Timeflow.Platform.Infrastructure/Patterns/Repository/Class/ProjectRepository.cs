﻿using Microsoft.EntityFrameworkCore;
using Timeflow.Platform.Infrastructure.Entities;
using Timeflow.Platform.Infrastructure.Patterns.Repository.Abstract;
using Timeflow.Platform.Infrastructure.Patterns.Repository.Interface;
using Timeflow.Platform.Infrastructure.Specifications.Project;

namespace Timeflow.Platform.Infrastructure.Patterns.Repository.Class
{
    public class ProjectRepository : AsyncRepository<ProjectEntity>, IProjectRepository
    {
        public ProjectRepository(DbContext dataContext) : base(dataContext)
        {
        }

        public async Task<IList<ProjectEntity>> GetAllProjectAsync(Guid userId) => await ListAsync(new GetProjectSpec(userId));
    }
}
