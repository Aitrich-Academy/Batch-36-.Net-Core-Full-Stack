using AutoMapper;
using Login_Exercise_1_Blazor.DTO;
using Login_Exercise_1_Blazor.Interface;
using Login_Exercise_1_Blazor.Model;

namespace Login_Exercise_1_Blazor.Service
{
    public class SeekerAuthService : ISeekerAuthService
    {
        private readonly ISeekerRepository _repo;
        private readonly IMapper _mapper;

        public SeekerAuthService(ISeekerRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<bool> Register(SeekerRegisterDTO dto, string password)
        {
            var seeker = _mapper.Map<Seeker>(dto);
            seeker.Password = password;

            await _repo.RegisterAsync(seeker);
            return true;
        }

        public async Task<bool> Login(string email, string password)
        {
            var user = await _repo.LoginAsync(email, password);
            return user != null;
        }

        public async Task<bool> Logout()
        {
            return await Task.FromResult(true);
        }
    }
}