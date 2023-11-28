using Newtonsoft.Json;
using Timeflow.Platform.Infrastructure.Enums;

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

        [JsonProperty("ServiceType")]
        public string ServiceType { get; set; } = null!;

        [JsonProperty("WorkingHours")]
        public int? WorkingHours { get; set; }

        [JsonProperty("PaymentAmount")]
        public decimal PaymentAmount { get; set; }

        [JsonProperty("PaymentType")]
        public string PaymentType { get; set; } = null!;

        [JsonProperty("Notes")]
        public string? Notes { get; set; }

        [JsonProperty("UserId")]
        public Guid UserId { get; set; }

        [JsonProperty("Date")]
        public DateTime CreatedDate { get; set; }

        [JsonProperty("CreatedBy")]
        public Guid CreatedBy { get; set; }
    }
}
