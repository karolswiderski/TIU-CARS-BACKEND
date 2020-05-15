using Microsoft.EntityFrameworkCore;

namespace zadangular234.Models.Data
{
    public class SamochodyContext : DbContext
    {
        public SamochodyContext(DbContextOptions<SamochodyContext> options) : base(options) { }
        public DbSet<Samochody> Samochody { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = bazaSamochody.Db");
        }
    }
}
