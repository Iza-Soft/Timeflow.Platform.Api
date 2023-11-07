using Microsoft.Extensions.DependencyInjection;
using Timeflow.Platform.Infrastructure.Patterns.Repository.Interface;
using Timeflow.Platform.Infrastructure.Patterns.Repository.Class;
using Timeflow.Platform.Middleware.Dto;
using Timeflow.Platform.Middleware.Patterns.Proxy.Interface;
using Timeflow.Platform.Middleware.Extensions.Factories;
using Timeflow.Platform.Infrastructure.Entities;

namespace Timeflow.Platform.Middleware.Gateways
{
    internal class ProjectApiGateway : IProjectProxy
    {
        private readonly IProjectRepository _projectRepository;

        public ProjectApiGateway(IServiceProvider provider)
        {
            IServiceScope scope = provider.CreateScope();

            this._projectRepository = scope.ServiceProvider.GetRequiredService<IProjectRepository>();

            //using (IServiceScope scope = provider.CreateScope())
            //{
            //    this._projectRepository = scope.ServiceProvider.GetRequiredService<IProjectRepository>();
            //}
        }

        public async Task<IList<ProjectDto>> GetByUserIdAsync(Guid userId)
        {
            var projects = await this._projectRepository.GetAllProjectAsync(userId);

            return projects.ToResult();
        }
    }
}
