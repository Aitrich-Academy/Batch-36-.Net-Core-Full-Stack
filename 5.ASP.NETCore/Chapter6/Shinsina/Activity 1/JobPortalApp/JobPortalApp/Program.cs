using JobPortalApp.Models;
using JobPortalApp.Services;

internal class Program
{
    static void Main()
    {
        JobService service = new JobService();
        while (true)
        {
            Console.WriteLine("\n-- - JOB PORTAL SYSTEM ---");
            Console.WriteLine(" 1.Add Job");
            Console.WriteLine(" 2.View All Jobs");

            Console.WriteLine("3.View Job By ID ");
            Console.WriteLine(" 4.Update Job");
            Console.WriteLine(" 5.Delete Job ");
            Console.WriteLine(" 6.Exit ");
            Console.Write(" Choose Option: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1: service.AddJob(); break;
                case 2: service.ViewJobs(); break;
                case 3: service.ViewJobById(); break;
                case 4: service.UpdateJob(); break;
                case 5: service.DeleteJob(); break;
                case 6: return;
                default: Console.WriteLine("Invalid choice"); break;
            }
        }
    }
}