using Microsoft.EntityFrameworkCore;
using ConsoleApp1.Models;

namespace ConsoleApp1.DataAccess
{
    public class PracContext : DbContext
    {
        public PracContext(DbContextOptions<PracContext> options) : base(options)
        {
        }
       
        public DbSet<Prac> Pracs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-PAD2RB4\\SQLEXPRESS;Initial Catalog=Prac;Integrated Security=True;Connect Timeout=60;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Prac>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedNever(); // Disable auto-increment
            });
        }
    }
}
