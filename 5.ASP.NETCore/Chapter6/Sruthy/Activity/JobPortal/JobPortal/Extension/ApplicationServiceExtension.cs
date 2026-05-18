using JobPortal.Helper;
using JobPortal.Interface;
using JobPortal.Model;
using JobPortal.Repository;
using JobPortal.Service;
using Microsoft.EntityFrameworkCore;

namespace JobPortal.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices
            (this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            services.AddAutoMapper(cfg => { cfg.AddProfile<AutoMapperProfile>(); });
            services.AddScoped<IJobRepository, JobRepository>();
            services.AddScoped<IJobService, JobService>();
            return services;//always return this
        }
    }
}
