using Microsoft.EntityFrameworkCore;
using System.Data;
namespace MachineTest_Blazor.Model
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions options) : base(options) { }
        public DbSet<Customer> Customers { get; set; }
    }
}
