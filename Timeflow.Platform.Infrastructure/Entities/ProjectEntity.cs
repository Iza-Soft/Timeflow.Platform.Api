namespace Timeflow.Platform.Infrastructure.Entities
{
    public class ProjectEntity : BaseEntity<int>
    {
        public Guid UserId { get; set; }

        public string Title { get; set; } = null!;

        public string? Description { get; set; }

        public virtual ICollection<TaskEntity> Tasks { get; set; } = null!;
    }
}
