using LAP_TRINH_WEB_2301010004_DINH_HUU_PHUC.Models;
using Microsoft.EntityFrameworkCore;
using WebApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Cấu hình DbContext với chuỗi kết nối trực tiếp (hoặc dùng cấu hình trong appsettings.json)
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer("Server=TANTHUYHOANG\\SQLEXPRESS;Database=GameStore;Trusted_Connection=True;TrustServerCertificate=True;"));


// Thêm CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod());
});

// Thêm dịch vụ controller (API)
builder.Services.AddControllers();
builder.Services.AddScoped<UserService>();

var app = builder.Build();

// Áp dụng CORS
app.UseCors("AllowAll");

// Cho phép tự động load index.html nếu truy cập "/"
app.UseDefaultFiles();

// Cho phép truy cập file tĩnh trong wwwroot
app.UseStaticFiles();

// Ánh xạ các controller API
app.MapControllers();

app.Run();
