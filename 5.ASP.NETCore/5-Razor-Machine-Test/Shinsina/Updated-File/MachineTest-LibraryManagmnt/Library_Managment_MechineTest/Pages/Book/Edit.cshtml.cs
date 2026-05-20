using Library_Managment_MechineTest.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Library_Managment_MechineTest.Pages.Book
{
    public class EditModel : PageModel
    {
        private readonly AppDbContext _context;

        public EditModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Library_Managment_MechineTest.Model.Book Book { get; set; }

        public IActionResult OnGet(int id)
        {
            var role = HttpContext.Session.GetString("Role");

            
            if (role != "Admin")
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

            
            if (role != "Admin")
            {
                return RedirectToPage("/User/Login");
            }

            if (!ModelState.IsValid)
            {
                return Page();
            }

            var bookInDb = _context.Books.Find(Book.ID);

            if (bookInDb == null)
            {
                return RedirectToPage("/Book/Index");
            }

            
            bookInDb.Title = Book.Title;
            bookInDb.Author = Book.Author;
            bookInDb.Quantity = Book.Quantity;

            _context.SaveChanges();

            TempData["Success"] = "Book Updated Successfully";

            return RedirectToPage("/Book/Index");
        }
    }
}

