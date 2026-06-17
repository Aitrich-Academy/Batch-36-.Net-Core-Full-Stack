using HireMeNow_Wrkshp_MVC.Dtos;
using HireMeNow_Wrkshp_MVC.Models;
namespace HireMeNow_Wrkshp_MVC.Interface
{
    public interface IUserRepository
    {
        User Login(string email, string password);
        User LoginJobSeeker(LoginDto dto);
        void AddCompany(Company company);
        void Register(User user); 
       
    }
}
