using CartaSur.Models;
using Microsoft.EntityFrameworkCore;

namespace CartaSur.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Venta> Ventas { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Venta>()
                .HasKey(x => x.ID_VENTA);
        }
    }
}
