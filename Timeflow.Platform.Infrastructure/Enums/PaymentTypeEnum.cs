using System.ComponentModel;

namespace Timeflow.Platform.Infrastructure.Enums
{
    public enum PaymentTypeEnum : byte
    {
        [Description("Hourly rate")]
        HourlyRate = 1,

        [Description("Lump sum")]
        LumpSum = 2
    }
}
