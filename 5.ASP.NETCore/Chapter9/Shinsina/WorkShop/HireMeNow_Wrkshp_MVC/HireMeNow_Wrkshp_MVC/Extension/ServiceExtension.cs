using HireMeNow_Wrkshp_MVC.Helper;
using HireMeNow_Wrkshp_MVC.Interface;
using HireMeNow_Wrkshp_MVC.Models;
using HireMeNow_Wrkshp_MVC.Repository;
using HireMeNow_Wrkshp_MVC.Service;
using Microsoft.EntityFrameworkCore;


namespace HireMeNow_Wrkshp_MVC.Extension
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddApplicationServices(
            this IServiceCollection services)
        {
            //services.AddDbContext<HireMeNowContext>(options =>
            //   options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            services.AddAutoMapper(cfg => { cfg.AddProfile<MappingProfile>(); });
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddScoped<IPublicService, PublicService>();

            services.AddScoped<IJobRepository, JobRepository>();

            services.AddScoped<IJobService, JobService>();

            return services;
        }
    }
}
