using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sample.Model;

namespace Sample.Pages.Provider
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;
        public IndexModel(AppDbContext context)
        {
            _context = context;

        }
        [BindProperty]
        public IList<Sample.Model.Employee> Employee { get; set; }

        public void OnGet()
        {
            Employee = _context.Employees.ToList();
        }
    }
}
