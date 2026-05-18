using JobPortalManagment.DTO;
using JobPortalManagment.Interface;
using JobPortalManagment.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JobPortalManagment.Pages.Job
{
    public class EditModel : PageModel
    {
        private readonly IJobService _service;

        public EditModel(IJobService service)
        {
            _service = service;
        }

        [BindProperty]
        public JobDTO Job { get; set; }

        public async Task OnGet(int id)
        {
            Job = await _service.GetJobById(id);
        }

        public async Task<IActionResult> OnPost()
        {
            await _service.UpdateJob(Job);

            return RedirectToPage("Index");
        }
    }
}
