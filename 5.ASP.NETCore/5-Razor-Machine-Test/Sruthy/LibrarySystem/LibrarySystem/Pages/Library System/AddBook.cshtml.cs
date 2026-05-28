using LibrarySystem.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibrarySystem.Pages.Library_System
{
    public class AddBookModel : PageModel
    {
        private readonly AppDbContext _context;
        public AddBookModel(AppDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Book Book { get; set; }
        public IActionResult OnGet()
        {
            if(HttpContext.Session.GetString("Role")!= "Admin")
            {
                return RedirectToPage("/Library System/Login");
            }
            return Page();
        }

        public async Task<IActionResult>OnPostAsync()
        {
            await _context.Books.AddAsync(Book);
            await _context.SaveChangesAsync();
            return RedirectToPage("/Library System/Index");
        }
    }
}
