using Microsoft.Extensions.DependencyInjection;
using Timeflow.Platform.Infrastructure.Patterns.Repository.Interface;
using Timeflow.Platform.Middleware.Dto;
using Timeflow.Platform.Middleware.Patterns.Proxy.Interface;
using Timeflow.Platform.Middleware.Extensions.Factories;
using Timeflow.Platform.Middleware.Patterns.UnitOfWork.Interface;

namespace Timeflow.Platform.Middleware.Gateways
{
    internal class ProjectApiGateway : IProjectProxy
    {
        private readonly IUnitOfWork<IProjectRepository> _unitOfWork;

        public ProjectApiGateway(IServiceProvider provider)
        {
            IServiceScope scope = provider.CreateScope();

            this._unitOfWork = scope.ServiceProvider.GetRequiredService<IUnitOfWork<IProjectRepository>>();

            //this._projectRepository = scope.ServiceProvider.GetRequiredService<IProjectRepository>();

            //using (IServiceScope scope = provider.CreateScope())
            //{
            //    this._projectRepository = scope.ServiceProvider.GetRequiredService<IProjectRepository>();
            //}
        }

        public async Task<IList<ProjectDto>> GetByUserIdAsync(Guid userId)
        {
            var projects = await this._unitOfWork.Instance.GetAllProjectAsync(userId);

            return projects.ToResult();
        }
    }
}
