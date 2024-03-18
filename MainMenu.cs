
namespace ClhBankApp
{
    public class MainMenu
{
    // var customerAccount = new Customer;
    public void LoginMenu()
    {
        Console.WriteLine("welcome to CLH banking App");
        Console.WriteLine("enter 1 to open account\n2 to login\n3 to logout");
        int choice = int.Parse(Console.ReadLine());

        switch(choice)
        {
            case 1:
                OpenAccountMenu();
            break;
        }

    
    static void OpenAccountMenu()
    {
        Console.WriteLine("enter 0 for savings account \n1 for current account");
        int accType = int.Parse(Console.ReadLine());
        var accountType = new Customer();
        accountType.OpenAccount(accType);
        Console.WriteLine("enter your first name: ");
        string firstName = Console.ReadLine();
        Console.WriteLine("enter your last name: ");
        string lastName = Console.ReadLine();
        Console.WriteLine("enter your address: ");
        string address = Console.ReadLine();
        Console.WriteLine("enter your date of birth: ");
        Console.WriteLine("enter your email: ");
        string email = int.Parse(Console.ReadLine());
        Console.WriteLine("enter your password: ");
        string password = Console.ReadLine();
        Customer.CustomerOpenAccount(firstName, lastName, address, email, password);
    }

        
    }


}
}
