using JobProviderApplication.Manager;
using JobProviderApplication.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Job_PortalManager portal = new Job_PortalManager();
        Printer printer = new Printer();

        while (true)
        {
            Console.WriteLine("\n--- Job Portal ---");
            Console.WriteLine("1. List Jobs");
            Console.WriteLine("2. Post Job");
            Console.WriteLine("3. List Applications");
            Console.WriteLine("4. List Interviews");
            Console.WriteLine("5. Schedule Interview");
            Console.WriteLine("6. Exit");

            Console.Write("Enter choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    printer.Print(portal.GetJobs());
                    break;

                case 2:
                    Job job = new Job();
                    int jobcount = 0;

                    //Console.Write("Enter Id: ");
                    //job.Id = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Title: ");
                    job.Title = Console.ReadLine();

                    Console.Write("Enter Company: ");
                    job.Company = Console.ReadLine();

                    Console.Write("Enter Location: ");
                    job.Location = Console.ReadLine();

                    Console.Write("Enter Salary: ");
                    job.Salary = Console.ReadLine();
                    jobcount++;
                    portal.PostJob(job);
                    break;

                case 3:
                    printer.Print(portal.GetApplications());
                    break;

                case 4:
                    printer.Print(portal.GetInterviews());
                    break;

                case 5:
                    Interview interview = new Interview();

                    Console.Write("Enter Id: ");
                    interview.Id = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Company: ");
                    interview.Company = Console.ReadLine();

                    Console.Write("Enter Post: ");
                    interview.Post = Console.ReadLine();

                    Console.Write("Enter Date: ");
                    interview.Date = Console.ReadLine();

                    Console.Write("Enter Time: ");
                    interview.Time = Console.ReadLine();

                    portal.ScheduleInterview(interview);
                    break;

                case 6:
                    return;
            }
        }
    }
}
