using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3.Model
{
    public class Application
    {
        public int Id { get; set; }
        public int JobId { get; set; }
        public string ApplicantEmail { get; set; }

        public string Name { get; set; }
        public string Location { get; set; }
        public string Qualification { get; set; }
        public string Experience { get; set; }

        public Application() { }

        public Application(int id, int jobId,string applicantEmail, string applicantName, string location, string qualification, string experience)
        {
            Id= id;
            JobId = jobId;
            ApplicantEmail = applicantEmail;
            Name = applicantName;
            Location = location;
            Qualification = qualification;
            Experience = experience;
        }
    }
}
