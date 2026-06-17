using HireMeNow_MVC_Exc.DTOs;
using HireMeNow_MVC_Exc.Interfaces;
using HireMeNow_MVC_Exc.Models;

namespace HireMeNow_MVC_Exc.Services
{
    public class PublicService : IPublicService
    {
        private readonly IUserRepository _userRepository;

        public PublicService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task RegisterAsync(RegisterDto dto)
        {
            User user = new User
            {
                UserId = Guid.NewGuid(),
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.Email,
                PhoneNumber = dto.PhoneNumber,
                Password = dto.Password,
                UserRole = "JobSeeker",
                CreatedDate = DateTime.Now
            };

            await _userRepository.RegisterAsync(user);
        }

        public async Task<User?> LoginAsync(LoginDto dto)
        {
            return await _userRepository.LoginAsync(
                dto.Email,
                dto.Password);
        }
    }
}