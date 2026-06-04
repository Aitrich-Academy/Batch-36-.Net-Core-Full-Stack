using JobProvider_App.Model;
using Microsoft.EntityFrameworkCore;

namespace JobProviderApp.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options)
            : base(options)
        {
        }

        public DbSet<JobProvider> JobProviders { get; set; }
        public DbSet<Job> Jobs { get; set; }
    }
}
