using Timeflow.Platform.Infrastructure.Entities;

namespace Timeflow.Platform.Infrastructure.Patterns.Repository.Interface
{
    public interface ITimesheetRepository : IAsyncRepository<TimeSheetEntity>
    {
        public Task<IList<TimeSheetEntity>> GetWeeklyTimesheetByUserIdAsync(Guid userId, int weekOfYear, int year);
    }
}
