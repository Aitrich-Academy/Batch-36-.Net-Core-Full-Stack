using JobPortalApplication.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobPortalApplication.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

        // Each user has their own jobs
        public List<Job> SavedJobs { get; set; } = new List<Job>();
        public List<Job> AppliedJobs { get; set; } = new List<Job>();
    }
}
