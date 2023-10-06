﻿namespace Timeflow.Platform.Infrastructure.Entities
{
    public class TimesheetEntity : BaseEntity<int>
    {
        public int ContractorId { get; set; }

        public int DayOfMonth { get; set; }

        public int MonthOfYear { get; set; }

        public int Year { get; set; }

        public string DayOfWeek { get; set; } = null!;

        public string Month { get; set; } = null!;

        public double WorkingHours { get; set; }

        public virtual ContractorEntity Contractor { get; set; } = null!;

    }
}