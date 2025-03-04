using Microsoft.EntityFrameworkCore;
using Pierogarnia.Models;

namespace Pierogarnia.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Dish> Dishes { get; set; }
    }
}
