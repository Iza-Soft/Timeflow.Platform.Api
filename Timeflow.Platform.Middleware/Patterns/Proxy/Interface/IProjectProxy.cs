using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timeflow.Platform.Middleware.Dto;

namespace Timeflow.Platform.Middleware.Patterns.Proxy.Interface
{
    public interface IProjectProxy
    {
        Task<IList<ProjectDto>> GetByUserIdAsync();
    }
}
