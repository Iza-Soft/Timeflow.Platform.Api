namespace Timeflow.Platform.Api.Boundary.Response
{
    public class ProjectResponseViewModel
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
    }
}
