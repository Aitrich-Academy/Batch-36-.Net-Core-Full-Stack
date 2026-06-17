using HireMeNow_MVC_Exc.DTOs;
using HireMeNow_MVC_Exc.Interfaces;
using HireMeNow_MVC_Exc.Models;
using HireMeNow_MVC_Exc.Repository;
using Microsoft.AspNetCore.Mvc;

namespace HireMeNow_MVC_Exc.Controllers
{
    public class JobSeekerController : Controller
    {
        private readonly IJobSeekerService _service;
        private readonly IJobRepository _jobRepo;

        public JobSeekerController(IJobSeekerService service, IJobRepository jobRepo)
        {
            _service = service;
            _jobRepo = jobRepo;
        }

        public async Task<IActionResult> Profile()
        {
            string? userIdString = HttpContext.Session.GetString("UserId");

            if (string.IsNullOrEmpty(userIdString))
                return RedirectToAction("Login", "Public");

            Guid userId = Guid.Parse(userIdString);

            var user = await _service.GetProfileAsync(userId);

            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProfile(ProfileDto dto)
        {
            await _service.UpdateProfileAsync(dto);

            return RedirectToAction("Profile");
        }

        public async Task<IActionResult> AllJobs()
        {
            var jobs = await _service.GetAllJobsAsync();
            return View(jobs); // MUST match AllJobs.cshtml
        }
        
        [HttpPost]
        public async Task<IActionResult> ApplyJob(Guid jobId)
        {
            var userId = HttpContext.Session.GetString("UserId");

            if (userId == null)
                return RedirectToAction("Login", "Public");

            var result = await _service.ApplyJobAsync(Guid.Parse(userId), jobId);

            if (!result)
            {
                TempData["Message"] = "You have already applied for this job.";
                TempData["MessageType"] = "warning";
            }
            else
            {
                TempData["Message"] = "Job applied successfully!";
                TempData["MessageType"] = "success";
            }

            return RedirectToAction("AllJobs");
        }
        public async Task<IActionResult> AppliedJobs()
        {
            var userId = HttpContext.Session.GetString("UserId");

            if (userId == null)
                return RedirectToAction("Login", "Public");

            var applications = await _service.GetMyApplicationsAsync(Guid.Parse(userId));

            return View(applications);
        }
        [HttpPost]
        public async Task<IActionResult> DeleteApplication(Guid id)
        {
            await _service.DeleteApplicationAsync(id);

            return RedirectToAction("AppliedJobs");
        }
        public IActionResult Index()
        {
            return View();
        }
       
    }
}