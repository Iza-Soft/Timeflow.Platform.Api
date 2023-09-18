using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timeflow.Platform.DataAccess.Authentication
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string Forename { get; set; } = null!;

        public string Surname { get; set; } = null!;
    }
}
