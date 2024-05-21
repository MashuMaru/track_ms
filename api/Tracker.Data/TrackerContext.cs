using Microsoft.EntityFrameworkCore;
using Tracker.Data.Entities;

namespace Tracker.Data
{
    public class TrackerContext : DbContext
    {
        public TrackerContext(DbContextOptions<TrackerContext> options) : base(options)
        {
        }

        /*Entities*/
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        
        /*Model builder*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(p => p.Created)
                .HasDefaultValue(DateTime.UtcNow);
        }
    }
}