using Microsoft.Extensions.DependencyInjection;
using Timeflow.Platform.Infrastructure.Patterns.Repository.Interface;
using Timeflow.Platform.Middleware.Dto;
using Timeflow.Platform.Middleware.Extensions.Factories;
using Timeflow.Platform.Middleware.Patterns.Proxy.Interface;
using Timeflow.Platform.Middleware.Patterns.UnitOfWork.Interface;

namespace Timeflow.Platform.Middleware.Gateways
{
    internal class TimesheetApiGateway : ITimesheetProxy
    {
        private readonly IUnitOfWork<ITimesheetRepository> _unitOfWork;

        public TimesheetApiGateway(IServiceProvider provider)
        {
            IServiceScope scope = provider.CreateScope();

            this._unitOfWork = scope.ServiceProvider.GetRequiredService<IUnitOfWork<ITimesheetRepository>>();
        }

        public async Task<IList<TimesheetDto>> GetWeeklyTimesheetByUserIdAsync(TimesheetDto requestDto)
        {
            var weeklyTimesheets = await this._unitOfWork.Instance.GetWeeklyTimesheetByUserIdAsync(requestDto.UserId, requestDto.WeekOfYear, requestDto.Year);

            return weeklyTimesheets.ToResult();
        }
    }
}
