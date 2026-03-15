using Job_Application.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Job_Application.Models
{
    internal class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ExperienceLevels ExperienceLevel { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public string SalaryRange { get; set; }
        public string JobType { get; set; }
    }
}
