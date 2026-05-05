using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using basic_razor.Model;

namespace basic_razor.Pages.Provider
{
    public class CreateModel : PageModel
    {
        private readonly AppDbContext _context;
        public CreateModel(AppDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public  Employee Employees { get; set; }
        public void OnGet()
        {
        }

        //public IActionResult OnPost()
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return Page();
        //    }

        //    _context.Employees.Add(Employees);
        //    _context.SaveChanges();

        //    TempData["SuccessMessage"] = "Employee added successfully!";

        //    return RedirectToPage();
        //}
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                TempData["ErrorMessage"] = "Invalid input. Please check the fields.";
                return Page();
            }

            try
            {
                _context.Employees.Add(Employees);
                _context.SaveChanges();

                TempData["SuccessMessage"] = "Employee added successfully!";
                return RedirectToPage();
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "Employee not added. Something went wrong!";
                return Page();
            }
        }

    }
}
