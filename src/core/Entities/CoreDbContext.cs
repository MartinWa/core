using Microsoft.EntityFrameworkCore;

namespace core.Entities
{
    public class CoreDbContext : DbContext
    {
        public DbSet<Resturant> Resturants { get; set; }
    }
}
