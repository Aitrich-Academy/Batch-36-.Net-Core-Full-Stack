using MachineTest_Blazor.Interface;
using MachineTest_Blazor.Model;
using Microsoft.EntityFrameworkCore;

namespace MachineTest_Blazor.Repository
{
    public class CustomerRepository:ICustomerRepository
    {
        private readonly AppDBContext _context;
        public CustomerRepository(AppDBContext context)
        {
            _context = context;
        }

        public async Task AddCustomersAsync(Customer customer)
        {
            await _context.Customers.AddAsync(customer);
            await _context.SaveChangesAsync();
        }
        public async Task<List<Customer>> GetAllCustomerAsync()
        {
            return await _context.Customers.ToListAsync();
        }
    }
}
