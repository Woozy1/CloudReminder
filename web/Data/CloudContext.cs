using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using web.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace web.Data
{
    public class CloudContext : IdentityDbContext<User>
    {
        public CloudContext (DbContextOptions<CloudContext> options)
            : base(options)
        {
        }
        public DbSet<Event> Message { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Group> Groups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Event>().ToTable("Event");
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Group>().ToTable("Group");
        }
    }
}