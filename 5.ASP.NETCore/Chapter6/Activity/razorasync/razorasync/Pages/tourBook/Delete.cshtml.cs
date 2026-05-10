using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using razorasync.Model;

namespace razorasync.Pages.tourBook
{
    public class DeleteModel : PageModel
    {
        private readonly AppDbContext _context;
        [BindProperty] public Tour Tour { get; set; }

        public DeleteModel(AppDbContext context) => _context = context;

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Tour = await _context.Tours.FindAsync(id);
            if (Tour == null) return NotFound();
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int id)
        {
            var tour = await _context.Tours.FindAsync(id);
            if (tour != null)
            {
                _context.Tours.Remove(tour);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage("Index");
        }
    }
}
