using AutoMapper;
using UserApplication.Dto;
using UserApplication.Interface;
using UserApplication.Model;

namespace UserApplication.Service
{
    public class UserService:IUserService
    {
        private readonly IUserRepository _repo;
        private readonly IMapper _mapper;

        public UserService(IUserRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task Register(UserDto dto)
        {
            var user = _mapper.Map<User>(dto);
            await _repo.Register(user);
        }

        public async Task<UserDto> Login(string email, string password)
        {
            var user = await _repo.Login(email, password);
            return _mapper.Map<UserDto>(user);
        }

        public async Task<UserDto> GetUserById(int id)
        {
            var user = await _repo.GetById(id);
            return _mapper.Map<UserDto>(user);
        }
    }
}
