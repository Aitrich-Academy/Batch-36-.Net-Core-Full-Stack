using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Workshop_1.Model;

namespace Workshop_1.Pages.Student
{
    public class DetailsModel : PageModel
    {
        private readonly AppDbContext _context;
        public DetailsModel(AppDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        //public Student student { get; set; }
        public Workshop_1.Model.Student Student { get; set; }
       
        public void OnGet(int id)
        {
            Student = _context.Students
                           .FirstOrDefault(e => e.ID == id);
        }
        public void OnPost(int id) 
        {
            if (!ModelState.IsValid)
            {
                return;
            }
            _context.Students.Find(Student);
            _context.SaveChanges();
            Response.Redirect("/Student/Index");
        }
    }
}
