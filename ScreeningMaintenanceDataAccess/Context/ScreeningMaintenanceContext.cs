using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using ScreeningMaintenance.DataAccess.Models;

namespace ScreeningMaintenanceDataAccess.Context
{
    public class ScreeningMaintenanceContext : DbContext
    {
        public ScreeningMaintenanceContext(DbContextOptions<ScreeningMaintenanceContext> options) : base(options)
        { }       

        public DbSet<Clinic> Clinics { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Invitation>Invitations { get; set; }
        public DbSet<Region>Regions { get; set; }
        public DbSet<SerialNumber> SerialNumbers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clinic>()
               .HasKey(c => new { c.Id, c.Orgbet });
            modelBuilder.Entity<Address>()
               .HasKey(a => new { a.Orgbet });
            modelBuilder.Entity<Invitation>()
                .HasKey(a => new { a.Orgbet });
            
            base.OnModelCreating(modelBuilder);
        }
    }
}