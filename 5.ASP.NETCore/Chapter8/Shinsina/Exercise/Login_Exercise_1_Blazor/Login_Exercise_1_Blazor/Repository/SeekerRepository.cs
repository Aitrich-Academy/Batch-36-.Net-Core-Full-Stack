using Login_Exercise_1_Blazor.Interface;
using Login_Exercise_1_Blazor.Model;
using Microsoft.EntityFrameworkCore;

namespace Login_Exercise_1_Blazor.Repository
{
    public class SeekerRepository : ISeekerRepository
    {
        private readonly AppDBContext _context;

        public SeekerRepository(AppDBContext context)
        {
            _context = context;
        }

        // ✅ REGISTER (WORKING)
        public async Task RegisterAsync(Seeker seeker)
        {
            _context.Seekers.Add(seeker);
            await _context.SaveChangesAsync();
        }

        // ✅ LOGIN (FIXED)
        public async Task<Seeker?> LoginAsync(string email, string password)
        {
            return await _context.Seekers
                .FirstOrDefaultAsync(x => x.Email == email && x.Password == password);
        }

        // ✅ GET BY ID (FIXED)
        public async Task<Seeker?> GetByIdAsync(int id)
        {
            return await _context.Seekers
                .FirstOrDefaultAsync(x => x.ID == id);
        }

        //// (OPTIONAL) UPDATE METHOD
        //public async Task UpdateAsync(Seeker seeker)
        //{
        //    var existing = await _context.Seekers.FirstOrDefaultAsync(x => x.ID == seeker.ID);

        //    if (existing != null)
        //    {
        //        existing.FirstName = seeker.FirstName;
        //        existing.LastName = seeker.LastName;
        //        existing.Email = seeker.Email;
        //        existing.PhoneNumber = seeker.PhoneNumber;
        //        existing.Gender = seeker.Gender;

        //        // only update password if needed
        //        if (!string.IsNullOrEmpty(seeker.Password))
        //        {
        //            existing.Password = seeker.Password;
        //        }

        //        await _context.SaveChangesAsync();
        //    }
        //}
    }
}