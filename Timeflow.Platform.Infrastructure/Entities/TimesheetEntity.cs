namespace Timeflow.Platform.Infrastructure.Entities
{
    public class TimeSheetEntity : BaseEntity<int>
    {
        public int TaskId { get; set; }

        public int DayOfMonth { get; set; }

        public int MonthOfYear { get; set; }

        public int Year { get; set; }

        public int? WorkingHours { get; set; }

        public string? Notes { get; set; }

    }
}