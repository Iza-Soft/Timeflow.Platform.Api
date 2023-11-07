using Timeflow.Platform.Api.Boundary.Request.Abstract;
using Timeflow.Platform.Api.Boundary.Response;
using Timeflow.Platform.Api.UseCase.Abstract;
using Timeflow.Platform.Middleware.Patterns.Proxy.Interface;
using Timeflow.Platform.Api.Extensions.Factories;
using Timeflow.Platform.Api.Boundary.Request.Class;

namespace Timeflow.Platform.Api.UseCase.Class
{
    public class GetProjectsByUserId : BaseUseCase<IList<ProjectResponseViewModel>>
    {
        private readonly IProjectProxy _projectProxy;

        public GetProjectsByUserId(IProjectProxy projectProxy)
        {
            this._projectProxy = projectProxy;
        }

        public override async Task<IList<ProjectResponseViewModel>> ExecuteAsync(RequestViewModel? request)
        {
            Guid userId = (request as ProjectRequestViewModel)!.UserId;

            var projects = await this._projectProxy.GetByUserIdAsync(userId);

            return projects.ToResult();
        }
    }
}
