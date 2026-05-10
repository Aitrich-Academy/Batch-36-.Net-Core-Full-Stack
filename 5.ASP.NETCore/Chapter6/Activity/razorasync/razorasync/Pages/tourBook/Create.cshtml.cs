using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using razorasync.Model;

namespace razorasync.Pages.tourBook
{
    public class CreateModel : PageModel
    {
        private readonly AppDbContext _context;
        [BindProperty] public Tour Tour { get; set; }

        public CreateModel(AppDbContext context) => _context = context;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) 
                return Page();
            _context.Tours.Add(Tour);
            await _context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
