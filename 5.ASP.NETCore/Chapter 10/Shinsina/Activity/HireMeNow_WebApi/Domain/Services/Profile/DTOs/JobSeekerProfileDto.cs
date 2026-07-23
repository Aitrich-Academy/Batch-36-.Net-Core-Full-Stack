using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Services.Profile.DTOs
{
    public class JobSeekerProfileDto
    {
        public Guid JobSeekerId { get; set; }
        public string? UserName { get; set; }

        public string FirstName { get; set; } = null!;

        public string? LastName { get; set; }

        public string Phone { get; set; } = null!;
        public string Qualification { get; set; } = null!;

        public byte[] image { get; set; } = null!;
        public string Email { get; set; } = null!;

        [JsonIgnore]
        public List<Qualification> Qualifications { get; set; } = new List<Qualification>();
        //public string? ImageUrl { get; set; }

        [JsonIgnore]
        public List<Skill> JobSeekerProfileSkills { get; set; } = new();


        public int Role { get; set; }

        
    }
}
