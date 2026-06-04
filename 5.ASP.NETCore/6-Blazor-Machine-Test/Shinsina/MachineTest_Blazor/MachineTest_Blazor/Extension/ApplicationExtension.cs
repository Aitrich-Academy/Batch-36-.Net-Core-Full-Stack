using MachineTest_Blazor.Interface;
using MachineTest_Blazor.Model;
using MachineTest_Blazor.Repository;
using MachineTest_Blazor.Service;
using Microsoft.EntityFrameworkCore;

namespace MachineTest_Blazor.Extension
{
    public static class ApplicationExtension
    {
        public static IServiceCollection AddApplicationServices(
            this IServiceCollection services,
            IConfiguration config)
        {
            services.AddDbContext<AppDBContext>(option => option.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<ICustomerService, CustomerService>();
            return services;

        }
    }
}
