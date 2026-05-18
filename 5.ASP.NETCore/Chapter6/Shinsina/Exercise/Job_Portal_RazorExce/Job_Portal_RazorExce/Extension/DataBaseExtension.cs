using Job_Portal_RazorExce.Helper;
using Job_Portal_RazorExce.Interface;
using Job_Portal_RazorExce.Model;
using Job_Portal_RazorExce.Repository;
using Job_Portal_RazorExce.Service;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace Job_Portal_RazorExce.Extension
{
    public static class DataBaseExtension
    {
        public static IServiceCollection AddDataBaseService(
            this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IJobRepository, JobRepository>();
            services.AddScoped<IJobService, JobService>();
            services.AddAutoMapper(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });
            return services;
        }
    }
}
