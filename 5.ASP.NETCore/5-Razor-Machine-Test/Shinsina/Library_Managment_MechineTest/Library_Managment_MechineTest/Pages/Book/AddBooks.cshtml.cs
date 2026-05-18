using Library_Managment_MechineTest.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Library_Managment_MechineTest.Pages.Book
{
    public class AddBooksModel : PageModel
    {   private readonly AppDbContext _context;

        public AddBooksModel(AppDbContext context) 
        { 
            _context = context;
        }
        [BindProperty]
        public Library_Managment_MechineTest.Model.Book Book { get; set; }

        public IActionResult OnGet()
        {
            var role = HttpContext.Session.GetString("Role");
            if(role == "Admin")
            {
                return RedirectToPage("/Book/Books");
            }
            return Page();
        }
        public IActionResult OnPost()
        {
            var role = HttpContext.Session.GetString("Role");
            if(role == "Admin")
            {
                return RedirectToPage("/Book/Books");
            }
            _context.Books.Add(Book);
            _context.SaveChanges();
            return RedirectToPage("/Book/Books");
        }
    }
}
