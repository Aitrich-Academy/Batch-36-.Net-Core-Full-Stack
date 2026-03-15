using Exercise2.Enum;
using Exercise2.Interface;
using Exercise2.Model;
using Exercise2.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2.Manager
{
    public class PublicManager : ILogin, IMenu
    {
        User[] users = new User[50];
        int userCount = 0;
        Printer printer = new Printer();
        JobManager jobManager = new JobManager();
        AdminManager adminManager = new AdminManager();
        UserManager userManager = new UserManager();
        
        public bool Login(string email, string password)
        {
            for (int i = 0; i < userCount; i++)
            {
                if (users[i].Email == email && users[i].Password == password)
                {
                    Console.WriteLine("Login Successful");
                    DisplayMenu(users[i]);
                    return true;
                }
            }

            Console.WriteLine("Invalid Login");
            return false;
        }

        public void Register(User user)
        {
            user.Id = userCount+1;
            users[userCount++] = user;
            Console.WriteLine("Registration Successful");
        }

        public void DisplayMenu(object? userObj = null)
        {
            User user = (User)userObj;
    

            // Admin Menu
            if (user.Role == Roles.Admin)
            {
                bool exit = false;

                while (!exit)
                {
                    Console.WriteLine("\n==== ADMIN MENU ====");
                    Console.WriteLine("1 View Registrations");
                    Console.WriteLine("2 List Jobs");
                    Console.WriteLine("3 Add Job");
                    Console.WriteLine("4 Logout");
                    Console.Write("Enter choice: ");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("\nRegistered Users:");
                            adminManager.ViewRegistrations(users,userCount);
                            break;

                        case 2:
                            Console.WriteLine("\nAvailable Jobs:");
                            adminManager.ViewJobs(jobManager);
                            break;

                        case 3:
                            Job job = new Job();
                            Console.Write("Title: ");
                            job.Title = Console.ReadLine();
                            Console.Write("Company: ");
                            job.Company = Console.ReadLine();
                            Console.Write("Location: ");
                            job.Location = Console.ReadLine();
                            Console.Write("Salary Range: ");
                            job.SalaryRange = Console.ReadLine();
                            Console.Write("Job Type: ");
                            job.JobType = Console.ReadLine();
                            Console.Write("Experience (0=Fresher,1=Mid,2=Senior): ");
                            job.ExperienceLevel = (ExperienceLevels)Convert.ToInt32(Console.ReadLine());
                            jobManager.AddJob(job);
                            Console.WriteLine("Job added successfully!");
                            break;

                        case 4:
                            exit = true;
                            Console.WriteLine("Logging out...");
                            break;

                        default:
                            Console.WriteLine("Invalid option.");
                            break;
                    }
                }
            }

            // JobSeeker Menu
            else if (user.Role == Roles.JobSeeker)
            {
                bool exit = false;

                while (!exit)
                {
                    Console.WriteLine("\n==== JOB SEEKER MENU ====");
                    Console.WriteLine("1 View Jobs");
                    Console.WriteLine("2 Apply Job");
                    Console.WriteLine("3 Logout");
                    Console.Write("Enter choice: ");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            userManager.ViewJobs(jobManager);
                            break;

                        case 2:
                            Console.Write("Enter Job ID to apply: ");
                            int jobId = Convert.ToInt32(Console.ReadLine());
                            userManager.ApplyJob(jobManager, jobId);
                            break;

                        case 3:
                            exit = true;
                            Console.WriteLine("Logging out...");
                            break;

                        default:
                            Console.WriteLine("Invalid option.");
                            break;
                    }
                }
            }
        }
    }
}
