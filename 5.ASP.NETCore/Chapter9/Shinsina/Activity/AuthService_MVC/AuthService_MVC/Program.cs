using AuthService_MVC.Extention;
using Microsoft.EntityFrameworkCore;
using AuthService_MVC.Extention;
using AuthService_MVC.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddApplicationServices(builder.Configuration);
builder.Services.AddSession();
builder.Services.AddHttpContextAccessor();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseSession();
app.UseRouting();
app.UseAuthorization();
app.UseStaticFiles();



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=User}/{action=Register}");

app.Run();
