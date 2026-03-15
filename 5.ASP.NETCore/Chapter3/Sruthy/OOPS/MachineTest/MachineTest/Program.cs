using MachineTest;

internal class Program
{
    private static void Main(string[] args)
    {
        SavingsAccount account = new SavingsAccount();
        account.AccountHolder = "Deepa";
        account.Balance = 25000.35;
        account.CalculateInterest();
        account.ApplyMaintenanceFee();

        CurrentAccount account1 = new CurrentAccount();
        account1.AccountHolder = "Dominick";
        account1.Balance = 10024.25;
        account1.CalculateInterest();
        account1.ApplyMaintenanceFee();
    }
}