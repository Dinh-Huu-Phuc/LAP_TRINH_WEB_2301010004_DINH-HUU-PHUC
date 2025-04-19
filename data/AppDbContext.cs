using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace LAP_TRINH_WEB_2301010004_DINH_HUU_PHUC.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // ✅ CHỈ GIỮ LẠI MỘT DÒNG NÀY
        public DbSet<Users> Users { get; set; }

        public DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>()
                .Property(g => g.Price)
                .HasColumnType("decimal(18,2)");
        }
    }
}
