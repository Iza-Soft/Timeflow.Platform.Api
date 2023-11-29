using System.ComponentModel;

namespace Timeflow.Platform.Infrastructure.Enums
{
    public enum ServiceTypeEnum : byte
    {
        [Description("Billable")]
        Billable = 1,

        [Description("Non-Billable")]
        NonBillable = 2
    }
}
