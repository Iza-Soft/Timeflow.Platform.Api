using Timeflow.Platform.Infrastructure.Entities;

namespace Timeflow.Platform.Middleware.Dto
{
    public class TaskDto
    {
        public int Id { get; set; }

        public int ProjectId { get; set; }

        public int ServiceTypeId { get; set; }

        public string Title { get; set; } = null!;

        public string? Description { get; set; }

        public Guid UserId { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid CreatedBy { get; set; }

        public ProjectEntity Project { get; set; } = null!;
    }
}
