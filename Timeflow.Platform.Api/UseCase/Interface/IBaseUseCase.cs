using Timeflow.Platform.Api.Boundary.Request.Abstract;

namespace Timeflow.Platform.Api.UseCase.Interface
{
    public interface IBaseUseCase<T>
    {
        public Task<T> ExecuteAsync(RequestViewModel? request);
    }
}
