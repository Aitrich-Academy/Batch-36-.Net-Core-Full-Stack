using JobPortal.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JobPortal.Pages.Job
{
    public class CreateModel : PageModel
    {
        private readonly AppDbContext _context;
        public CreateModel(AppDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public JobPortal.Model.Job Job { get; set; }    
        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Job.AddAsync(Job);
            await _context.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}
