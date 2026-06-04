using JobProviderApp.Data;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;
using JobProvider_App.Helpers;
using JobProvider_App.Interface;
using JobProvider_App.Model;
using JobProvider_App.Repository;
using JobProvider_App.Service;


namespace JobProvider_App.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices
            (this IServiceCollection services, IConfiguration config)
        {
            services.AddDistributedMemoryCache(); // Required for session
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30); // Session timeout
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });
            services.AddHttpContextAccessor();

            services.AddScoped<ProtectedSessionStorage>();

            services.AddDbContext<AppDBContext>(options =>
                options.UseSqlServer(
                    config.GetConnectionString("DefaultConnection")));

            services.AddAutoMapper(cfg => { cfg.AddProfile<MappingProfile>(); });

            services.AddScoped<IJobProviderRepository, JobProviderRepository>();
            services.AddScoped<IJobRepository, JobRepository>();
            services.AddScoped<IJobservice, JobService>();
            services.AddScoped<IAuthService, AuthService>();

            return services;
            
        }
    }
}
