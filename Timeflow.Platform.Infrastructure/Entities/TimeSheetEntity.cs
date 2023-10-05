namespace Timeflow.Platform.Infrastructure.Entities
{
    public class TimeSheetEntity : BaseEntity<int>
    {
        public int ProjectId { get; set; }

        public int ContractorId { get; set; }

        public int Day { get; set; }

        public int Month { get; set; }

        public int Year { get; set; }

        public double WorkingHours { get; set; }
    }
}
