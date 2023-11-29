using Timeflow.Platform.Middleware.Dto;
using Timeflow.Platform.Middleware.Gateways;
using Timeflow.Platform.Middleware.Patterns.Proxy.Interface;

namespace Timeflow.Platform.Middleware.Patterns.Proxy.Class
{
    public class TimesheetProxy : ITimesheetProxy
    {
        #region Properties
        private readonly TimesheetApiGateway _timesheetApiGateway;
        #endregion

        public TimesheetProxy(IServiceProvider provider)
        {
            this._timesheetApiGateway = new TimesheetApiGateway(provider);
        }

        public async Task<IList<TimesheetDto>> GetWeeklyTimesheetByUserIdAsync(TimesheetDto requestDto)
        {
            return await this._timesheetApiGateway.GetWeeklyTimesheetByUserIdAsync(requestDto);
        }
    }
}
