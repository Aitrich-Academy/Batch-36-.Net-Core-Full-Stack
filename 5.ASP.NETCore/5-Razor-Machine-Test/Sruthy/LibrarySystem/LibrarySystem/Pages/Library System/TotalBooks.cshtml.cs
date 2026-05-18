using LibrarySystem.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace LibrarySystem.Pages.Library_System
{
    public class TotalBooksModel : PageModel
    {
        private readonly AppDbContext _context;
        public TotalBooksModel(AppDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public int TotalBooks { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            if (HttpContext.Session.GetString("Role") != "Admin")
            {
                return RedirectToPage("/Library System/Login");
            }
            TotalBooks = await _context.Books.SumAsync(b=>b.Quantity);
            return Page();
        }
    }
}
