using Microsoft.EntityFrameworkCore;
using Student_ManagmentSystemMVC_MachneTst.Models;

namespace Student_ManagmentSystemMVC_MachneTst.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddDatabase
            (this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            return services;
        }
        
    }
}
