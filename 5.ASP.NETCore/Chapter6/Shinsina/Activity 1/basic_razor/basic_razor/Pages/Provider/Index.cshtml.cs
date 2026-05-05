using basic_razor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.IdentityModel.Tokens;

namespace basic_razor.Pages.Provider
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;
        public IndexModel(AppDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public IList<basic_razor.Model.Employee > Employees { get; set; }
        public void OnGet()
        {
            Employees = _context.Employees.ToList();
        }
    }
}
