using Timeflow.Platform.Api.Boundary.Request.Abstract;

namespace Timeflow.Platform.Api.Boundary.Request.Class
{
    public class TimesheetQuery : RequestViewModel
    {
        public Guid UserId { get; set; }

        public DateTime Date { get; set; }
    }
}
