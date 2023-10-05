namespace Timeflow.Platform.Infrastructure.Entities
{
    public class ProjectEntity : BaseEntity<int>
    {
        public int CustomerId { get; set; }

        public int ContractorId { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;
    }
}
