using AutoMapper;
using UserApplication.Dto;
using UserApplication.Interface;
using UserApplication.Model;

namespace UserApplication.Service
{
    public class CompanyMemberService : ICompanyMemberService
    {
        private readonly ICompanyMemberRepository _repo;
        private readonly IMapper _mapper;

        public CompanyMemberService(ICompanyMemberRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<List<CompanyMemberDto>> GetAllAsync(int userId)
        {
            var data = await _repo.GetAllAsync(userId);
            return _mapper.Map<List<CompanyMemberDto>>(data);
        }

        public async Task AddCompanyMemberAsync(CompanyMemberDto dto, int userId)
        {
            var entity = _mapper.Map<CompanyMember>(dto);
            entity.UserId = userId;
            await _repo.AddCompanyMemberAsync(entity);
        }

        public async Task UpdateCompanyMemberAsync(int id, CompanyMemberDto dto)
        {
            var entity = await _repo.GetByIdAsync(id);
            //_mapper.Map(dto, entity);
            entity.MemberName = dto.MemberName;
            entity.Email = dto.Email;
            entity.Designation = dto.Designation;
            await _repo.UpdateCompanyMemberAsync(entity);
        }

        public async Task DeleteCompanyMemberAsync(int id)
        {
            var entity = await _repo.GetByIdAsync(id);
            await _repo.DeleteCompanyMemberAsync(entity);
        }
    }
}
