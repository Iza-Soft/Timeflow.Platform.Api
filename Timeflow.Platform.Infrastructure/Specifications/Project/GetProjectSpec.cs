﻿using Timeflow.Platform.Infrastructure.Entities;
using Timeflow.Platform.Infrastructure.Specifications.Interface;

namespace Timeflow.Platform.Infrastructure.Specifications.Project
{
    internal class GetProjectSpec : BaseSpecification<ProjectEntity>
    {
        public GetProjectSpec(Guid userId) : base(x => x.UserId == userId) 
        {
            AddInclude(x => x.Tasks);
        }
    }
}
