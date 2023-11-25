using Microsoft.EntityFrameworkCore;
using Timeflow.Platform.Infrastructure.Entities;
using Timeflow.Platform.Infrastructure.Patterns.Repository.Abstract;
using Timeflow.Platform.Infrastructure.Patterns.Repository.Interface;
using Timeflow.Platform.Infrastructure.Specifications.Timesheet;

namespace Timeflow.Platform.Infrastructure.Patterns.Repository.Class
{
    public class TimesheetRepository : AsyncRepository<TimeSheetEntity>, ITimesheetRepository
    {
        public TimesheetRepository(DbContext dataContext) : base(dataContext)
        {
        }

        public async Task<IList<TimeSheetEntity>> GetWeeklyTimesheetByUserIdAsync(Guid userId, int weekOfYear, int year) => await ListAsync(new GetWeeklyTimesheetSpec(userId, weekOfYear, year));
    }
}
