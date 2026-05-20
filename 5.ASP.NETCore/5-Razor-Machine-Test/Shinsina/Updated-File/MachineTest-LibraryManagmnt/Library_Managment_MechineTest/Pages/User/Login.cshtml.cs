using Library_Managment_MechineTest.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Library_Managment_MechineTest.Pages.User
{
    public class LoginModel : PageModel
    {
        private readonly AppDbContext _context;

        public LoginModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public string UserName { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public IActionResult OnPost()
        {
            var user = _context.Users
                .FirstOrDefault(x =>
                    x.UserName == UserName &&
                    x.Password == Password);

            if (user == null)
            {
                ViewData["Error"] = "Invalid Login";
                return Page();
            }

            HttpContext.Session.SetString("UserName", user.UserName);
            HttpContext.Session.SetString("Role", user.Role);

            return RedirectToPage("/Book/Index");
        }

        public void OnGet()
        {
        }
    }
}