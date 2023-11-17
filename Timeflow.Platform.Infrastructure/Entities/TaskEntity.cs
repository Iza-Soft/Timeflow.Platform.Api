namespace Timeflow.Platform.Infrastructure.Entities
{
    public class TaskEntity : BaseEntity<int>
    {
        public int ProjectId { get; set; }

        public string Title { get; set; } = null!;

        public string? Notes { get; set; }

        public virtual ProjectEntity Project { get; set; } = null!;
    }
}
