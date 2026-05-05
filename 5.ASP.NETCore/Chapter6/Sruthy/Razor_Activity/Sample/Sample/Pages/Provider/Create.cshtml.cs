using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sample.Model;

namespace Sample.Pages.Provider
{
    public class CreateModel : PageModel
    {
        private readonly AppDbContext _context;
        public CreateModel(AppDbContext context)
        {
            _context = context;

        }
        [BindProperty]
        public Sample.Model.Employee Employee { get; set; }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }
            _context.Employees.Add(Employee);
            _context.SaveChanges();
            Response.Redirect("/Provider/Index");
        }
    }
}
