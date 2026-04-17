using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyMemberRegistration.Model
{
    public class Application
    {
        public int Id { get; set; }
        public string Experience { get; set; }
        public string  Name { get; set; }
        public string Location { get; set; }
        public string Qualification { get; set; }

        public Application(int jobId,string applicantName,string experience,string location,string qualification)
        {
            Id = jobId;
            Name = applicantName;
            Experience = experience;
            Location = location;
            Qualification = qualification;
        }
    }
}
