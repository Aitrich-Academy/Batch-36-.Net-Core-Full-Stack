using JobPortalManagment.DTO;
using JobPortalManagment.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JobPortalManagment.Pages.Job
{
    public class IndexModel : PageModel
    {
        private readonly IJobService _service;
        [BindProperty]
        public List<JobDTO> ListJobs { get; set; }

        public IndexModel(IJobService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            ListJobs = await _service.GetAllJobs();
        }
    }
}