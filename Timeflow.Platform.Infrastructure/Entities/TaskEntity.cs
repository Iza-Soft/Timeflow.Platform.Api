namespace Timeflow.Platform.Infrastructure.Entities
{
    public class TaskEntity : BaseEntity<int>
    {
        public int ProjectId { get; set; }

        public int ServiceTypeId { get; set; }

        public string Title { get; set; } = null!;

        public int PaymentTypeId { get; set; } /*{id=0, Name=HourlyRate} {id=1, Name=LumpSum}*/

        public decimal PaymentAmount { get; set; }

        public string? Description { get; set; }

        public virtual ProjectEntity Project { get; set; } = null!;

        public virtual ServiceTypeEntity ServiceType { get; set; } = null!;

        public virtual ICollection<TimeSheetEntity> Timesheets { get; set; } = null!;
    }
}
