using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sample.Model;

namespace Sample.Pages.Provider
{
    public class DetailsModel : PageModel
    {
        private readonly AppDbContext _context;

        public DetailsModel(AppDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Employee Employee { get; set; }  


        public void OnGet(int id)
        {
            Employee = _context.Employees.Find(id);
            if(Employee== null)
            {
                Response.Redirect("/Provider/Index");
            }

        }
    }
}
