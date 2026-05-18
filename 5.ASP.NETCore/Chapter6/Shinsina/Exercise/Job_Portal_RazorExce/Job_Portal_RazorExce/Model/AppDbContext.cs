using Microsoft.EntityFrameworkCore;
namespace Job_Portal_RazorExce.Model
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Job>Jobs {  get; set; }
        public DbSet<JobApplication> JobApplications { get; set; }
        public DbSet<User> Users { get; set; }
        
       
    }
}
