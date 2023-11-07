using Timeflow.Platform.Api.Boundary.Request.Abstract;
using Timeflow.Platform.Api.UseCase.Interface;

namespace Timeflow.Platform.Api.UseCase.Abstract
{
    public abstract class BaseUseCase<T> : IBaseUseCase<T>
    {
        public abstract Task<T> ExecuteAsync(RequestViewModel? request);
    }
}
