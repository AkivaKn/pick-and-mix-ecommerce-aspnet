using Microsoft.EntityFrameworkCore;
using PickAndMixECommerce.Models;

namespace PickAndMixECommerce.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
       public DbSet<Sweet> Sweets { get; set; }
       public DbSet<Brand> Brands { get; set; }
    }
}
