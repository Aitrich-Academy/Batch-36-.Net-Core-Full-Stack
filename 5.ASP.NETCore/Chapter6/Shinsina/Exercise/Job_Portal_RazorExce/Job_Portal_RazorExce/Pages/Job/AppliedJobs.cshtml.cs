using Job_Portal_RazorExce.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Job_Portal_RazorExce.Pages.Job
{
    public class AppliedJobsModel : PageModel
    {
        private readonly IJobRepository _repo;

        public AppliedJobsModel(IJobRepository repo)
        {
            _repo = repo;
        }

        public List<Model.Job> AppliedJobs { get; set; }

        public void OnGet()
        {
            var userId = HttpContext.Session.GetInt32("UserId") ?? 0;
            AppliedJobs = _repo.GetAppliedJobs(userId);
        }
    }
}
