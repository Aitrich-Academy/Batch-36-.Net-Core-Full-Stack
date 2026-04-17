using JobPortalApplication.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobPortalApplication.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Salary { get; set; }
        public string Location { get; set; }
        public Experience Experience { get; set; }
    }
}
