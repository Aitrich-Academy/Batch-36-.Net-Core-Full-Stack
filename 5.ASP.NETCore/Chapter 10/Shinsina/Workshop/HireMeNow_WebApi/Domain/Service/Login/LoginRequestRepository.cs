using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Domain.Service.Login.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Domain.Service.Login
{
    public class LoginRequestRepository : ILoginRequestRepository
    {
        protected readonly HireMeNowWebApContext _context;
        public LoginRequestRepository(HireMeNowWebApContext dbContext)
        {
            _context = dbContext;
        }

        public AuthUser GetUserByEmail(string email)
        {
            var user = _context.AuthUsers
    .Include(e => e.IdNavigation)
    .FirstOrDefault(e => e.IdNavigation.Email == email);
            return user;
        }
	

		public AuthUser GetUserByEmailpassword(string email, string password)
		{
            var user = _context.AuthUsers
    .Include(e => e.IdNavigation)
    .FirstOrDefault(e =>
        e.IdNavigation.Email == email &&
        e.Password == password); 
            return user;
		}
}
    }
