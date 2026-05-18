using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Workshop_1.Model;
namespace Workshop_1.Pages.Student
{ 
    public class CreateModel : PageModel 
    { 
        private readonly AppDbContext _context; 
        public CreateModel(AppDbContext context) 
        {
            _context = context;
        }

        [BindProperty]
        public Workshop_1.Model.Student Students { get; set; }
        public void OnGet() 
        { } 
        public IActionResult OnPost() 
        { 
            if (!ModelState.IsValid)
            {
                TempData["ErrorMessage"] = "Invalid input. Please check the fields.";
                return Page(); 
            }
            try
            {
                _context.Students.Add(Students);
                _context.SaveChanges();
                TempData["SuccessMessage"] = "Student added successfully!";
                return RedirectToPage();
            }
            catch
            {
                return RedirectToPage("");
            }
           
            
        } 
    } 
}