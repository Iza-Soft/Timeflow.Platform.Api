using Timeflow.Platform.Infrastructure.Enums;

namespace Timeflow.Platform.Infrastructure.Entities
{
    public class TimeSheetEntity : BaseEntity<int>
    {
        public int TaskId { get; set; }

        public ServiceTypeEnum ServiceTypeId { get; set; }

        public int DayOfMonth { get; set; }

        public int WeekOfYear { get; set; }

        public int MonthOfYear { get; set; }

        public int Year { get; set; }

        public int? WorkingHours { get; set; }

        public string? Notes { get; set; }

        public Guid UserId { get; set; }

        public virtual TaskEntity Task { get; set; } = null!;

    }
}