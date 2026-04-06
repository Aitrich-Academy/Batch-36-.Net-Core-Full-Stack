using JobSeeker.Interfaces;
using JobSeeker.Model;
using JobSeeker.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSeeker.Manager
{
    public class UserManager:IMenu
    {
        private User loggedUser;
        private IJobRepository jobRepository = new JobRepository();
        private List<Job> appliedJobs = new List<Job>(); // to track applied jobs
        JobManager jobs = new JobManager();
        public UserManager(User loggedUser)
        {
            this.loggedUser = loggedUser;
        }
        public UserManager()
        {

        }

        public void DisplayMenu()
        {
            ShowJobSeekerMenu();
        }
        public void ShowJobSeekerMenu()
        {
                //  Console.WriteLine("Welcome " + loggedInJobSeeker.FirstName + "!");
                Console.WriteLine("1. List all jobs");
                Console.WriteLine("2. My profile");
                Console.WriteLine("3. Apply for a Job");
                Console.WriteLine("4. Logout");
                


                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                    jobs.ListJobs();
                        ShowJobSeekerMenu();
                        break;
                    case "2":
                        ViewProfile();
                        ShowJobSeekerMenu();
                        break;
                    case "3":
                        ApplyJob();
                        ShowJobSeekerMenu();
                        break;
                    
                    case "4":
                        Logout();
                        break;


                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        ShowJobSeekerMenu();
                        break;
                }

            }
        private void ViewProfile()
        {
            Console.WriteLine("\n---------------- Profile ----------------");
            Console.WriteLine("First Name : " + loggedUser.FirstName);
            Console.WriteLine("Last Name  : " + loggedUser.LastName);
            Console.WriteLine("Email      : " + loggedUser.Email);
            Console.WriteLine("Phone      : " + loggedUser.Phone);
            Console.WriteLine("-----------------------------------------\n");
        }


        private void ApplyJob()
        {
            bool Applying = true;

            while (Applying)
            {
                try
                {
                    Console.WriteLine("\n---------Available Jobs---------");

                    // Display all jobs
                    foreach (var j in jobRepository.GetAllJobs())
                    {
                        Console.WriteLine(j.Id + " - " + j.Title);
                    }

                    Console.WriteLine("Enter Job ID to apply:");
                    int jobId = Convert.ToInt32(Console.ReadLine());

                    // Find job
                    var job = jobRepository
                              .GetAllJobs()
                              .FirstOrDefault(j => j.Id == jobId);

                    if (job == null)
                    {
                        Console.WriteLine("Job not found");
                    }
                    else if (appliedJobs.Any(j => j.Id == jobId))
                    {
                        Console.WriteLine("You already applied for this job");
                    }
                    else
                    {
                        appliedJobs.Add(job);
                        Console.WriteLine("Applied successfully for: " + job.Title);
                    }

                    // Ask if user wants to apply more jobs
                    bool validInput = false;
                    while (!validInput)
                    {
                        Console.WriteLine("Do you want to apply for more jobs? (y/n):");
                        string input = Console.ReadLine().Trim().ToLower();

                        if (input == "y")
                        {
                            validInput = true;  // continue loop
                        }
                        else if (input == "n")
                        {
                            validInput = true;
                            Applying = false; // exit loop
                            Console.WriteLine("Exiting Apply Job...\n");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input, please enter 'y' or 'n'");
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please enter a valid Job ID.");
                }
            }
        }
        
        public void Logout()
        {
            loggedUser = new User();
            Console.WriteLine("Logged out successfully!");

        }

    }
    
}
