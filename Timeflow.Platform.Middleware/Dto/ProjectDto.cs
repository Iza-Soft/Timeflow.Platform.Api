namespace Timeflow.Platform.Middleware.Dto
{
    public class ProjectDto
    {
        public int Id { get; set; }

        public Guid UserId { get; set; }

        public string Title { get; set; } = null!;

        public string? Description { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid CreatedBy { get; set; }

        public IList<TaskDto>? Tasks { get; set; }
    }
}
