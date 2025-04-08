var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

app.UseDefaultFiles();    // Tự động load index.html nếu truy cập "/"
app.UseStaticFiles();     // Cho phép truy cập file tĩnh trong wwwroot

app.MapControllers();     // Nếu bạn có controller API

app.Run();
