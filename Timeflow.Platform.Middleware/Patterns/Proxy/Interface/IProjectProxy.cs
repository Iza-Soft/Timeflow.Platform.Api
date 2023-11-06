using Timeflow.Platform.Middleware.Dto;

namespace Timeflow.Platform.Middleware.Patterns.Proxy.Interface
{
    public interface IProjectProxy
    {
        Task<IList<ProjectDto>> GetByUserIdAsync(Guid userId);
    }
}
