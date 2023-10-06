namespace Timeflow.Platform.Infrastructure.Entities
{
    public class HourlyRateEntity : BaseEntity<int>
    {
        public int ProjectId { get; set; }

        public int ContractorId { get; set; }

        public decimal Rate { get; set; }

        public int CurrencyId { get; set; }

        public virtual CurrencyEntity Currency { get; set; } = null!;
    }
}
