using UserApplication.Model;

namespace UserApplication.Interface
{
    public interface ICompanyMemberRepository
    {
        Task<List<CompanyMember>> GetAllAsync(int userId);
        Task<CompanyMember> GetByIdAsync(int id);
        Task AddCompanyMemberAsync(CompanyMember member);
        Task UpdateCompanyMemberAsync(CompanyMember member);
        Task DeleteCompanyMemberAsync(CompanyMember member);
    }
}
