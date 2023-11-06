using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timeflow.Platform.Middleware.Dto;
using Timeflow.Platform.Middleware.Patterns.Proxy.Interface;

namespace Timeflow.Platform.Middleware.Gateways
{
    internal class ProjectApiGateway : IProjectProxy
    {
        public ProjectApiGateway(IServiceProvider provider)
        {
            using (IServiceScope scope = provider.CreateScope())
            {
                //this._externalAuthProvider = scope.ServiceProvider.GetRequiredService<ExternalAuthProvider>();
            }
        }

        public async Task<IList<ProjectDto>> GetByUserIdAsync()
        {
            return await Task.Run(() => new List<ProjectDto>() { new ProjectDto() });
        }
    }
}
