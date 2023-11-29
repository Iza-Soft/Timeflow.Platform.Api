using Newtonsoft.Json;
using Timeflow.Platform.Infrastructure.Enums;

namespace Timeflow.Platform.Api.Boundary.Response
{
    public class TaskResponse
    {
        [JsonProperty("Id")]
        public int Id { get; set; }

        [JsonProperty("ProjectId")]
        public int ProjectId { get; set; }

        [JsonProperty("Title")]
        public string Title { get; set; } = null!;

        //[JsonProperty("ServiceTypeId")]
        //public ServiceTypeEnum ServiceTypeId { get; set; }

        //[JsonProperty("ServiceType")]
        //public string ServiceType { get; set; } = null!;

        [JsonProperty("Description")]
        public string Description { get; set; } = null!;
    }
}
