using Microsoft.EntityFrameworkCore;
using UserApplication.Helper;
using UserApplication.Interface;
using UserApplication.Model;
using UserApplication.Repository;
using UserApplication.Service;

namespace UserApplication.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices
            (this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options =>
                 options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            services.AddAutoMapper(cfg => { cfg.AddProfile<AutoMapperProfile>(); });

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();

            services.AddScoped<ICompanyMemberRepository, CompanyMemberRepository>();
            services.AddScoped<ICompanyMemberService, CompanyMemberService>();

            return services;
        }
    }
        
}
