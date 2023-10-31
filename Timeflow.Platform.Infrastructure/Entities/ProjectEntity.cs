using System.ComponentModel.DataAnnotations.Schema;

namespace Timeflow.Platform.Infrastructure.Entities
{
    public class ProjectEntity : BaseEntity<int>
    {
        //public int CustomerId { get; set; }

        //public string Title { get; set; } = null!;

        //public string Description { get; set; } = null!;

        //public virtual CustomerEntity Customer { get; set; } = null!;

        //public virtual ICollection<TimeSheetEntity> Timesheets { get; set; } = null!;

        //public virtual ICollection<HourlyRateEntity> HourlyRates { get; set; } = null!;

        public string Title { get; set; } = null!;

        public string? Description { get; set; }
    }
}
