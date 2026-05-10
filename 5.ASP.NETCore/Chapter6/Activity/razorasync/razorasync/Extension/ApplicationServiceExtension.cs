using Microsoft.EntityFrameworkCore;
using razorasync.Helper;
using razorasync.Interface;
using razorasync.Model;
using razorasync.Repository;
using razorasync.Service;

namespace razorasync.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices
         (this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            services.AddAutoMapper(cfg => { cfg.AddProfile<AutoMapperProfile>(); });
            services.AddScoped<ITourRepository, TourRepository>();
            services.AddScoped<ITourService, TourService>();
            
            return services;
        }
    }
}