using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Timeflow.Platform.Infrastructure.Authentication;
using Timeflow.Platform.Infrastructure.Entities;
using Timeflow.Platform.Infrastructure.Mappings;
//using Service.History.DataAccess.Authentication;
//using Service.History.DataAccess.Entities;
//using Service.History.DataAccess.Mappings;

namespace Timeflow.Platform.Infrastructure
{
    /*https://stackoverflow.com/questions/24079133/what-is-the-difference-between-dbset-and-virtual-dbset*/
    public class TimeFlowContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public TimeFlowContext(DbContextOptions<TimeFlowContext> options) : base(options) { }

        public virtual DbSet<ContractorEntity> Contractors { get; set; } = null!;

        public virtual DbSet<CompanyEntity> Companies { get; set; } = null!;

        public virtual DbSet<PersonEntity> Persons { get; set; } = null!;

        public virtual DbSet<CustomerEntity> Customers { get; set; } = null!;

        public virtual DbSet<ProjectEntity> Projects { get; set; } = null!;

        public virtual DbSet<TimeSheetEntity> TimeSheets { get; set; } = null!;

        public virtual DbSet<CurrencyEntity> Currencies { get; set; } = null!;

        public virtual DbSet<HourlyRateEntity> HourlyRates { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUser>().Configure();
            modelBuilder.Entity<ContractorEntity>().Configure();
            modelBuilder.Entity<CompanyEntity>().Configure();
            modelBuilder.Entity<PersonEntity>().Configure();
            modelBuilder.Entity<CustomerEntity>().Configure();
            modelBuilder.Entity<ProjectEntity>().Configure();
            modelBuilder.Entity<TimeSheetEntity>().Configure();
            modelBuilder.Entity<CurrencyEntity>().Configure();
            modelBuilder.Entity<HourlyRateEntity>().Configure();

            base.OnModelCreating(modelBuilder);
        }
    }
}