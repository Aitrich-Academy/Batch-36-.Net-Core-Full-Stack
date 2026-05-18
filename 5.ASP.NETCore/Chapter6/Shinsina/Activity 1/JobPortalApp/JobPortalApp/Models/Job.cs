using System;
using System.Collections.Generic;
using System.Text;

namespace JobPortalApp.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
    }
}
