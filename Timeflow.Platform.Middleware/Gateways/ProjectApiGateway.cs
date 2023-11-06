using Microsoft.Extensions.DependencyInjection;
using Timeflow.Platform.Infrastructure.Patterns.Repository.Interface;
using Timeflow.Platform.Infrastructure.Patterns.Repository.Class;
using Timeflow.Platform.Middleware.Dto;
using Timeflow.Platform.Middleware.Patterns.Proxy.Interface;
using Timeflow.Platform.Middleware.Extensions.Factories;

namespace Timeflow.Platform.Middleware.Gateways
{
    internal class ProjectApiGateway : IProjectProxy
    {
        private readonly IProjectRepository _projectRepository;

        public ProjectApiGateway(IServiceProvider provider)
        {
            using (IServiceScope scope = provider.CreateScope())
            {
                this._projectRepository = scope.ServiceProvider.GetRequiredService<ProjectRepository>();
            }
        }

        public async Task<IList<ProjectDto>> GetByUserIdAsync(Guid userId)
        {
            return (await this._projectRepository.GetAllProjectAsync(userId)).ToDto();
        }
    }
}
