using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Profile.DTOs
{
    public class JobseekerQualificationDto
    {
        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;
        public List<JobseekerQualificationDto> Qualifications { get; set; }
       = new List<JobseekerQualificationDto>();
    }
}
