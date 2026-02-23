using System;

internal class Program
{
    struct Admin
    {
        public string Email;
        public string Password;
    }
    struct Registration
    {
        public string Id;
        public string DateApplied;
        public string Company;
        public string Type;
        public string Position;
        public string Status;
    }

    private static void Main(string[] args)
    {
        Admin admin = new Admin
        {
            Email = "admin@gmail.com",
            Password = "1234"
        };
        Registration[] registrations = new Registration[5];

        registrations[0] = new Registration
        {
            Id = "APL-03323",
            DateApplied = "June 1 2022,10:23 AM",
            Company = "TCS",
            Type = "FREELANCE",
            Position = "Intern UI Designer",
            Status = "Pending"
        };

        registrations[1] = new Registration
        {
            Id = "APL-03324",
            DateApplied = "June 2 2022,11:23 AM",
            Company = "Aitrich",
            Type = "PART TIME",
            Position = "Junior UX Designer",
            Status = "On-Hold"
        };

        registrations[2] = new Registration
        {
            Id = "APL-03325",
            DateApplied = "March 3 2022,1:45 PM",
            Company = "Microsoft",
            Type = "FREELANCE",
            Position = "Dotnet Developer",
            Status = "Pending"
        };

        registrations[3] = new Registration
        {
            Id = "APL-03326",
            DateApplied = "May 1 2022,1:23 AM",
            Company = "TCS",
            Type = "PART TIME",
            Position = "Senior UI Designer",
            Status = "Candidate"
        };

        registrations[4] = new Registration
        {
            Id = "APL-03327",
            DateApplied = "Nov 1 2022,04:23 PM",
            Company = "Wipro",
            Type = "FREELANCE",
            Position = "Intern Java Developer",
            Status = "Pending"
        };

        bool isLoggedIn = false;

        Console.WriteLine("Welcome to Hire Me Now Job Portal");

        while (true)
        {
           
            if (!isLoggedIn)
            {
                Console.WriteLine("\n1. Login");
                Console.WriteLine("2. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Write("Enter your Email: ");
                    string email = Console.ReadLine();

                    Console.Write("Enter your Password: ");
                    string password = Console.ReadLine();

                    if (email == admin.Email && password == admin.Password)
                    {
                        Console.WriteLine("Successfully Logged In");
                        isLoggedIn = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Credentials");
                    }
                }
                else if (choice == "2")
                {
                    //Console.WriteLine("Exiting Application...");
                    break;
                }
                //else
                //{
                //    Console.WriteLine("Invalid Choice");
                //}
            }
            // 🔓 If Logged In (Admin Menu)
            else
            {
                Console.WriteLine("\n1. New Registrations");
                Console.WriteLine("2. List all Job Seekers");
                Console.WriteLine("3. Search Job Seekers");
                Console.WriteLine("4. Logout");
                Console.Write("Select any option: ");
                string adminChoice = Console.ReadLine();

                switch (adminChoice)
                {
                    case "1":
                        Console.WriteLine("\nNew Registrations:\n");

                        Console.WriteLine("ID         | Date Applied           | Company    | Type       | Position               | Status");
                        Console.WriteLine("-----------------------------------------------------------------------------------------------");

                        for (int i = 0; i < registrations.Length; i++)
                        {
                            Console.WriteLine(
                                $"{registrations[i].Id,-10} | " +
                                $"{registrations[i].DateApplied,-22} | " +
                                $"{registrations[i].Company,-10} | " +
                                $"{registrations[i].Type,-10} | " +
                                $"{registrations[i].Position,-20} | " +
                                $"{registrations[i].Status}"
                            );
                        }

                        break;

                    case "2":
                        Console.WriteLine("List all Job Seekers selected.");
                        break;

                    case "3":
                        Console.Write("Enter Company name to search: ");
                        string search = Console.ReadLine();

                        //Console.WriteLine("\nSearch Results:\n");

                        //for (int i = 0; i < registrations.Length; i++)
                        //{
                        //    if (registrations[i].Company.ToLower() == search.ToLower())
                        //    {
                        //        Console.WriteLine(
                        //            $"{registrations[i].Id} | {registrations[i].Company} | {registrations[i].Position} | {registrations[i].Status}"
                        //        );
                        //    }
                        //}

                        break;

                    case "4":
                        isLoggedIn = false;
                        Console.WriteLine("Logged out successfully!");
                        break;

                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }
            }
        }
    }
}