namespace Timeflow.Platform.Infrastructure.Entities
{
    public class PaymentTypeEntity : BaseEntity<int>
    {
        public string Name { get; set; } = null!;

        public string? Description { get; set; } = null!;

        public virtual ICollection<TaskEntity> Tasks { get; set; } = null!;
    }
}
