using System.ComponentModel.DataAnnotations;
using UserApplication.Model;

namespace UserApplication.Dto
{
    public class CompanyMemberDto
    {
        public int CompanyMemberId { get; set; }

        public string MemberName { get; set; }
        [Required]
        public string Email { get; set; }

        public string Designation { get; set; }
        public int UserId { get; set; }

        public User User { get; set; }
    }
}
