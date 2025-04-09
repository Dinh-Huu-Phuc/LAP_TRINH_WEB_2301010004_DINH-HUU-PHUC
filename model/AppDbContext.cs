using Microsoft.EntityFrameworkCore;

namespace LAP_TRINH_WEB_2301010004_DINH_HUU_PHUC.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Game> Games { get; set; }
    }
}
