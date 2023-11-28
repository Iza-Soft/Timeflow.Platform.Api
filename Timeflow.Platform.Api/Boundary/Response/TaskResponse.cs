using Newtonsoft.Json;

namespace Timeflow.Platform.Api.Boundary.Response
{
    public class TaskResponse
    {
        [JsonProperty("Id")]
        public int Id { get; set; }

        [JsonProperty("ProjectId")]
        public int ProjectId { get; set; }

        [JsonProperty("ServiceTypeId")]
        public int ServiceTypeId { get; set; }

        [JsonProperty("Title")]
        public string Title { get; set; } = null!;

        [JsonProperty("Description")]
        public string? Description { get; set; }

        [JsonProperty("UserId")]
        public Guid UserId { get; set; }
    }
}
