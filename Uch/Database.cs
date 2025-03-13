using Microsoft.EntityFrameworkCore;
using static Uch.Models;

namespace Uch;

public class Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<Material> Materials { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<MaterialProvider> MaterialsProviders { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
