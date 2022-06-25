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
        public DbSet<About> Abouts { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<SocialNetwork> SocialNetworks { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}
