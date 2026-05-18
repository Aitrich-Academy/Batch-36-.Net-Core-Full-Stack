using JobPortalApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace JobPortalApp.Services
{
    public class JobService
    {
        private readonly AppDbContext _context;
        public JobService()
        {
            _context = new AppDbContext();
        }
        // CREATE
        public void AddJob()
        {
            Console.Write(" Enter Job Title:");
            string title = Console.ReadLine();
            Console.Write(" Enter Company:" );

            string company = Console.ReadLine();
            Console.Write(" Enter Location:" );
            string location = Console.ReadLine();
            Job job = new Job
            {
                Title = title,
                Company = company,
                Location = location
            };
            _context.Jobs.Add(job);
            _context.SaveChanges();
            Console.WriteLine("Job Added Successfully!");
        }
        // READ (All)
        public void ViewJobs()
        {
            var jobs = _context.Jobs.ToList();
            foreach (var j in jobs)
            {
                Console.WriteLine($"{ j.Id} | { j.Title} | { j.Company} | { j.Location} ");
            }
        }
        // READ (By ID)
        public void ViewJobById()
        {
            Console.Write(" Enter Job ID: ");
            int id = int.Parse(Console.ReadLine());
            var job = _context.Jobs.Find(id);
            if (job != null)

            {
                Console.WriteLine($"{ job.Title}, { job.Company},{ job.Location}");
            }
            else
            {
                Console.WriteLine(" Job Not Found! ");
            }
        }
        // UPDATE
        public void UpdateJob()
        {
            Console.Write("Enter Job ID to Update: ");
            int id = int.Parse(Console.ReadLine());
            var job = _context.Jobs.Find(id);
            if (job != null)
            {
                Console.Write(" New Title:");
                job.Title = Console.ReadLine();
                Console.Write(" New Company: ");
                job.Company = Console.ReadLine();
                Console.Write(" New Location: ");
                job.Location = Console.ReadLine();
                _context.SaveChanges();
                Console.WriteLine(" Job Updated");
            }
            else
            {
                Console.WriteLine("Job Not Found! ");
            }
        }

        // DELETE
        public void DeleteJob()
        {
            Console.Write( "Enter Job ID to Delete:");
            int id = int.Parse(Console.ReadLine());
            var job = _context.Jobs.Find(id);
            if (job != null)
            {
                _context.Jobs.Remove(job);
                _context.SaveChanges();
                Console.WriteLine("Job Deleted!");
            }
            else
            {
                Console.WriteLine(" Job Not Found! ");
            }
        }
    }
}
