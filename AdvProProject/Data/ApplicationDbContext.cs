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
    }
}
