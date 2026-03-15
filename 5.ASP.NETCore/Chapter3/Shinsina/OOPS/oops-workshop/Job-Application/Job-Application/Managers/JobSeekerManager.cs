using Job_Application.Models;
using System;
using System.Collections.Generic;
using System.Text;
using static Job_Application.Enums.ExperienceLevel;

namespace Job_Application.Managers
{
    internal class JobSeekerManager
    {


        //constructor
        public JobSeekerManager() 
        {
           
        }

        private JobSeeker[] jobSeekers = new JobSeeker[3];
        int JobSeekerCount=0;
        public JobSeeker loggedInJobSeeker = new JobSeeker();

     

        public void RegisterJobSeeker()
        {
            JobSeeker  newjobSeeker = new JobSeeker();
          
            Console.Write("\nEnter your FirstName : ");
            newjobSeeker.FirstName=Console.ReadLine();

            Console.Write("\nEnter your LastName : ");
            newjobSeeker.LastName= Console.ReadLine();

            Console.Write("\nEnter your Email : ");
            newjobSeeker.Email= Console.ReadLine();

            Console.Write("\nEnter your Password : ");
            newjobSeeker.Password= Console.ReadLine();

            Console.Write("\nEnter your PhoneNumber : ");
            newjobSeeker.Phone = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter your Location : ");
            newjobSeeker.Location = Console.ReadLine();

            Console.Write("\nAbout Yourself : ");
            newjobSeeker.AboutMe = Console.ReadLine();

            Console.Write("\nEnter your Qualification : ");
            newjobSeeker.Qualification = Console.ReadLine();



            //Console.Write("Enter your Experience Level( Fresher, MidLevel, Senior)");
            //newjobSeeker.ExperienceLevel = (ExperienceLevels)Enum.Parse(typeof(ExperienceLevels), Console.ReadLine());

            Console.Write("\nEnter your Experience Level (Fresher, Junior, MidLevel, Senior)");
            string input = Console.ReadLine();

            newjobSeeker.ExperienceLevel = (ExperienceLevels)Enum.Parse(typeof(ExperienceLevels), input, true);
           
            
            jobSeekers[JobSeekerCount] = newjobSeeker;
            JobSeekerCount++;
            Console.WriteLine("\n------------------Registration completed sucessfully----------------------");
           
        }


        public bool LoginJobSeeker()
        {
            Console.Write("\nEnter your Email : ");
            string Email= Console.ReadLine();

            Console.Write("\nEnter your Password : ");
            string Password = Console.ReadLine();

            bool loginSuccessful = false;
            foreach (JobSeeker seeker in jobSeekers)
            {
                if (seeker != null && seeker.Email == Email && seeker.Password == Password)
                {
                    loggedInJobSeeker = seeker;
                    loginSuccessful = true;
                    break;
                }
            }

            return loginSuccessful;
        }



        public void showJobSeekerMenu()
        {
            Console.WriteLine("\n1.Profile");
            Console.WriteLine("2.View Applied Jobs");
            Console.WriteLine("3.View Saved Jobs");
            Console.WriteLine("4.Logout");

            string Choice = Console.ReadLine();

            switch (Choice)
            {
                case "1":
                    showJobSeekerProfile();
                    showJobSeekerMenu();
                    break;
                case "2":
                        DisplayAppliedJobs();
                    showJobSeekerMenu();
                    break;
                case "3":
                        DisplaySavedJobs();
                    showJobSeekerMenu();
                    break;


                case "4":
                    Logout();
                    break;


                default:
                    Console.WriteLine("Invalid Choice Please try again");
                    showJobSeekerMenu();
                    break;

            }
        }

        public void showJobSeekerProfile()
        {
            Console.WriteLine("-------------------------------MY PROFILE-------------------------------------\n");
            Console.WriteLine($"First Name: {loggedInJobSeeker.FirstName}");
            Console.WriteLine($"Last Name: {loggedInJobSeeker.LastName}");
            Console.WriteLine($"Email: {loggedInJobSeeker.Email}");
            Console.WriteLine($"Phone: {loggedInJobSeeker.Phone}");
            Console.WriteLine($"Location: {loggedInJobSeeker.Location}");
            Console.WriteLine($"AboutMe: {loggedInJobSeeker.AboutMe}");
            Console.WriteLine($"Qualification:{loggedInJobSeeker.Qualification}");
            Console.WriteLine($"ExperienceLevel: {loggedInJobSeeker.ExperienceLevel}");
            Console.WriteLine("\n");

        }

        public void Logout()
        {
            loggedInJobSeeker = new JobSeeker();
            Console.WriteLine("\nLogged out successfully!");
            showMainMenu();
        }

        public void showMainMenu()
        {
            Console.WriteLine("\nWelcome to Job Portal \n The jobseeker portal!");
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");

            string choice= Console.ReadLine();

            switch (choice)
            {
                case "1":
                    RegisterJobSeeker();
                    showMainMenu();
                    break;
                case "2":
                    bool loginRes = LoginJobSeeker();
                    if (loginRes) // check if the user is logged in
                    {
                        Console.WriteLine("Welcome " + loggedInJobSeeker.FirstName + "!");
                        showJobSeekerMenu();
                    }
                    else
                    {
                        Console.WriteLine("Login failed...!");

                        showMainMenu();

                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    showMainMenu();

                    break;
            }
            }










        public void AppliedJobs(Job job)
        {
            if (loggedInJobSeeker != null)
            {
                loggedInJobSeeker.AddAppliedJob(job);
            }
        }

        public void SavedJobs(Job job)
        {
            if (loggedInJobSeeker != null)
            {
                loggedInJobSeeker.addSavedJob(job);
            }
        }
        public void DisplayAppliedJobs()
        {
            Job[] jobs = loggedInJobSeeker.GetAppliedJobs();

            Console.WriteLine("\nApplied Jobs");

            foreach (Job job in jobs)
            {
                if (job != null)
                {
                    Console.WriteLine($"Job Id: {job.Id}");
                    Console.WriteLine($"Title: {job.Title}");
                    Console.WriteLine($"Experience Level: {job.ExperienceLevel}");
                    Console.WriteLine("-------------------------");
                }
            }
        }

        public void DisplaySavedJobs()
        {
            Job[] jobs = loggedInJobSeeker.GetSavedJob();
            Console.WriteLine("\nSaved Jobs");

            foreach (Job job in jobs)
            {
                if (job != null)
                {
                    Console.WriteLine($"Job Id: {job.Id}");
                    Console.WriteLine($"Title: {job.Title}");
                    Console.WriteLine($"Experience Level: {job.ExperienceLevel}");
                    Console.WriteLine("-------------------------");
                }
            }
        }

    }
}
