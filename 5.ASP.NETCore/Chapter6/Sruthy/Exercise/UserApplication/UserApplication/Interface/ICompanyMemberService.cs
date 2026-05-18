using UserApplication.Dto;

namespace UserApplication.Interface
{
    public interface ICompanyMemberService
    {
        
        Task<List<CompanyMemberDto>> GetAllAsync(int userId);
        Task AddCompanyMemberAsync(CompanyMemberDto dto, int userId);
        Task UpdateCompanyMemberAsync(int id, CompanyMemberDto dto);
        Task DeleteCompanyMemberAsync(int id);
    }
}
