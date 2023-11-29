using System.Linq.Expressions;
using Timeflow.Platform.Infrastructure.Enums;

namespace Timeflow.Platform.Infrastructure.Specifications.Interface
{
    public interface ISpecification<T> where T : class
    {
        Expression<Func<T, bool>> Criteria { get; }
        List<Expression<Func<T, object>>> Includes { get; }
        List<string> IncludeStrings { get; }
        int? Offset { get; }
        int? Size { get; }
        Expression<Func<T, object>> SortOn { get; }
        SortDirectionEnum SortDirection { get; }
    }
}
