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
    }
}