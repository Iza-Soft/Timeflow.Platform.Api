namespace Timeflow.Platform.Middleware.Patterns.UnitOfWork.Interface
{
    public interface IUnitOfWork<T> where T : class
    {
        T Instance { get; }
        Task SaveAsync();
    }
}
