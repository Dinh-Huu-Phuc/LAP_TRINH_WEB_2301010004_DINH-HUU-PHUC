using WebApp.Models;
using LAP_TRINH_WEB_2301010004_DINH_HUU_PHUC.Models; // <- để lấy AppDbContext

namespace WebApp.Services
{
    public class UserService
    {
        private readonly AppDbContext _context;

        public UserService(AppDbContext context)
        {
            _context = context;
        }

        public Users GetUserByUsername(string username)
        {
            return _context.Users.FirstOrDefault(u => u.Username == username);
        }
        public void SaveUser(Users user)
        {
            Console.WriteLine("🟡 Đang lưu user: " + user.Username); // ✅ Thêm dòng này nè

            _context.Users.Add(user);
            _context.SaveChanges();

            Console.WriteLine("✅ Lưu user thành công: " + user.Username); // (Tuỳ chọn) thêm dòng này để confirm lưu xong
        }
    }
}
