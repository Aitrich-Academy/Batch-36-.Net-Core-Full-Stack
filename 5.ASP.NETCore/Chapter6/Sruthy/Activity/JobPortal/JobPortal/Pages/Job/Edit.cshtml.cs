using JobPortal.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace JobPortal.Pages.Job
{
    public class EditModel : PageModel
    {
        private readonly AppDbContext _context;

        public EditModel(AppDbContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Job).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}

