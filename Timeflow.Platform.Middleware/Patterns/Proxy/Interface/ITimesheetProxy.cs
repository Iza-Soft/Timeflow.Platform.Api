using Timeflow.Platform.Middleware.Dto;

namespace Timeflow.Platform.Middleware.Patterns.Proxy.Interface
{
    public interface ITimesheetProxy
    {
        Task<IList<TimesheetDto>> GetWeeklyTimesheetByUserIdAsync(TimesheetDto requestDto);
    }
}
