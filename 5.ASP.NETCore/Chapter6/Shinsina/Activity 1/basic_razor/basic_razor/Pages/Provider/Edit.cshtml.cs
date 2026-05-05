using basic_razor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace basic_razor.Pages.Provider
{
    public class EditModel : PageModel
    {
        private readonly AppDbContext _context;
        public EditModel(AppDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Employee Employees { get; set; }
        public void OnGet(int id)
        {
            Employees = _context.Employees.Find(id);
            if (Employees == null)
            {
                Response.Redirect("/Provider/Index");
                //return NotFound();
                //return Page();
            }
        }
        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }
            _context.Employees.Update(Employees);
            _context.SaveChanges();
            Response.Redirect("/Provider/Index");
        }
    }
}
