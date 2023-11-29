using Timeflow.Platform.Infrastructure.Enums;

namespace Timeflow.Platform.Middleware.Dto
{
    public class TimesheetDto
    {
        public int Id { get; set; }

        public int TaskId { get; set; }

        public ServiceTypeEnum ServiceTypeId { get; set; }

        public int DayOfMonth { get; set; }

        public int WeekOfYear { get; set; }

        public int MonthOfYear { get; set; }

        public int Year { get; set; }

        public int? WorkingHours { get; set; }

        public string? Notes { get; set; }

        public Guid UserId { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid CreatedBy { get; set; }

        public TaskDto Task { get; set; } = null!;
    }
}
