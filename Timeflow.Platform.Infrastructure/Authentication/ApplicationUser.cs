using Microsoft.AspNetCore.Identity;

namespace Timeflow.Platform.Infrastructure.Authentication
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string Forename { get; set; } = null!;

        public string Surname { get; set; } = null!;
    }
}
