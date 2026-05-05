using Microsoft.EntityFrameworkCore;
namespace basic_razor.Model

{
    public class AppDbContext:DbContext
    {
        internal object Employee;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Employee> Employees{ get; set; }
    }
}
