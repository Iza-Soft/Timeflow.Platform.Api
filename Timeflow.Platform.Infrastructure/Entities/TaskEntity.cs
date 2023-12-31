﻿using Timeflow.Platform.Infrastructure.Enums;

namespace Timeflow.Platform.Infrastructure.Entities
{
    public class TaskEntity : BaseEntity<int>
    {
        public int ProjectId { get; set; }

        //public ServiceTypeEnum ServiceTypeId { get; set; }

        public string Title { get; set; } = null!;

        public PaymentTypeEnum PaymentTypeId { get; set; }

        public decimal PaymentAmount { get; set; }

        public string? Description { get; set; }

        public Guid UserId { get; set; }

        public virtual ProjectEntity Project { get; set; } = null!;

        public virtual ICollection<TimeSheetEntity> Timesheets { get; set; } = null!;
    }
}
