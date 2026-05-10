using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razorasync.Model;

namespace razorasync.Pages.tourBook
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;
        public IList<Tour> Tours { get; set; }

        public IndexModel(AppDbContext context) => _context = context;

        public async Task OnGetAsync()
        {
            Tours = await _context.Tours.ToListAsync();
        }
    }
}
