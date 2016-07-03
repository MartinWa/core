using Microsoft.EntityFrameworkCore;

namespace core.Entities
{
    public class CoreDbContext : DbContext
    {
        public CoreDbContext(DbContextOptions<CoreDbContext> options) : base(options) { }
        public DbSet<Resturant> Resturants { get; set; }
    }
}
