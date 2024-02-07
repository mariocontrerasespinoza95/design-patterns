using Command.CommandFramework;

namespace Command;

public class AddCustomerCommand(CustomerService customerService) : ICommand
{
    public void Execute()
    {
        customerService.AddCustomer();
    }
}
