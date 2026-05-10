using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razorasync.Model;

namespace razorasync.Pages.tourBook
{
    public class EditModel : PageModel
    {
        private readonly AppDbContext _context;
        

        public EditModel(AppDbContext context) => _context = context;

        [BindProperty] public Tour Tour { get; set; }
        public async Task OnGetAsync(int id)
        {
            Tour = await _context.Tours.FindAsync(id);
            if (Tour == null)
                Response.Redirect("/tourbook/Index");

        }
        public async Task OnPostAsync(int id)
        {
            if (!ModelState.IsValid)
            { return; }

            _context.Tours.Update(Tour);
            await _context.SaveChangesAsync();

            Response.Redirect("/tourBook/Index");




            //if (!ModelState.IsValid) return Page();

            //var existingTour = await _context.Tours.FindAsync(Tour.Id);
            //if (existingTour == null) return NotFound();

            //// Update only the fields you want
            //existingTour.Destination = Tour.Destination;
            //existingTour.Price = Tour.Price;
            //existingTour.AvailableSlots = Tour.AvailableSlots;

            //await _context.SaveChangesAsync();
            //return RedirectToPage("Index");
        }
    }
}
