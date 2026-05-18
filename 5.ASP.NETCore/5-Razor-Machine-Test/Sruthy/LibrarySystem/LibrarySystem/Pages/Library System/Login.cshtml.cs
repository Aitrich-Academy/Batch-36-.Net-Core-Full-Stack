using LibrarySystem.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace LibrarySystem.Pages.Library_System
{
    public class LoginModel : PageModel
    {
        private readonly AppDbContext _context;
        public LoginModel(AppDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public string Email { get; set; }
        [BindProperty]
        public string Password { get; set; }
        public string Message { get; set; }

        public void OnGet()
        {

        }
        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _context.Users.FirstOrDefaultAsync(u =>
                                    u.Email == Email &&
                                    u.Password == Password);
            if (user != null)
            {
                HttpContext.Session.SetString("UserName", user.UserName);
                HttpContext.Session.SetString("Role", user.Role);
                if(user.Role=="Admin")
                {
                    return RedirectToPage("/Library System/AdminHome");
                }
                return RedirectToPage("/Library System/UserHome");
            }
            Message = "Invalid Login";
            return Page();

        }
    }
}
