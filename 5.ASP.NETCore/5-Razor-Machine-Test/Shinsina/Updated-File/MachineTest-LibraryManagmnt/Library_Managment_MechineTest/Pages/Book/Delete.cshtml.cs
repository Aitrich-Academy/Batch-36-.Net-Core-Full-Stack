using Library_Managment_MechineTest.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Library_Managment_MechineTest.Pages.Book
{
    public class DeleteModel : PageModel
    {
        private readonly AppDbContext _context;

        public DeleteModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Library_Managment_MechineTest.Model.Book Book { get; set; }

        public IActionResult OnGet(int id)
        {
            var role = HttpContext.Session.GetString("Role");

            if (string.IsNullOrEmpty(role) || role != "Admin")
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

        public IActionResult OnPost()
        {
            var role = HttpContext.Session.GetString("Role");

            if (string.IsNullOrEmpty(role) || role != "Admin")
            {
                return RedirectToPage("/User/Login");
            }

            var bookInDb = _context.Books.Find(Book.ID);

            if (bookInDb != null)
            {
                _context.Books.Remove(bookInDb);
                _context.SaveChanges();
            }

            return RedirectToPage("/Book/Index");
        }
    }
}