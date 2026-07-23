using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Profile.DTOs
{
    public class ProfileDto
    {
        public Guid Id { get; set; }
        public Guid JobSeekerId { get; set; }

        public string? ProfileName { get; set; }

        public string? ProfileSummary { get; set; }
    }
}
