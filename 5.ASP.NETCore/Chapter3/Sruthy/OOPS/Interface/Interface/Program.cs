using Interface;

internal class Program
{
    private static void Main(string[] args)
    {
        IPayment ipay=new CreditCardPayment();
        IPayment ipay1 =new UPIPayment();
        double cPay = ipay.Pay(25000.75);
        Console.WriteLine("Credit Card payment is: " + cPay);
        double uPay = ipay1.Pay(23987.25);
        Console.WriteLine("UPI payment is: " + uPay);
        double cRefund = ipay.Refund(5000.75);
        Console.WriteLine("Credit Card Refund is: " + cRefund);
        double uRefund = ipay1.Refund(239.00);
        Console.WriteLine("UPI Refund is: " + uRefund);
        Console.ReadLine();


        IPower power;
        IVolume volume;
        power = new Television();
        power.TurnOn();
 
        volume=new Television();
        volume.IncreaseVolume();
        volume.DecreaseVolume();
        power.TurnOff();
        Console.ReadLine() ;

        ILogin login;
        login = new AdminLogin();
        Console.WriteLine("--------Admin Login-------------------");
        login.Authenticate("admin", "admin");
        login.Authenticate("user", "user");
        login = new UserLogin();
        Console.WriteLine("--------User Login-------------------");
        login.Authenticate("user", "user");
        login.Authenticate("admin", "admin");
        Console.ReadLine();

    
        SavingsAccount account = new SavingsAccount(5750.45);
        account.Deposit(2500.00);
        account.Deposit(1600.50); 
        account.Deposit(4200.75);
        account.Withdraw(3000);
        account.GenerateReport();


        Console.ReadLine();

    }
}