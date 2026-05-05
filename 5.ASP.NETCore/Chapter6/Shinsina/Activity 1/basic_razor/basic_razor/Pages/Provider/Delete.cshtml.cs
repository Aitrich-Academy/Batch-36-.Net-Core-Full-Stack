using basic_razor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace basic_razor.Pages.Provider
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
        public void OnGet(int id)
        {
            Employee = _context.Employees
                               .FirstOrDefault(e => e.Id == id);
        }
       
        public IActionResult OnPost()
        {
            var emp = _context.Employees.Find(Employee.Id);

            if (emp != null)
            {
                _context.Employees.Remove(emp);
                _context.SaveChanges();
            }
            TempData["SuccessMessage"] = "Employee deleted successfully!";
            return RedirectToPage();
        }
    }
}
