using Newtonsoft.Json;
using Timeflow.Platform.Middleware.Dto;

namespace Timeflow.Platform.Api.Boundary.Response
{
    public class ProjectResponse
    {
        [JsonProperty("Id")]
        public int Id { get; set; }

        [JsonProperty("UserId")]
        public Guid UserId { get; set; }

        [JsonProperty("Title")]
        public string Title { get; set; } = null!;

        [JsonProperty("Description")]
        public string? Description { get; set; }

        [JsonProperty("Tasks")]
        public IList<TaskResponse>? Tasks { get; set; }
    }
}
