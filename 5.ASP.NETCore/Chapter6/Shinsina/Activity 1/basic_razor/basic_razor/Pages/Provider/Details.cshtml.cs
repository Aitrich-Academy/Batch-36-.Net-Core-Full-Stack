using basic_razor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace basic_razor.Pages.Provider
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
        //public void OnGet()
        //{
        //    Employee = _context.Employee.ToList();
        //}
        public void OnGet(int id)
        {
            Employee = _context.Employees
                            .FirstOrDefault(e => e.Id == id);
        }
        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }
            _context.Employees.Find(Employee);
            _context.SaveChanges();
            TempData["SuccessMessage"] = "Employee deleted successfully!";
            Response.Redirect("/Provider/Index");
        }
    }
}
