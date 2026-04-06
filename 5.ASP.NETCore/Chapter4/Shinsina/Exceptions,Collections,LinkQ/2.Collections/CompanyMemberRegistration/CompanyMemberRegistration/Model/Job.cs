using System;
using System.Collections.Generic;
using System.Text;
using static CompanyMemberRegistration.Enum.ExperienceLevel;


namespace CompanyMemberRegistration.Model
{
    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ExperienceLevels ExperienceLevel { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public string SalaryRange { get; set; }
        public string JobType { get; set; }

        private string Description {  get; set; }

        private string Type {  get; set; }

        private string Salary {  get; set; }



        public Job(string title, string description, string location, string type, string salary, string company)
        {
            Title = title;
            Description = description;
            Location = location;
            Type = type;
            Salary = salary;
            Company = company;
            
            
        }
    }
}
