using MachineTest_Blazor.Interface;
using MachineTest_Blazor.Model;

namespace MachineTest_Blazor.Service
{
    public class CustomerService:ICustomerService
    {
        private readonly ICustomerRepository _repository;
        public CustomerService(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public async Task AddCustomersAsync(Customer customer)
        {
            await _repository.AddCustomersAsync(customer);
        }
        public async Task<List<Customer>> GetAllCustomerAsync()
        {
            return await _repository.GetAllCustomerAsync();
        }
    }
}
