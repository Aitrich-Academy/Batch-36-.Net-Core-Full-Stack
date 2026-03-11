using BankAccount;

internal class Program
{
    private static void Main(string[] args)
    {
        SavingsAccount savings = new SavingsAccount("Dixson", 100);
        CurrentAccount current = new CurrentAccount("Neethu", 500);

        Console.WriteLine("Bank Account ");
        savings.CalculateInterest();

        savings.ApplyMaintenanceFee(10);
        current.ApplyMaintenanceFee(10);
        current.CalculateInterest();
    }
}