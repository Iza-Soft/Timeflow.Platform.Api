using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using Timeflow.Platform.Infrastructure.Enums;

namespace Timeflow.Platform.Infrastructure.Specifications.Interface
{
    internal abstract class BaseSpecification<T> : ISpecification<T> where T : class
    {
        private const int DefaultNotificationsPageSize = 10;

        public Expression<Func<T, bool>> Criteria { get; }
        public List<Expression<Func<T, object>>> Includes { get; } = new List<Expression<Func<T, object>>>();
        public List<string> IncludeStrings { get; } = new List<string>();

        public int? Offset { get; private set; } = 0;

        public int? Size { get; private set; } = DefaultNotificationsPageSize;

        public Expression<Func<T, object>> SortOn { get; private set; }

        public SortDirectionEnum SortDirection { get; private set; } = SortDirectionEnum.Asc;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        protected BaseSpecification() => Criteria = t => true;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        protected BaseSpecification([NotNull] Expression<Func<T, bool>> criteria) => Criteria = criteria;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        protected BaseSpecification([NotNull] Expression<Func<T, bool>> criteria, int offset, int size) : this(criteria)
        {

        }

        protected virtual void AddInclude(Expression<Func<T, object>> includeExpression)
        {
            Includes.Add(includeExpression);
        }

        protected virtual void AddInclude(string includeString)
        {
            IncludeStrings.Add(includeString);
        }

        protected virtual void ApplySortOn(Expression<Func<T, object>> sortOnExpression)
        {
            SortOn = sortOnExpression;
        }

        protected virtual void ApplySortDirection(SortDirectionEnum sortDirection)
        {
            SortDirection = sortDirection;
        }

        protected virtual void ApplyOffset(int offset)
        {
            Offset = offset;
        }

        protected virtual void ApplySize(int size)
        {
            Size = size == 0 ? DefaultNotificationsPageSize : size;
        }
    }
}
