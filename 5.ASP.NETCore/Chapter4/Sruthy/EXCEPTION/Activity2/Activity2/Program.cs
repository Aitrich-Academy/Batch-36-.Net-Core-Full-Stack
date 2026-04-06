using Activity2;
using System.Runtime.InteropServices;
using System.Security.Principal;

internal class Program
{
    static BankAccount[] bankaccount = new BankAccount[100];
    static int count = 0;
    static int nxtAcct = 10000;
    private static void Main(string[] args)
    {
        int accNo;
        BankAccount acc;

        while (true)
        {
            Console.WriteLine("\n\n--------Welocome--------");
            Console.WriteLine("1. Create an Account");
            Console.WriteLine("2. Deposit an Amount");
            Console.WriteLine("3. Withdraw an Amount");
            Console.WriteLine("4. Display Account Details");
            Console.WriteLine("5. Exit the Application\n");
            Console.Write("Enter Your choice: ");
            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (choice < 1 && choice > 5) { Console.WriteLine("Enter a Valid Choice"); }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Select Account Type:\n");
                        Console.WriteLine("1. Savings Account");
                        Console.WriteLine("2. Current Account");
                        Console.Write("Type: ");
                        int type = Convert.ToInt32(Console.ReadLine());
                        int acctNo;
                        string acctHolderName;
                        Console.WriteLine();
                        if (type == 1)
                        {
                            acctNo = nxtAcct++;
                            Console.WriteLine("Enter Account Holder's Name:");
                            acctHolderName = Console.ReadLine();
                            SavingsAccount account = new SavingsAccount();
                            account.AccountNumber = acctNo;
                            account.AccountHolderName = acctHolderName;
                            account.Balance = 0;
                            bankaccount[count] = account;
                            count++;
                            Console.WriteLine("Account Created Successfully!!!");

                        }
                        else if (type == 2)
                        {
                            acctNo = nxtAcct++;
                            Console.WriteLine("Enter Account Holder's Name:");
                            acctHolderName = Console.ReadLine();
                            CurrentAccount account1 = new CurrentAccount();
                            account1.AccountNumber = acctNo;
                            account1.AccountHolderName = acctHolderName;
                            account1.Balance = 0;
                            bankaccount[count] = account1;
                            count++;
                            Console.WriteLine("Account Created Successfully!!!");

                        }
                        else
                        {
                            Console.WriteLine("Enter a valid Type of Account\n!!!");

                        }
                        break;


                    case 2:

                        acc = null;

                        while(acc==null)
                        {
                            try
                            {

                                Console.Write("Enter Account Number: ");
                                accNo = Convert.ToInt32(Console.ReadLine());



                                for (int i = 0; i < count; i++)
                                {
                                    if (bankaccount[i].AccountNumber == accNo)
                                    {
                                        acc = bankaccount[i];
                                        break;
                                    }
                                }

                                if (acc != null)
                                {
                                    Console.Write("Enter Deposit Amount: ");
                                    double amount = Convert.ToDouble(Console.ReadLine());

                                    acc.Deposit(amount);
                                }
                                else
                                {
                                    Console.WriteLine("Account not found");
                                }
                            }
                            catch(FormatException)
                            {
                                Console.WriteLine("Please Enter a valid Account Number");

                            }
                            }

                        break;


                    case 3:
                        acc = null;

                        while (acc == null)
                        {
                            try
                            {
                                Console.Write("Enter Account Number: ");
                                accNo = Convert.ToInt32(Console.ReadLine());



                                for (int i = 0; i < count; i++)
                                {
                                    if (bankaccount[i].AccountNumber == accNo)
                                    {
                                        acc = bankaccount[i];
                                        break;
                                    }




                                    else
                                    {
                                        Console.WriteLine("Account not found");
                                    }
                                }

                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Invalid Account Number!!!");
                            }
                        }
                            while (true)
                            {
                                try
                                {
                                    Console.Write("Enter Withdraw Amount: ");
                                    double amount = Convert.ToDouble(Console.ReadLine());

                                    acc.Withdraw(amount); // Polymorphic call; may throw InsufficientBalanceException
                                    break; // Exit loop once withdrawal succeeds
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Invalid input. Please enter a numeric amount.");
                                }
                                catch (InvalidAmountException ex)
                                {
                                    Console.WriteLine(ex.Message); // e.g., negative amount
                                }
                                catch (InsufficientBalanceException ex)
                                {
                                    Console.WriteLine(ex.Message);
                                    Console.WriteLine("Please enter a lower amount.");
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Error: " + ex.Message);
                                }
                            }
                        
                        
                        break;

                    case 4:
                        try
                        {

                            Console.Write("Enter Account Number: ");
                            accNo = Convert.ToInt32(Console.ReadLine());

                            acc = null;

                            for (int i = 0; i < count; i++)
                            {
                                if (bankaccount[i].AccountNumber == accNo)
                                {
                                    acc = bankaccount[i];
                                    break;
                                }
                            }

                            if (acc != null)
                            {
                                Console.WriteLine("\n---------Account Details----------\n");
                                acc.DisplayAccountDetails();
                            }
                            else
                            {
                                Console.WriteLine("Account not found");
                            }

                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine("Invalid account number!!!!");
                        }
                        break;
                    //for (int i = 0; i < count; i++)
                    //{
                    //    Console.WriteLine("\nAccount " + (i + 1));
                    //    bankaccount[i].DisplayAccountDetails();
                    //    Console.WriteLine();
                    //}

                    //break;



                    case 5:
                        Console.WriteLine("\nThanks for visiting !!!! \n\n\n");
                        return;



                    default:
                        Console.WriteLine("Invalid Choice!!!!");
                        break;



                }//switch

            }//try

            catch (FormatException ex)
            {
                Console.WriteLine("Error: Not a valid input!!!" );
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);

            }


        }
    }
}
