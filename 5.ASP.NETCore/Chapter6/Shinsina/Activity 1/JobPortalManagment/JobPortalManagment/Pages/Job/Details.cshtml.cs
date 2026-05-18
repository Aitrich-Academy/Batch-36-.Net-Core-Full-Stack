using JobPortalManagment.DTO;
using JobPortalManagment.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JobPortalManagment.Pages.Job
{
    public class DetailsModel : PageModel
    {
        private readonly IJobService _service;

        public DetailsModel(IJobService service)
        {
            _service = service;
        }

        public JobDTO Job { get; set; }

        public async Task OnGet(int id)
        {
            Job = await _service.GetJobById(id);
        }
    }
}
