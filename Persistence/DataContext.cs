using Domain; //import from Domain sub-directory
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Activity>? Activities { get; set; } //represent table called "Activities"
    }
}