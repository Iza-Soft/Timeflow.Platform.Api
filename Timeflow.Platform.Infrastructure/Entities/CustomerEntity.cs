using System.Numerics;

namespace Timeflow.Platform.Infrastructure.Entities
{
    public class CustomerEntity : BaseEntity<int>
    {
        public string Name { get; set; } = null!;

        public string Address { get; set; } = null!;

        public string City { get; set; } = null!;

        public string Country { get; set; } = null!;

        public string Postcode { get; set; } = null!;
    }
}
