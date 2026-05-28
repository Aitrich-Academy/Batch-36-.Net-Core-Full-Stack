using LibrarySystem.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibrarySystem.Pages.Library_System
{
    public class DeleteBookModel : PageModel
    {
        private readonly AppDbContext _context;
        public DeleteBookModel(AppDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Book Book { get; set; }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            if (HttpContext.Session.GetString("Role") != "Admin")
            {
                return RedirectToPage("/Library System/Login");
            }
            Book = await _context.Books.FindAsync(id);
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book != null)
            {
                _context.Books.Remove(book);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage("/Library System/Index");
        }
        
    }
}
