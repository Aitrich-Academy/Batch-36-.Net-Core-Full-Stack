
using Login_Exercise_1_Blazor.Helpers;
using Login_Exercise_1_Blazor.Interface;
using Login_Exercise_1_Blazor.Model;
using Login_Exercise_1_Blazor.Repository;
using Login_Exercise_1_Blazor.Service;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;

namespace Login_Exercise_1_Blazor.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(
            this IServiceCollection services,
            IConfiguration config)
        {
            services.AddDistributedMemoryCache();

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            services.AddScoped<ProtectedSessionStorage>();

            services.AddDbContext<AppDBContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            //Authservice
            services.AddScoped<ISeekerAuthService, SeekerAuthService>();


            //🔥 SIMPLE RULE TO REMEMBER:
            //👉 Service = “WHAT to do”
            //👉 Repository = “HOW to store it”

            // Repositories
            services.AddScoped<ISeekerRepository, SeekerRepository>();// data layer
            services.AddScoped<IJobRepository, JobRepository>(); 

            // Services
            services.AddScoped<ISeekerService, SeekerService>();// logic layer
            services.AddScoped<IJobService, JobService>();

            // AutoMapper
            //services.AddAutoMapper(typeof(MappingProfile));
            services.AddAutoMapper(cfg => { cfg.AddProfile<MappingProfile>(); });

            return services;
        }
    }
}

