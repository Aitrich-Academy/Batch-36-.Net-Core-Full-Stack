using HireMeNow_MVC_Exc.Interfaces;
using HireMeNow_MVC_Exc.Repository;
using HireMeNow_MVC_Exc.Services;
using HireMeNow_MVC_Exc.Models;
using Microsoft.EntityFrameworkCore;

namespace HireMeNow_MVC_Exc.Extensions
{
    public static class ServiceExtension
    {
        public static IServiceCollection
            AddApplicationServices(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<HireMeNowContext>(
                options =>
                options.UseSqlServer(
                    configuration
                    .GetConnectionString(
                        "DefaultConnection")));

            services.AddScoped<IUserRepository,
                UserRepository>();

            services.AddScoped<IJobRepository,
                JobRepository>();

            services.AddScoped<IPublicService,
                PublicService>();

            services.AddScoped<IJobSeekerService,
                JobSeekerService>();

            return services;
        }
    }
}