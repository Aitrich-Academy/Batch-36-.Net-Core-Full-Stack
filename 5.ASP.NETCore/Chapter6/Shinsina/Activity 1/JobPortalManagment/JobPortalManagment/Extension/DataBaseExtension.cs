using JobPortalManagment.Helper;
using JobPortalManagment.Interface;
using JobPortalManagment.Migrations.Model;
using JobPortalManagment.Repository;
using JobPortalManagment.Service;
using Microsoft.EntityFrameworkCore;

namespace JobPortalManagment.Extension
{
    public static class DataBaseExtension
    {
        public static IServiceCollection AddDataBaseServices(
            this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(
                configuration.GetConnectionString("DefaultConnection")));


            services.AddScoped<IJobRepository,JobRepository>();
            services.AddScoped<IJobService,JobService>();
            services.AddAutoMapper(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });
            return services;
        }
    }
}
