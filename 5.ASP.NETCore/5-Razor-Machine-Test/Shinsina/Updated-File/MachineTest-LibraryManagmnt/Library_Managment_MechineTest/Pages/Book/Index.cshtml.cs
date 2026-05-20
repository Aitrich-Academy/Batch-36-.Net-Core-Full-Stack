using Library_Managment_MechineTest.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Library_Managment_MechineTest.Pages.Book
{
    public class BooksModel : PageModel
    {
        private readonly AppDbContext _context;

        public BooksModel(AppDbContext context)
        {
            _context = context;
        }

        public List<Library_Managment_MechineTest.Model.Book> Books { get; set; }

        public string Role { get; set; }

        public IActionResult OnGet()
        {
            
            var userName = HttpContext.Session.GetString("UserName");

            if (string.IsNullOrEmpty(userName))
            {
                return RedirectToPage("/User/Login");
            }

           
            Role = HttpContext.Session.GetString("Role");

            
            Books = _context.Books.ToList();

            return Page();
        }
    }
}