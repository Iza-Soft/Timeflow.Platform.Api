namespace Timeflow.Platform.Infrastructure.Entities
{
    public class ProjectEntity : BaseEntity<int>
    {
        public string Title { get; set; } = null!;

        public string? Description { get; set; }

        public Guid UserId { get; set; }

        public virtual ICollection<TaskEntity> Tasks { get; set; } = null!;
    }
}
