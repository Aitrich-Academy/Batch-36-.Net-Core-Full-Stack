using Microsoft.EntityFrameworkCore;
namespace Student_ManagmentSystemMVC_MachneTst.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Student> Students { get; set; }
    }
}
