using Newtonsoft.Json;
using Timeflow.Platform.Infrastructure.Enums;

namespace Timeflow.Platform.Api.Boundary.Response
{
    public class TaskResponse
    {
        [JsonProperty("Id")]
        public int Id { get; set; }

        [JsonProperty("ServiceTypeId")]
        public ServiceTypeEnum ServiceTypeId { get; set; }

        [JsonProperty("ServiceType")]
        public string ServiceType { get; set; } = null!;
    }
}
