using UserApplication.Model;
using Microsoft.EntityFrameworkCore;
using UserApplication.Interface;
namespace UserApplication.Repository
{
    public class CompanyMemberRepository: ICompanyMemberRepository
    {
        private readonly AppDbContext _context;

        public CompanyMemberRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<CompanyMember>> GetAllAsync(int userId)
        {
            return await _context.CompanyMember
                .Where(x => x.UserId == userId)
                .ToListAsync();
        }
       
        public async Task<CompanyMember> GetByIdAsync(int id)
        {
            return await _context.CompanyMember.FindAsync(id);
        }

        public async Task AddCompanyMemberAsync(CompanyMember member)
        {
            _context.CompanyMember.Add(member);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCompanyMemberAsync(CompanyMember member)
        {
            _context.CompanyMember.Update(member);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCompanyMemberAsync(CompanyMember member)
        {
            _context.CompanyMember.Remove(member);
            await _context.SaveChangesAsync();
        }

    }

}
