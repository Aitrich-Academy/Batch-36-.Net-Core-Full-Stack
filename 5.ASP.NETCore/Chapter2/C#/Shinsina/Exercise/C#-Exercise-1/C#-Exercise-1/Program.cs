using System;

namespace JobPortal
{
    class Program
    {
        struct User
        {
            public string Name;
            public string Email;
            public string Password;
        }

        struct Job
        {
            public int Id;
            public string Title;
            public string Experience;
            public string Company;
            public string Location;
            public string Salary;
        }

        static void Main(string[] args)
        {
            User[] users = new User[10];   // fixed size array
            int userCount = 0;             // track number of users

            Job[] jobs = new Job[]
            {
                new Job { Id = 1, Title = "Software Engineer", Experience = "3+ years", Company = "Acme Inc.", Location = "New York, NY", Salary = "$100,000 - $150,000" },
                new Job { Id = 2, Title = "Product Manager", Experience = "5+ years", Company = "Globex Corp.", Location = "San Francisco, CA", Salary = "$120,000 - $180,000" },
                new Job { Id = 3, Title = "Marketing Specialist", Experience = "2+ years", Company = "Hooli Enterprises", Location = "Seattle, WA", Salary = "$70,000 - $90,000" }
            };

            User? loggedInUser = null;

            while (true)
            {
                Console.WriteLine("\nWelcome to the job portal!");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
               

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        if (userCount < users.Length)
                        {
                            Console.Write("Enter Name: ");
                            users[userCount].Name = Console.ReadLine();

                            Console.Write("Enter Email: ");
                            users[userCount].Email = Console.ReadLine();

                            Console.Write("Enter Password: ");
                            users[userCount].Password = Console.ReadLine();

                            userCount++;
                            Console.WriteLine("Registration successful!");
                            Console.WriteLine("Welcome to JobSeeker Portal!!");
                        }
                        else
                        {
                            Console.WriteLine("User limit reached!");
                        }
                        break;

                    case "2":
                        Console.Write("Please enter your Email: ");
                        string email = Console.ReadLine();

                        Console.Write("Please enter your Password: ");
                        string password = Console.ReadLine();

                        bool found = false;

                        for (int i = 0; i < userCount; i++)
                        {
                            if (users[i].Email == email && users[i].Password == password)
                            {
                                loggedInUser = users[i];
                                Console.WriteLine("Login successful!");
                                Console.WriteLine("Welcome " + users[i].Name);
                                found = true;
                                break;
                            }
                        }

                        if (!found)
                        {
                            Console.WriteLine("Invalid email or password.");
                        }
                        break;

                            case "3":
                                return;

                            default:
                                Console.WriteLine("Invalid choice!");
                                break;
                        }

                // If logged in, show user menu
                while (loggedInUser != null)
                {
                    Console.WriteLine("\n1. List all jobs");
                    Console.WriteLine("2. My profile");
                    Console.WriteLine("3. Logout");

                    string userChoice = Console.ReadLine();

                    switch (userChoice)
                    {
                        case "1":
                            Console.WriteLine("\nJobs Available:");
                            Console.WriteLine("ID  Title                 Experience   Company               Location           Salary");

                            foreach (var job in jobs)
                            {
                                Console.WriteLine($"{job.Id}   {job.Title,-20} {job.Experience,-12} {job.Company,-20} {job.Location,-18} {job.Salary}");
                            }
                            break;

                        case "2":
                            Console.WriteLine("\n--- My Profile ---");
                            Console.WriteLine("Name: " + loggedInUser.Value.Name);
                            Console.WriteLine("Email: " + loggedInUser.Value.Email);
                            break;

                        case "3":
                            loggedInUser = null;
                            Console.WriteLine("Logged out successfully!");
                            break;

                        default:
                            Console.WriteLine("Invalid choice!");
                            break;
                    }
                }
            }
        }
            }
}
