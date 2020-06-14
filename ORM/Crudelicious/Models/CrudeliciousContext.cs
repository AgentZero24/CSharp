using Microsoft.EntityFrameworkCore;

namespace Crudelicious.Models
{
    public class CrudeliciousContext : DbContext
    {
        public CrudeliciousContext(DbContextOptions options) : base(options) { }

        public DbSet<Dish> Dishes { get; set; }
    }
}