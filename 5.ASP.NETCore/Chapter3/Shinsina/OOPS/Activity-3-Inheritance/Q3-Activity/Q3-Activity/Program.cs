using Q3_Activity;

internal class Program
{
    private static void Main(string[] args)
    {
        // Savings Account
        SavingsAccount saving = new SavingsAccount();
        saving.accountNumber = "SA1001";
        saving.balance = 5000;
        saving.interestRate = 5;

        saving.deposit(2000);
        saving.addInterest();
        saving.displayBalance();

        // Current Account
        CurrentAccount current = new CurrentAccount();
        current.accountNumber = "CA2001";
        current.balance = -3000;
        current.overdraftLimit = 5000;

        current.deposit(1000);
        current.checkOverdraft();
        current.displayBalance();
    



}
}