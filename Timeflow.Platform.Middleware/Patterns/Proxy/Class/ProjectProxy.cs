using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timeflow.Platform.Middleware.Dto;
using Timeflow.Platform.Middleware.Gateways;
using Timeflow.Platform.Middleware.Patterns.Proxy.Interface;

namespace Timeflow.Platform.Middleware.Patterns.Proxy.Class
{
    public class ProjectProxy : IProjectProxy
    {
        #region Properties
        private readonly ProjectApiGateway _projectApiGateway;
        #endregion

        public ProjectProxy(IServiceProvider provider) 
        {
            this._projectApiGateway = new ProjectApiGateway(provider);
        }

        public async Task<IList<ProjectDto>> GetByUserIdAsync(Guid userId) 
        {
            return await this._projectApiGateway.GetByUserIdAsync(userId);
        }
    }
}
