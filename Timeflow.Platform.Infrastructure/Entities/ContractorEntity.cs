using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timeflow.Platform.Infrastructure.Entities
{
    public abstract class ContractorEntity : BaseEntity<int>
    {
        public string Name { get; set; } = null!;

        public string Address { get; set; } = null!;

        public string City { get; set; } = null!;

        public string Country { get; set; } = null!;

        public string Postcode { get; set; } = null!;

        public string Phone { get; set; } = null!;

        public string Email { get; set; } = null!;
    }
}
