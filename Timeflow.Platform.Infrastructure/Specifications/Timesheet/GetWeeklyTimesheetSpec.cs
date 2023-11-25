using Timeflow.Platform.Infrastructure.Entities;
using Timeflow.Platform.Infrastructure.Specifications.Interface;

namespace Timeflow.Platform.Infrastructure.Specifications.Timesheet
{
    internal class GetWeeklyTimesheetSpec : BaseSpecification<TimeSheetEntity>
    {
        public GetWeeklyTimesheetSpec(Guid userId, int weekOfYear, int year) : base(x => x.CreatedBy == userId && x.WeekOfYear == weekOfYear && x.Year == year)
        {
            AddInclude(x => x.Task);
            AddInclude(x => x.Task.Project);
        }
    }
}
