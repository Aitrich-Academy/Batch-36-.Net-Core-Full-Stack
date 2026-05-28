using JobManagement.Model;
using JobManagement.Repository;
using JobManagement.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using AutoMapper;
using JobManagement.Helper;

namespace JobManagement.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices
            (this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApplicationDbContext>(options=>
                 options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            services.AddScoped<JobRepository>();
            services.AddScoped<JobService>();
            services.AddAutoMapper(cfg => { cfg.AddProfile<AutoMapperProfile>(); });

            return services;

        }
    }
}
