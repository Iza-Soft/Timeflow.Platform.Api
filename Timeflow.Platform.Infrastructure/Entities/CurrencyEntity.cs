namespace Timeflow.Platform.Infrastructure.Entities
{
    public class CurrencyEntity : BaseEntity<int>
    {
        public string Name { get; set; } = null!;

        public string Abbreviation { get; set; } = null!;

        public virtual ICollection<HourlyRateEntity> HourlyRates { get; set; } = null!;
    }
}
