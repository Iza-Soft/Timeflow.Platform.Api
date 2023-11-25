using Timeflow.Platform.Api.Boundary.Request.Abstract;
using Timeflow.Platform.Api.Boundary.Request.Class;
using Timeflow.Platform.Api.Boundary.Response;
using Timeflow.Platform.Api.Extensions.Factories;
using Timeflow.Platform.Api.UseCase.Abstract;
using Timeflow.Platform.Middleware.Patterns.Proxy.Interface;

namespace Timeflow.Platform.Api.UseCase.Class
{
    public class GetWeeklyTimesheetByUserId : BaseUseCase<IList<TimesheetResponse>>
    {
        private readonly ITimesheetProxy _timesheetProxy;

        public GetWeeklyTimesheetByUserId(ITimesheetProxy timesheetProxy)
        {
            this._timesheetProxy = timesheetProxy;
        }

        public override async Task<IList<TimesheetResponse>> ExecuteAsync(RequestViewModel? request)
        {
            var requestDto = ((TimesheetQuery)request!).ToRequest();

            var weeklyTimesheets = await this._timesheetProxy.GetWeeklyTimesheetByUserIdAsync(requestDto);

            return weeklyTimesheets.ToResponse();
        }
    }
}
