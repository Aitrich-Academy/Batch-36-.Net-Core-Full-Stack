using JobPortal_Activity2_API.Helpers;
using JobPortal_Activity2_API.Interface;
using JobPortal_Activity2_API.Interfaces;
using JobPortal_Activity2_API.Models;
using JobPortal_Activity2_API.Repository;
using JobPortal_Activity2_API.Services;
using Microsoft.EntityFrameworkCore;

namespace JobPortal_Activity2_API.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplication(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(
                options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddAutoMapper(cfg => { cfg.AddProfile<AutoMapperProfile>(); });
            services.AddScoped<IJobRepository, JobRepository>();
            services.AddScoped<IJobService, JobService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();
            return services;
        }
    }
}
