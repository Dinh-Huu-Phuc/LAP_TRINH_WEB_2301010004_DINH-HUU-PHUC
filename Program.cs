using LAP_TRINH_WEB_2301010004_DINH_HUU_PHUC.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddControllers();

var app = builder.Build();

app.UseDefaultFiles();    // Tự động load index.html nếu truy cập "/"
app.UseStaticFiles();     // Cho phép truy cập file tĩnh trong wwwroot

app.MapControllers();     // Nếu bạn có controller API

app.Run();
