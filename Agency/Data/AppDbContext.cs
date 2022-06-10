using Agency.Models;
using Microsoft.EntityFrameworkCore;

namespace Agency.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {}

        public DbSet<Banner> Banners { get; set; }
        public DbSet<Service> Services { get; set; }

    }
}
