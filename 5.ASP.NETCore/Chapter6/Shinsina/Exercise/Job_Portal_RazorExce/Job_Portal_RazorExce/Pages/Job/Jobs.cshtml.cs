using Job_Portal_RazorExce.DTO;
using Job_Portal_RazorExce.Interface;
using Job_Portal_RazorExce.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Job_Portal_RazorExce.Pages.Job
{
    public class JobsModel : PageModel
    {
        private readonly IJobService _service;

        public JobsModel(IJobService service)
        {
            _service = service;
        }

        public List<JobDTO> Jobs { get; set; } = new();
        public string Username { get; set; }

       
        public void OnGet()
        {
            Username = HttpContext.Session.GetString("Username");
            var userId = HttpContext.Session.GetInt32("UserId") ?? 0;

            Jobs = _service.GetJobs(userId);
        }

        public IActionResult OnPostApply(int jobId)
        {
            var userId = HttpContext.Session.GetInt32("UserId") ?? 0;

            _service.ApplyJob(new JobApplicationDTO
            {
                UserId = userId,
                JobId = jobId
            });

            return RedirectToPage();
            
        }
    }
}