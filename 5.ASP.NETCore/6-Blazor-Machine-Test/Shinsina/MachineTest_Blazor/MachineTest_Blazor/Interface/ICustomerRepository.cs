using MachineTest_Blazor.Model;

namespace MachineTest_Blazor.Interface
{
    public interface ICustomerRepository
    {
       Task AddCustomersAsync(Customer customer);
       Task<List<Customer>>GetAllCustomerAsync();
    }
}
