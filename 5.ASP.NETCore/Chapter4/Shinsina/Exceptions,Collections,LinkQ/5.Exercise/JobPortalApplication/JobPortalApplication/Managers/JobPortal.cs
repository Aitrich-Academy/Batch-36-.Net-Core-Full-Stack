using JobPortalApplication.Enums;
using JobPortalApplication.Interfaces;
using JobPortalApplication.Models;
using JobPortalApplication.Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace JobPortalApplication.Managers
{
    public class JobPortal:IMenu
    {
        UserManager userManager = new UserManager();
        JobManager jobManager;
        JobRepository jobRepo = new JobRepository();

        public JobPortal()
        {
            jobManager = new JobManager(jobRepo);
        }

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("\nWELCOME TO JOB PORTAL");
                Console.WriteLine("1.Login");
                Console.WriteLine("2.Register");
                Console.WriteLine("3.Exit");
                Console.Write("Choose any Option: ");

                string input = Console.ReadLine();
                int choice;
                if (!int.TryParse(input, out choice))
                {
                    Console.WriteLine("Invalid input! Please enter a number.");
                    continue;
                }

                try
                {
                    switch (choice)
                    {
                        case 1:
                            userManager.Login();

                            if (userManager.LoggedUser != null)
                            {
                                AfterLogin(); // Only go to menu if login is successful
                            }
                            else
                            {
                                Console.WriteLine("Invalid credentials. Returning to main menu.");
                            }
                            break;

                        case 2:
                            userManager.Register();
                            break;

                        case 3:
                            Console.WriteLine("Exiting...");
                            return;

                        default:
                            Console.WriteLine("Invalid option, try again!");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        private void AfterLogin()
        {
            if (userManager.LoggedUser.Role == Role.Provider)
            {
                ProviderMenu();
            }
            else
            {
                SeekerMenu();
            }
        }

        public void ProviderMenu()
        {
            while (true)
            {
                Console.WriteLine("\nPROVIDER MENU");
                Console.WriteLine("1.Post Job");
                Console.WriteLine("2.View Jobs");
                Console.WriteLine("3.Logout");
                Console.Write("Choose Option: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        jobManager.PostJob();
                        break;

                    case 2:
                        jobManager.ViewJobs();
                        break;

                    case 3:
                        Console.WriteLine("Logged out successfully");
                        userManager.LoggedUser = null;
                        return;

                    default:
                        Console.WriteLine("Invalid choice, try again!");
                        break;
                }
            }
        }

        public void SeekerMenu()
        {
            SeekerManager seekerManager = new SeekerManager(jobRepo, userManager.LoggedUser);

            while (true)
            {
                Console.WriteLine("\nSEEKER MENU");
                Console.WriteLine("1.List all Jobs");
                Console.WriteLine("2.Saved Jobs");
                Console.WriteLine("3.Applied Jobs");
                Console.WriteLine("4.My Profile");
                Console.WriteLine("5.Logout");
                Console.Write("Choose Option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        seekerManager.ListJobsWithOptions();
                        break;

                    case "2":
                        seekerManager.ViewSavedJobs();
                        break;

                    case "3":
                        seekerManager.ViewAppliedJobs();
                        break;

                    case "4":
                        seekerManager.Profile(userManager.LoggedUser);
                        break;

                    case "5":
                        seekerManager.Logout();
                        userManager.LoggedUser = null;
                        return;

                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            }
        }
    }
    //public class JobPortal
    //{


    //    UserManager userManager = new UserManager();
    //    JobManager jobManager;
    //    SeekerManager seekerManager;
    //    JobRepository jobRepo = new JobRepository();
    //    //SeekerManager seekerManager = new SeekerManager(jobRepo, userManager.LoggedUser);
    //    public JobPortal()
    //    {
    //        jobManager = new JobManager(jobRepo);
    //        //seekerManager = new SeekerManager(jobRepo);
    //    }



    //    public void Start()
    //    {
    //        while (true)
    //        {
    //            Console.WriteLine("\nWELCOME TO JOB PORTAL");
    //            Console.WriteLine("1.Login");
    //            Console.WriteLine("2.Register");
    //            Console.WriteLine("3.Exit");
    //            Console.WriteLine("Choose any Option :");
    //            int choice = Convert.ToInt32(Console.ReadLine());

    //            try
    //            {
    //                switch (choice)
    //                {
    //                    case 1:
    //                        userManager.Login();

    //                            if (userManager.LoggedUser != null) 
    //                            {
    //                                AfterLogin();
    //                            }
    //                            else
    //                            {
    //                                Start();
    //                            }

    //                        break;


    //                    case 2:
    //                        userManager.Register();
    //                        break;

    //                    case 3:
    //                        return;
    //                }
    //            }
    //            catch (Exception ex)
    //            {
    //                Console.WriteLine(ex.Message);
    //            }
    //        }
    //    }

    //    private void AfterLogin()
    //    {

    //        if (userManager.LoggedUser.Role == Role.Provider)
    //        {
    //            ProviderMenu();
    //        }
    //        else
    //        {
    //            SeekerMenu();
    //        }
    //    }

    //    public void ProviderMenu()
    //    {
    //        while (true)
    //        {
    //            Console.WriteLine("\nPROVIDER MENU");
    //            Console.WriteLine("1.Post Job");
    //            Console.WriteLine("2.View Jobs");
    //            Console.WriteLine("3.Logout");
    //            int choice1 = int.Parse(Console.ReadLine());

    //            switch (choice1)
    //            {
    //                case 1:
    //                    jobManager.PostJob();
    //                    break;

    //                case 2:
    //                    jobManager.ViewJobs();
    //                    break;

    //                case 3:
    //                    Console.WriteLine("Logged out successfully");
    //                    return; // exits the method

    //                default:
    //                    Console.WriteLine("Invalid choice, try again!");
    //                    break;
    //            }
    //        }

    //    }


    //    public void SeekerMenu()
    //    {
    //        SeekerManager seekerManager = new SeekerManager(jobRepo, userManager.LoggedUser); 

    //        while (true)
    //        {
    //            Console.WriteLine("\nSEEKER MENU");
    //            Console.WriteLine("1.List all Jobs");
    //            Console.WriteLine("2.Saved Jobs");
    //            Console.WriteLine("3.Applied Jobs");
    //            Console.WriteLine("4.My Profile");
    //            Console.WriteLine("5.Logout");

    //            string choice = Console.ReadLine();

    //            switch (choice)
    //            {
    //                case "1":
    //                    seekerManager.ListJobsWithOptions();
    //                    break;

    //                case "2":
    //                    seekerManager.ViewSavedJobs();
    //                    break;

    //                case "3":
    //                    seekerManager.ViewAppliedJobs();
    //                    break;

    //                case "4":
    //                    seekerManager.Profile(userManager.LoggedUser);
    //                    break;

    //                case "5":
    //                    seekerManager.Logout();
    //                    return;

    //                default:
    //                    Console.WriteLine("Invalid Option");
    //                    break;
    //            }
    //        }
    //    }
    //}
}
