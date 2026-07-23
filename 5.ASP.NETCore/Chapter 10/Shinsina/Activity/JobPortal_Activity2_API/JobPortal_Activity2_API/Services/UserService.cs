using System.Text;
using System.Security.Cryptography;
using AutoMapper;
using JobPortal_Activity2_API.DTOs;
using JobPortal_Activity2_API.Interfaces;
using JobPortal_Activity2_API.Models;

namespace JobPortal_Activity2_API.Services
{
    public class UserService:IUserService
    {
        private readonly IUserRepository _reppository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository userReppository,IMapper mapper)
        {
            _reppository = userReppository;
            _mapper = mapper;
        }
        public async Task<UserDTO> RegisterUserAsync(RegisterDTO userRegisterDto)
        {
            // Check if user already exists
            var existingUser = await _reppository.GetUserByEmailAsync(userRegisterDto.Email);
            if (existingUser != null)
                throw new Exception("User with this email already exists.");

            // Hash Password
            var passwordHash = HashPassword(userRegisterDto.Password);

            var user = new User
            {
                Name = userRegisterDto.Name,
                Email = userRegisterDto.Email,
                PasswordHash = passwordHash
            };

            var registeredUser = await _reppository.RegisterAsync(user);
            return _mapper.Map<UserDTO>(registeredUser);
        }

        public async Task<UserDTO> LoginUserAsync(LoginDTO userLoginDto)
        {
            var user = await _reppository.GetUserByEmailAsync(userLoginDto.Email);
            if (user == null || !VerifyPassword(userLoginDto.Password, user.PasswordHash))
                throw new Exception("Invalid email or password.");

            return _mapper.Map<UserDTO>(user);
        }

        public async Task<UserDTO> GetUserByIdAsync(int id)
        {
            var user = await _reppository.GetUserByIdAsync(id);
            return _mapper.Map<UserDTO>(user);
        }

        private string HashPassword(string password)
        {
            using var sha256 = SHA256.Create();
            var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(hashedBytes);
        }

        private bool VerifyPassword(string enteredPassword, string storedHash)
        {
            return HashPassword(enteredPassword) == storedHash;
        }

    }
}
