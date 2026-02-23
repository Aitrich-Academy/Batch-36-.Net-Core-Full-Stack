// See https://aka.ms/new-console-template for more information
using System.Numerics;

internal class Program
{
    public struct CompanyMember
    {
        public int UserId;
        public string Name;
        public string Designation;
        public string Email;
        public long Phone;
    }
    private static void Main(string[] args)
    {
        string email = "jobprovider@gmail.com";
        string password = "123";
        Console.WriteLine("Welcome To The Hire Me Now Job Portal!");
        while (true)
        {
            Console.WriteLine("Menu\n");
            Console.WriteLine("1. Login\n");
            Console.WriteLine("2. Exit");
            Console.WriteLine("Enter Your Choice: ");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 2)
            {
                break;

            }
            if (choice != 1)
            {
                Console.WriteLine("Invalid Choice!!!!!");
                continue;

            }
            //while (true)
            //{
            //    Console.WriteLine("Please Enter your Email : ");
            //    string emailEnter = Console.ReadLine();

            //    if (emailEnter == email)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Incorrect Username!!!! Try again...");
            //    }
            //    while (true)
            //    {
            //        Console.WriteLine("Please Enter your Password: ");
            //        string passwordEnter = Console.ReadLine();
            //        if (passwordEnter == password)
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Incorrect Password!!! Try again...");
            //        }
            //    }
            //    Console.WriteLine("Login Successfull!!!");
            while (true)
            {
                Console.WriteLine("Please Enter your Email : ");
                string emailEnter = Console.ReadLine();

                if (emailEnter == email)
                {
                    break; // correct email
                }
                else
                {
                    Console.WriteLine("Incorrect Username!!!! Try again...");
                }
            }

            // PASSWORD LOOP
            while (true)
            {
                Console.WriteLine("Please Enter your Password: ");
                string passwordEnter = Console.ReadLine();

                if (passwordEnter == password)
                {
                    break; // correct password
                }
                else
                {
                    Console.WriteLine("Incorrect Password!!! Try again...");
                }
            }

            Console.WriteLine("Login Successful!!!");

            bool loggedIn = true;
            CompanyMember[] members = new CompanyMember[0];
            int userIdCounter = 1;
            while (loggedIn)
            {
                Console.WriteLine("\n1. List all company members");
                Console.WriteLine("2. Add company member");
                Console.WriteLine("3. Logout");
                Console.Write("Enter choice: ");
                int menuChoice = int.Parse(Console.ReadLine());
                switch (menuChoice)
                {
                    case 1:
                        Console.WriteLine("\nCompany Members :");
                        Console.WriteLine("UserId\tName\tDesignation\tEmail\t\t\tPhone");

                        if (members.Length == 0)
                        {
                            Console.WriteLine("No members found.");
                        }
                        else
                        {
                            foreach (CompanyMember m in members)
                            {
                                Console.WriteLine($"{m.UserId}\t{m.Name}\t{m.Designation}\t{m.Email}\t\t\t{m.Phone}");
                            }
                        }
                        break;

                    case 2:
                        CompanyMember newMember = new CompanyMember();

                        newMember.UserId = userIdCounter++;

                        Console.Write("Please enter company member name: ");
                        newMember.Name = Console.ReadLine();

                        Console.Write("Please enter email: ");
                        newMember.Email = Console.ReadLine();

                        Console.Write("Please enter Designation: ");
                        newMember.Designation = Console.ReadLine();

                        Console.Write("Please enter your phone number: ");
                        newMember.Phone = long.Parse(Console.ReadLine());

                        Array.Resize(ref members, members.Length + 1);
                        members[members.Length - 1] = newMember;

                        Console.WriteLine("Registration successful!!!\n");
                        break;

                    case 3:
                        Console.WriteLine("Logged Out Successfully!!!\n");
                        loggedIn = false;
                        break;

                    default:
                        Console.WriteLine("Invalid Option!!\n");
                        break;
                }



            }

        }
    }
}