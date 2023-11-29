using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Timeflow.Platform.Api.Boundary.Request.Abstract;

namespace Timeflow.Platform.Api.Boundary.Request.Class
{
    public class TimesheetRequestViewModelV2 : RequestViewModel
    {
        [FromRoute]
        [BindProperty(Name = "userId")]
        public Guid UserId { get; set; }

        /*Commonly FromQuery being used for sort or filter, these parameters are not required, unlike FromRoute*/
        [FromQuery]
        [BindProperty(Name = "date")]
        public DateTime? Date { get; set; }
    }
}
