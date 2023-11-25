using Newtonsoft.Json;

namespace Timeflow.Platform.Api.Boundary.Response
{
    public class TimesheetResponse
    {
        [JsonProperty("Id")]
        public int Id { get; set; }

        [JsonProperty("Project")]
        public string ProjectName { get; set; } = null!;

        [JsonProperty("Task")]
        public string TaskName { get; set; } = null!;

        [JsonProperty("WorkingHours")]
        public int? WorkingHours { get; set; }

        [JsonProperty("Notes")]
        public string? Notes { get; set; }

        [JsonProperty("Date")]
        public DateTime CreatedDate { get; set; }

        [JsonProperty("UserId")]
        public Guid CreatedBy { get; set; }
    }
}
