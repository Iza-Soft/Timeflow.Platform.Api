
using Microsoft.EntityFrameworkCore;
using Timeflow.Platform.Infrastructure.Authentication;

namespace Timeflow.Platform.Infrastructure.Entities
{
    public class PersonEntity : ContractorEntity
    {
        public int? CompanyId { get; set; }

        public virtual CompanyEntity Company { get; set; } = null!;
    }
}
