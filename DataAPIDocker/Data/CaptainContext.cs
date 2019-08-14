using Microsoft.EntityFrameworkCore;

namespace DataAPIDocker.Models
{
    public class CaptainContext : DbContext
    {
        public CaptainContext(DbContextOptions<CaptainContext> options)
            : base(options)
        {
        }

        public DbSet<Captain> Captains { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Captain>().HasData
                (
                new Captain { CaptainId = 1, Name = "Julie Lerman" },
                new Captain { CaptainId = 2, Name = "Rachid Zarouali" },
                new Captain { CaptainId = 3, Name = "Michele Bustamante" },
                new Captain { CaptainId = 4, Name = "Dan Wahlin" }
                );
        }
    }
}