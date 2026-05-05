using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sample.Model;

namespace Sample.Pages.Provider
{
    public class DeleteModel : PageModel
    {
        private readonly AppDbContext _context;

        public DeleteModel(AppDbContext context)
        {
            _context = context;

        }
        [BindProperty]
        public Employee Employee { get; set; }
        public IActionResult OnGet(int id)
        {
            Employee = _context.Employees.Find(id);
            if (Employee == null)
            {
                return NotFound();
                Response.Redirect("/Provider/Index");

            }
            return Page();


        }

        public IActionResult OnPost(int id)
        {

            var emp = _context.Employees.Find(Employee.Id);
           
            if (emp != null)
            {
                _context.Employees.Remove(emp);
                _context.SaveChanges();
            }

            return RedirectToPage("/Provider/Index");
        }
    }
}
