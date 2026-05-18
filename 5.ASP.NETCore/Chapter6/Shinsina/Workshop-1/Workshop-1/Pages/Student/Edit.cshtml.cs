using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Workshop_1.Model;

namespace Workshop_1.Pages.Student
{
    public class EditModel : PageModel
    {
        private readonly AppDbContext _context;
        public EditModel(AppDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Workshop_1.Model.Student Student { get; set; }
        public void OnGet(int id)
        {
            Student = _context.Students.Find(id);
            if (Student == null)
            {
                Response.Redirect("/Provider/Index");
            }

        }
        //public bool ShowForm { get; set; } = true;



        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Students.Update(Student);
            _context.SaveChanges();

            TempData["SuccessMessage"] = "Updated Successfully";

            return RedirectToPage("Edit", new { id = Student.ID });
        }
    }
}
