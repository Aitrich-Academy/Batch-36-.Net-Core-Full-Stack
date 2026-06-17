using Microsoft.EntityFrameworkCore;
using StudentPortal.Models;

namespace StudentPortal.Extension
{
    public static class ApplicationExtension
    {
        public static IServiceCollection AddApplicationServices(
            this IServiceCollection services,
            IConfiguration config)
        {
            services.AddDbContext<StudentDbContext>(options =>
                options.UseSqlServer(
                    config.GetConnectionString("DefaultConnection")));

            return services;
        }
    }
}