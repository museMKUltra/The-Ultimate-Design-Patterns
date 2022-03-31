using DesignPatterns.Command.fx;

namespace DesignPatterns.Command
{
    public class AddCustomerCommand : ICommand
    {
        private CustomerService _customerService;

        public AddCustomerCommand(CustomerService customerService)
        {
            _customerService = customerService;
        }

        public void Execute()
        {
            _customerService.addCustomer();
        }
    }
}