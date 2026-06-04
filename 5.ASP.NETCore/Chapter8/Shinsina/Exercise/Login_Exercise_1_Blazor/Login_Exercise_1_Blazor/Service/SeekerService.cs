using AutoMapper;
using Login_Exercise_1_Blazor.DTO;
using Login_Exercise_1_Blazor.Interface;
using Login_Exercise_1_Blazor.Model;

namespace Login_Exercise_1_Blazor.Service
{
    public class SeekerService : ISeekerService
    {
        private readonly ISeekerRepository _repository;
        private readonly IMapper _mapper;

        public SeekerService(
            ISeekerRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task RegisterAsync(SeekerRegisterDTO dto)
        {
            var seeker = _mapper.Map<Seeker>(dto);

            await _repository.RegisterAsync(seeker);
        }

        public async Task<Seeker?> LoginAsync(LoginDTO dto)
        {
            return await _repository.LoginAsync(
                dto.Email,
                dto.Password);
        }

       
    }
}
