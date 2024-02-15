using AspNetCoreEmpty.Models.Contexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllersWithViews();
var app = builder.Build();


builder.Services.AddDbContext<DataContext>(cfg =>
{
cfg.UseSqlServer(builder.Configuration.GetConnectionString("cString"));
});
//app.MapDefaultControllerRoute();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=home}/{action=index}/{id?}"
    );

app.Run();
