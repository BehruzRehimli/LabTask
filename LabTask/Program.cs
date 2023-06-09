using LabTask.DAL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<LabDbContext>(opt=>opt.UseSqlServer("Server=TITAN08\\SQLEXPRESS;Database=LabTask;Trusted_Connection=Yes;"));
var app = builder.Build();

app.MapControllerRoute("default", "{Controller=Home}/{Action=Index}/{id?}");
app.UseStaticFiles();

app.Run();
