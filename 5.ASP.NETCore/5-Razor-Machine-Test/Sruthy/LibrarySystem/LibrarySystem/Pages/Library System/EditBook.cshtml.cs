using LibrarySystem.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibrarySystem.Pages.Library_System
{
    public class EditBookModel : PageModel
    {
        private readonly AppDbContext _context;
        public EditBookModel(AppDbContext context)
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
        public async Task<IActionResult> OnPostAsync()
        {
            _context.Books.Update(Book);
            await _context.SaveChangesAsync();
            return RedirectToPage("/Library System/Index");
        }
    }
}
