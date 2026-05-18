using JobPortalManagment.DTO;
using JobPortalManagment.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JobPortalManagment.Pages.Job
{
    public class CreateModel : PageModel
    {
        private readonly IJobService _service;

        [BindProperty]
        public JobDTO JobPost { get; set; }

        public CreateModel(IJobService service)
        {
            _service = service;
        }

        public  IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            await _service.AddJob(JobPost);

            return RedirectToPage("Index");
        }
    }
}