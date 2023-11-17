namespace Timeflow.Platform.Middleware.Dto
{
    public class TaskDto
    {
        public int Id { get; set; }

        public int ProjectId { get; set; }

        public string Title { get; set; } = null!;

        public string? Notes { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid CreatedBy { get; set; }
    }
}
