using JobPortalManagment.DTO;
using JobPortalManagment.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JobPortalManagment.Pages.Job
{
    public class DeleteModel : PageModel
    {
        private readonly IJobService _service;

        public DeleteModel(IJobService service)
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
            await _service.DeleteJob(Job.ID);

            return RedirectToPage("Index");
        }
        //public async Task<IActionResult> OnGet(int id)
        //{
        //    await _service.DeleteJob(id);

        //    return RedirectToPage("View");
        //}
    }
}
