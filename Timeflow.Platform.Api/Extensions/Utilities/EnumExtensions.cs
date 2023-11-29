using System.Runtime.CompilerServices;

namespace Timeflow.Platform.Api.Extensions.Utilities
{
    public static class EnumExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToDescription(this Enum value)
        {
            var field = value.GetType().GetField(value.ToString());

            var attributes = field!.GetCustomAttributes(false);

            dynamic? displayAttribute = null;

            if (attributes.Any())
            {
                displayAttribute = attributes.ElementAt(0);
            }

            return displayAttribute?.Description ?? "Description Not Found";
        }
    }
}
