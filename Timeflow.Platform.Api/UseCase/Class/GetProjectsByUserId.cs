using Timeflow.Platform.Api.Boundary.Request.Abstract;
using Timeflow.Platform.Api.Boundary.Response;
using Timeflow.Platform.Api.UseCase.Abstract;
using Timeflow.Platform.Middleware.Patterns.Proxy.Interface;
using Timeflow.Platform.Api.Extensions.Factories;

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
            //BaseRequest request = requestt as BaseRequest;
            return (await this._projectProxy.GetByUserIdAsync()).ToResponse();
        }
    }
}
