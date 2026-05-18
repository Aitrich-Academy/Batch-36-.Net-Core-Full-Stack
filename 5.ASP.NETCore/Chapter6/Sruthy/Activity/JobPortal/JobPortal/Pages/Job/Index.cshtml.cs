using JobPortal.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JobPortal.Pages.Job
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public IList<JobPortal.Model.Job> Job { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            Job = await _context.Job.ToListAsync();
            return Page();
        }
    }
}
