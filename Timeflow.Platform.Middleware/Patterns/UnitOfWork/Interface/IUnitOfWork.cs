namespace Timeflow.Platform.Middleware.Patterns.UnitOfWork.Interface
{
    /*
     * https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers
     */
    public interface IUnitOfWork<T> where T : class
    {
        T Instance { get; }
        Task SaveAsync();
    }
}
