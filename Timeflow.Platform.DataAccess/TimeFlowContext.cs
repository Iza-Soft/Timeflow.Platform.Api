using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Timeflow.Platform.DataAccess.Authentication;
//using Service.History.DataAccess.Authentication;
//using Service.History.DataAccess.Entities;
//using Service.History.DataAccess.Mappings;

namespace Timeflow.Platform.DataAccess
{
    /*https://stackoverflow.com/questions/24079133/what-is-the-difference-between-dbset-and-virtual-dbset*/
    public class TimeFlowContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public TimeFlowContext(DbContextOptions<TimeFlowContext> options) : base(options) { }

        //public virtual DbSet<VehicleEntity> Vehicles { get; set; } = null!;

        //public virtual DbSet<EngineEntity> Engines { get; set; } = null!;

        //public virtual DbSet<PerformanceEntity> Performances { get; set; } = null!;

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<ApplicationUser>().Configure();
        //    modelBuilder.Entity<VehicleEntity>().Configure();
        //    modelBuilder.Entity<CarEntity>().Configure();
        //    modelBuilder.Entity<EngineEntity>().Configure();
        //    modelBuilder.Entity<PerformanceEntity>().Configure();

        //    base.OnModelCreating(modelBuilder);
        //}
    }
}