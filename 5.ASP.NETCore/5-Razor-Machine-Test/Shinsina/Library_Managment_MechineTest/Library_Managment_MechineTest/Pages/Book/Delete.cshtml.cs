using Library_Managment_MechineTest.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Library_Managment_MechineTest.Pages.Book
{
    public class DeleteModel : PageModel
    {
        private readonly AppDbContext _context;
        public DeleteModel (AppDbContext context)
        {
            _context = context;
        }
        public IActionResult OnGet(int id)
        {
            var role = HttpContext.Session.GetString("Role");
            if (role != "Admin")
                return RedirectToPage("/Book/Books");
            var book = _context.Books.Find(id);
            if(book != null)
            {
                _context.Books.Remove(book);
                _context.SaveChanges();
            }
            return RedirectToPage("/Book/Books");

        }
    }
}
