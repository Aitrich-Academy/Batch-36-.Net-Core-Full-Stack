using JobPortal.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JobPortal.Pages.Job
{
    public class DeleteModel : PageModel
    {
        private readonly AppDbContext _context;

        public DeleteModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public JobPortal.Model.Job Job { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Job = await _context.Job.FindAsync(id);

            if (Job == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            Job = await _context.Job.FindAsync(id);

            if (Job != null)
            {
                _context.Job.Remove(Job);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("Index");
        }
    }
}
