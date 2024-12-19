using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AdvProProject.Data.Models;

namespace AdvProProject.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Events> Events { get; set; }

        public DbSet<Participants> Participants { get; set; }

        public DbSet<Venues> Venues { get; set; }

        public DbSet<Activities> Activities { get; set; }

        public DbSet<Registration> Registration { get; set; }

        
        // Configure MtoM Relationship
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
            modelBuilder.Entity<Participants>()
                .HasMany(p => p.Events)
                .WithMany(e => e.Participants)
                .UsingEntity<Dictionary<string, object>>(
                    "ParticipantEvent",
                    j => j.HasOne<Events>().WithMany().HasForeignKey("EventId"),
                    j => j.HasOne<Participants>().WithMany().HasForeignKey("ParticipantId"));
        }
    }
}
