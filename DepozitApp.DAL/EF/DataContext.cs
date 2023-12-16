
using DepozitApp.Domain;
using DepozitApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DepozitApp.DAL.EF
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
           // Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        public DbSet<MounthlyDepozitReport> MounthlyDepozitReports { get; set; }
        public DbSet<CurrenciesReport> CurrenciesReports { get; set; }
        public DbSet<DollarCurrencyReport> DollarCurrencyReports { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MounthlyDepozitReport>().Property(x => x.MounthId).ValueGeneratedOnAdd();
            modelBuilder.Entity<CurrenciesReport>().Property(x => x.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<DollarCurrencyReport>().Property(x => x.Id).ValueGeneratedOnAdd();
        }
    }
}
