using Library_Managment_MechineTest.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Library_Managment_MechineTest.Pages.User
{
    public class RegisterModel : PageModel
    {
        private readonly AppDbContext _context;

        public RegisterModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public AppUser regUser { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var exists = _context.Users
                .Any(x => x.UserName == regUser.UserName);

            if (exists)
            {
                ModelState.AddModelError("", "Email already exists");
                return Page();
            }

            regUser.Role = "User";

            try
            {
                _context.Users.Add(regUser);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return Page();
            }

            TempData["SuccessMessage"] = "Registered Successfully";

            return RedirectToPage("/User/Login");
        }

        public void OnGet()
        {
        }
    }
}