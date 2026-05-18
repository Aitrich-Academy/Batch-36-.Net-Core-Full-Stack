using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibrarySystem.Pages.Library_System
{
    public class UserHomeModel : PageModel
    {
        public IActionResult OnGet()
        {
            if (HttpContext.Session.GetString("Role") != "Admin")
            {
                return RedirectToPage("/Library System/Login");
            }
            return Page();
        }
    }
}
