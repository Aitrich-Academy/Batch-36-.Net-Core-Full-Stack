using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Workshop_1.Model;

namespace Workshop_1.Pages.Student
{
    public class DeleteModel : PageModel
    {
        private readonly AppDbContext _context;
        public DeleteModel(AppDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Workshop_1.Model.Student Student { get; set; }
        public void OnGet(int id)
        {
            Student=_context.Students
                .FirstOrDefault(e=>e.ID == id);
        }
        public IActionResult OnPost(int id)
        {
            var em = _context.Students.Find(Student.ID);
            if (em != null) 
            {
               _context.Students.Remove(em);
                _context.SaveChanges();
               
            }
            TempData["SuccessMessage"] = "Employee deleted successfully!";
            return RedirectToPage();
        }
    }
}
