using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sample.Model;
using Microsoft.EntityFrameworkCore;

namespace Sample.Pages.Provider
{
    public class EditModel : PageModel
    {
        private readonly AppDbContext _context;

        public EditModel(AppDbContext context)
        {
            _context = context;

        }
        [BindProperty]
        public Sample.Model.Employee Employee { get; set; }
        public void OnGet(int id)
        {
            Employee=_context.Employees.Find(id);
            if (Employee == null)
            {
                 Response.Redirect("/Provider/Index");

            }
        }
        
        public void OnPost(int id) 
        {
            if (!ModelState.IsValid)
            {
                return;
            }
            _context.Employees.Update(Employee);
            _context.SaveChanges();
            Response.Redirect("/Provider/Index");
        }
    }
}
