using HireMeNow_Wrkshp_MVC.Interface;
using HireMeNow_Wrkshp_MVC.Dtos;
using HireMeNow_Wrkshp_MVC.Models;

namespace HireMeNow_Wrkshp_MVC.Service
{
    public class PublicService : IPublicService
    {
        private readonly IUserRepository _userRepository;

        public PublicService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool Register(RegisterDto dto)
        {
            var company = new Company
            {
                CompanyName = dto.CompanyName,
                Location = dto.Location
            };

            _userRepository.AddCompany(company); // NEW METHOD

            var user = new User
            {
                Name = dto.Name,
                Email = dto.Email,
                Password = dto.Password,
                CompanyId = company.CompanyId
            };

            _userRepository.Register(user);

            return true;
        }

        public User LoginJobSeeker(LoginDto dto)
        {
            return _userRepository.LoginJobSeeker(dto);
        }
    }
}