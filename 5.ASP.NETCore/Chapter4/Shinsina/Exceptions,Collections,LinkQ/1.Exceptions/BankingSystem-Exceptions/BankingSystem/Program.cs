using System;

namespace BankingSystem
{
    class Program
    {
        static BankAccount[] accounts = new BankAccount[10];
        static int accountCount = 0;

        static void Main(string[] args)
        {
            int choice = 0;

            do
            {
                Console.WriteLine("\nBank Menu");
                Console.WriteLine("1 Create Account");
                Console.WriteLine("2 Deposit");
                Console.WriteLine("3 Withdraw");
                Console.WriteLine("4 Display Accounts");
                Console.WriteLine("5 Exit");

                try
                {
                    Console.Write("Enter choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                  
                    switch (choice)
                    {
                        case 1:
                            CreateAccount();
                            break;

                        case 2:
                            Deposit();
                            break;

                        case 3:
                            Withdraw();
                            break;

                        case 4:
                            DisplayAccounts();
                            break;

                        case 5:
                            Console.WriteLine("Exiting application...");
                            break;

                        default:
                            throw new InvalidChoiceException("Invalid menu choice. Please select between 1 and 5.");
                    }
                }
                catch (InvalidChoiceException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid numeric choice.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }

            } while (choice != 5);
        }

        static void CreateAccount()
        {
            if (accountCount >= accounts.Length)
            {
                Console.WriteLine("Account storage full.");
                return;
            }

            Console.WriteLine("1 Savings Account");
            Console.WriteLine("2 Current Account");

            int type = Convert.ToInt32(Console.ReadLine());

            Console.Write("Account Number: ");
            int accNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Account Holder Name: ");
            string name = Console.ReadLine();

            Console.Write("Initial Balance: ");
            decimal balance = Convert.ToDecimal(Console.ReadLine());

            if (type == 1)
            {
                SavingsAccount sa = new SavingsAccount();
                sa.AccountNumber = accNo;
                sa.AccountHolderName = name;
                sa.Balance = balance;

                Console.Write("Interest Rate: ");
                sa.InterestRate = Convert.ToDecimal(Console.ReadLine());

                accounts[accountCount] = sa;
            }
            else if (type == 2)
            {
                CurrentAccount ca = new CurrentAccount();
                ca.AccountNumber = accNo;
                ca.AccountHolderName = name;
                ca.Balance = balance;

                Console.Write("Overdraft Limit: ");
                ca.OverdraftLimit = Convert.ToDecimal(Console.ReadLine());

                accounts[accountCount] = ca;
            }
            else
            {
                throw new InvalidChoiceException("Invalid account type. Choose 1 or 2.");
            }

            accountCount++;
            Console.WriteLine("Account created successfully.");
        }

        static BankAccount FindAccount(int accNo)
        {
            for (int i = 0; i < accountCount; i++)
            {
                if (accounts[i].AccountNumber == accNo)
                    return accounts[i];
            }

            return null;
        }

        static void Deposit()
        {
            Console.Write("Enter Account Number: ");
            int accNo = Convert.ToInt32(Console.ReadLine());

            BankAccount acc = FindAccount(accNo);

            if (acc == null)
            {
                Console.WriteLine("Account not found.");
                return;
            }

            Console.Write("Enter Amount: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            acc.Deposit(amount);
        }

        static void Withdraw()
        {
            Console.Write("Enter Account Number: ");
            int accNo = Convert.ToInt32(Console.ReadLine());

            BankAccount acc = FindAccount(accNo);

            if (acc == null)
            {
                Console.WriteLine("Account not found.");
                return;
            }

            Console.Write("Enter Amount: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            acc.Withdraw(amount);
        }

        static void DisplayAccounts()
        {
            if (accountCount == 0)
            {
                Console.WriteLine("No accounts found.");
                return;
            }

            for (int i = 0; i < accountCount; i++)
            {
                accounts[i].DisplayAccountDetails();
                Console.WriteLine("------------------");
            }
        }
    }
}