using System;
using System.Collections.Generic;
using System.Text;

namespace JobProviderApplication.Models
{
    public class Application
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Qualification { get; set; }
        public string Experience { get; set; }
    }
}
