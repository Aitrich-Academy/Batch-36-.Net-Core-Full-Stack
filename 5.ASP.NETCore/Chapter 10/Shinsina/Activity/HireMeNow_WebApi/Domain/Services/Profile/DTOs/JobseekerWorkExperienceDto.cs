using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Profile.DTOs
{
    public class JobseekerWorkExperienceDto
    {
        public string JobTitle { get; set; } = null!;

        public string CompanyName { get; set; } = null!;

        public string Summary { get; set; } = null!;

        public DateTime ServiceStart { get; set; }

        public DateTime ServiceEnd { get; set; }
    }
}
