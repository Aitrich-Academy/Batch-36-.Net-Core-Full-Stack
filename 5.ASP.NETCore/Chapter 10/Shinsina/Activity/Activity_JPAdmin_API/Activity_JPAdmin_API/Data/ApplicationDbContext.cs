using Activity_JPAdmin_API.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace Activity_JPAdmin_API.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options) { }
        public DbSet<Employee> Employees { get; set; }
    }
}
