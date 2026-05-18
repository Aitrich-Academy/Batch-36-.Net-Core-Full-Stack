using Library_Managment_MechineTest.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;

namespace Library_Managment_MechineTest.Pages.Book
{
    public class BooksModel : PageModel
    {
        private readonly AppDbContext _context;
        public BooksModel(AppDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public List<Library_Managment_MechineTest.Model.Book> Books { get; set; }
        public string Role { get; set; }
        public void OnGet()
        {
            Books = _context.Books.ToList();
            Role = HttpContext.Session.GetString("Role");

        }
    }
}
