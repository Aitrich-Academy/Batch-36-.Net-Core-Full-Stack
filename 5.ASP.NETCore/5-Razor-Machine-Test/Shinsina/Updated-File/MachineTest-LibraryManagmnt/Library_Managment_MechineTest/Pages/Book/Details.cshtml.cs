using Library_Managment_MechineTest.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Library_Managment_MechineTest.Pages.Book
{
    public class DetailsModel : PageModel
    {
        private readonly AppDbContext _context;

        public DetailsModel(AppDbContext context)
        {
            _context = context;
        }

        public Library_Managment_MechineTest.Model.Book Book { get; set; }

        public IActionResult OnGet(int id)
        {
            
            var user = HttpContext.Session.GetString("UserName");

            if (string.IsNullOrEmpty(user))
            {
                return RedirectToPage("/User/Login");
            }

            Book = _context.Books.Find(id);

            if (Book == null)
            {
                return RedirectToPage("/Book/Index");
            }

            return Page();
        }
    }
}