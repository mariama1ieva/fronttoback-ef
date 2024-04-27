using fronttoback.Models;
using Microsoft.EntityFrameworkCore;

namespace fronttoback.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Slider> sliders { get; set; }
    }
}
