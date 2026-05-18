using Library_Managment_MechineTest.Model;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace Library_Managment_MechineTest.Extention
{
    public static class DataBaseExtention
    {
        public static IServiceCollection AddDataBaseService(
            this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(option =>
                option.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection")));
            return services;
        }
    }
}
