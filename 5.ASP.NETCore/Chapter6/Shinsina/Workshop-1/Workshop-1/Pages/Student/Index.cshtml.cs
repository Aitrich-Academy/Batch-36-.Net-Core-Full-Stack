using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Workshop_1.Model;
using System.Linq;

namespace Workshop_1.Pages.Student
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public IList<Workshop_1.Model.Student> Students { get; set; }

        // ✅ ADD THIS (for search input)
        [BindProperty(SupportsGet = true)]
        public int? SearchId { get; set; }

        public void OnGet()
        {
            if (SearchId.HasValue)
            {
                Students = _context.Students
                                   .Where(s => s.ID == SearchId.Value)
                                   .ToList();

             
                if (Students.Count == 0)
                {
                    TempData["ErrorMessage"] = "Student not found";
                }
            }
            else
            {
                Students = _context.Students.ToList();
            }
        }
    }
}