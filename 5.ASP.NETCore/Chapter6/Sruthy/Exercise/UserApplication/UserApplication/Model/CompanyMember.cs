using System.ComponentModel.DataAnnotations;

namespace UserApplication.Model
{
    public class CompanyMember 
    {
        public int CompanyMemberId { get; set; }

        public string MemberName { get; set; }
        
        public string Email { get; set; }

        public string Designation { get; set; }
        public int UserId { get; set; }

        public User User { get; set; }

    }
        
   
}
