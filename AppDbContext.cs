using Microsoft.EntityFrameworkCore;
using Restaurant_API.Models;

namespace Restaurant_API.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)

        {
            
        }
        public DbSet<Menu> Menu { get; set; }
    }
}
