using Exercise3.Interface;
using Exercise3.Model;
using Exercise3.Repository;
using System.Reflection.Metadata.Ecma335;

public class JobSeekerManager : IMenu
{
    private IJobRepository jobRepo = new JobRepository();
    private IApplicationRepository appRepo = new ApplicationRepository();

    private static List<Job> savedJobs = new List<Job>();

    private User currentUser;
    
    public JobSeekerManager(User user)
    {
        currentUser = user;
    }

    public void DisplayMenu()
    {
        bool exit = false;
        Console.WriteLine("\nWelcome "+currentUser.FirstName+" "+currentUser.LastName);
        while (!exit)
        {

            Console.WriteLine("\n--- Job Seeker Menu ---");
            Console.WriteLine("1. List Jobs");
            Console.WriteLine("2. Saved Jobs");
            Console.WriteLine("3. Applied Jobs");
            Console.WriteLine("4. My Profile");
            Console.WriteLine("5. Logout");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ListJobs();
                    break;
                case "2":
                    ShowSavedJobs();
                    break;
                case "3":
                    ShowAppliedJobs();
                    break;
                case "4":
                    ShowProfile();
                    break;
                case "5":
                    Console.WriteLine("Logged out Successfully!!\n");
                    exit = true;
                    break;
            }
        }
    }

    
    private void ListJobs()
    {
        bool back = false;
        var jobs = jobRepo.GetAllJobs();

        foreach (var j in jobs)
        {
            Console.WriteLine($"{j.Id} | {j.Title} | {j.Company} | {j.Location}");
        }
        while (!back)
        {
            Console.WriteLine("\n1. Apply Job\n2. Save Job\n3. Back");
            string choice = Console.ReadLine();

            if (choice == "1") ApplyJob();
            else if (choice == "2") SaveJob();
            else if (choice == "3") back = true;
            else
            {
                Console.WriteLine("Invalid choice");
                continue;
            }
        }
    }

    
    private void ApplyJob()
    {
        Console.Write("Enter Job Id: ");
        int jobId = int.Parse(Console.ReadLine());

        var job = jobRepo.GetAllJobs().Find(j => j.Id == jobId);

        if (job == null)
        {
            Console.WriteLine("Job not found!");
            return;
        }
        var existingApp = appRepo.GetApplicationsByUser(currentUser.Email)
                            .Find(a => a.JobId == jobId);

        if (existingApp != null)
        {
            Console.WriteLine("You have already applied for this job!");
            return; // back to menu
        }


        Console.Write("Enter Location: ");
        string location = Console.ReadLine();

        Console.Write("Enter Qualification: ");
        string qualification = Console.ReadLine();

        Console.Write("Enter Experience: ");
        string experience = Console.ReadLine();
       
        Application app = new Application
        {
            JobId = jobId,
            ApplicantEmail = currentUser.Email,
            Name = currentUser.FirstName,
            Location = location,
            Qualification = qualification,
            Experience = experience
        };

        appRepo.AddApplication(app);
        Console.WriteLine("DEBUG: Applicant Name = " + app.Name);
        Console.WriteLine("Applied successfully!");
    }

    
    private void SaveJob()
    {
        Console.Write("Enter Job Id: ");
        int jobId = int.Parse(Console.ReadLine());

        var job = jobRepo.GetAllJobs().Find(j => j.Id == jobId);

        if (job == null)
        {
            Console.WriteLine("Invalid Job Id");
            return;
        }
        if (savedJobs.Any(j => j.Id == jobId))
        {
            Console.WriteLine("You have already saved this job!");
            return;
        }
        savedJobs.Add(job);
        Console.WriteLine("Job saved successfully!\n");
    }

    private void ShowSavedJobs()
    {
        Console.WriteLine("\nSaved Jobs:");
        Console.WriteLine("\nJob Id |   Job Title   \n");
        foreach (var j in savedJobs)
        {
            Console.WriteLine($"{j.Id} | {j.Title}");
        }
        Console.WriteLine("\n");

    }

    private void ShowAppliedJobs()  
    {
        var apps = appRepo.GetApplicationsByUser(currentUser.Email);

        Console.WriteLine("\nApplied Jobs:");
        if (apps.Count == 0)
        { Console.WriteLine("No applied Jobs...");
            return;
        }
        var jobs=jobRepo.GetAllJobs();
        Console.WriteLine("\nJob Id |   Job Title   \n");
        foreach (var a in apps)
        {
            var job = jobs.Find(j => j.Id == a.JobId);
            Console.WriteLine($"{a.JobId} | {job?.Title??"Unknown"}");
        }
    }

    private void ShowProfile()
    {
        Console.WriteLine("\n--- Profile ---");
        Console.WriteLine($"Name: {currentUser.FirstName} {currentUser.LastName}");
        Console.WriteLine($"Email: {currentUser.Email}");
        Console.WriteLine($"Phone: {currentUser.Phone}\n");
    }

}