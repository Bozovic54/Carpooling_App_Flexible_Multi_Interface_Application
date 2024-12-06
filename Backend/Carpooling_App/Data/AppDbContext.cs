using Carpooling_App.Models;
using Microsoft.EntityFrameworkCore;

namespace Carpooling_App.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Ride> Ride { get; set; }
    }
}
