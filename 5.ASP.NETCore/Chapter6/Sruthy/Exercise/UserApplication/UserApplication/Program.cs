using UserApplication.Extension;

public partial class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddRazorPages();

        builder.Services.AddApplicationServices(builder.Configuration);

        builder.Services.AddSession();
        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();

        app.UseRouting();

        app.UseAuthorization();
        app.UseSession();
        app.MapStaticAssets();
        app.MapRazorPages()
           .WithStaticAssets();
        app.MapGet("/", context =>
        {
            context.Response.Redirect("/User/Login");
            return Task.CompletedTask;
        });
        app.Run();
    }
}