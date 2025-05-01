using Microsoft.EntityFrameworkCore;
using TravelExperience.Models;

namespace TravelExperience.Data
{
    public class AppDbContext : DbContext    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Trip> Trips { get; set; }
        public DbSet<Activity> Activities { get; set; }
    }

}
