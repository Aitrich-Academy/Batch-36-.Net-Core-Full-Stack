using Microsoft.EntityFrameworkCore;

namespace JobPortalManagment.Migrations.Model
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Job> Job { get; set; }
    }
}
