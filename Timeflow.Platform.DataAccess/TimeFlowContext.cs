using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Timeflow.Platform.DataAccess.Authentication;
using Timeflow.Platform.DataAccess.Entities;
using Timeflow.Platform.DataAccess.Mappings;
//using Service.History.DataAccess.Authentication;
//using Service.History.DataAccess.Entities;
//using Service.History.DataAccess.Mappings;

namespace Timeflow.Platform.DataAccess
{
    /*https://stackoverflow.com/questions/24079133/what-is-the-difference-between-dbset-and-virtual-dbset*/
    public class TimeFlowContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public TimeFlowContext(DbContextOptions<TimeFlowContext> options) : base(options) { }

        public virtual DbSet<CompanyEntity> Companies { get; set; } = null!;

        public virtual DbSet<CustomerEntity> Customers { get; set; } = null!;

        public virtual DbSet<ProjectEntity> Projects { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUser>().Configure();
            modelBuilder.Entity<CompanyEntity>().Configure();
            modelBuilder.Entity<CustomerEntity>().Configure();
            modelBuilder.Entity<ProjectEntity>().Configure();

            base.OnModelCreating(modelBuilder);
        }
    }
}