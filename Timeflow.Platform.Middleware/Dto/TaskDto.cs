using Timeflow.Platform.Infrastructure.Entities;
using Timeflow.Platform.Infrastructure.Enums;

namespace Timeflow.Platform.Middleware.Dto
{
    public class TaskDto
    {
        public int Id { get; set; }

        public int ProjectId { get; set; }

        public ServiceTypeEnum ServiceTypeId { get; set; }

        public string Title { get; set; } = null!;

        public PaymentTypeEnum PaymentTypeId { get; set; }

        public decimal PaymentAmount { get; set; }

        public string? Description { get; set; }

        public Guid UserId { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid CreatedBy { get; set; }

        public ProjectEntity Project { get; set; } = null!;
    }
}
