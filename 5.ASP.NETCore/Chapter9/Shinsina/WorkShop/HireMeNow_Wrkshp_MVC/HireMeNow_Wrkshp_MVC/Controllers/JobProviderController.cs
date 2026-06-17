using HireMeNow_Wrkshp_MVC.Dtos;
using HireMeNow_Wrkshp_MVC.Interface;
using HireMeNow_Wrkshp_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HireMeNow_Wrkshp_MVC.Controllers
{
    public class JobProviderController : Controller
    {
        private readonly IJobRepository _jobRepository;
        private readonly IJobService _jobService;

        public JobProviderController(
            IJobRepository jobRepository,
            IJobService jobService)
        {
            _jobRepository = jobRepository;
            _jobService = jobService;
        }

        // GET
        public IActionResult PostJob()
        {
            return View();
        }

        // POST (FINAL FIXED VERSION)
        [HttpPost]
        public IActionResult PostJob(JobDto dto)
        {
            // 1. Get CompanyId from session
            int? companyId = HttpContext.Session.GetInt32("CompanyId");

            // 2. If session missing → go login
            if (companyId == null)
            {
                return RedirectToAction("Login", "Public");
            }

            // 3. Validate form
            if (!ModelState.IsValid)
            {
                return View(dto);
            }

            // 4. Map DTO → Entity
            var job = new Job
            {
                JobTitle = dto.JobTitle,
                Description = dto.Description,
                Location = dto.Location,
                Salary = dto.Salary,
                TypeOfWork = dto.TypeOfWork,

                // IMPORTANT: THIS SAVES COMPANY LINK
                CompanyId = companyId.Value
            };

            // 5. Save to DB
            bool result = _jobRepository.Create(job);

            if (!result)
            {
                ModelState.AddModelError("", "Job not saved. Try again.");
                return View(dto);
            }

            // 6. Success redirect
            return RedirectToAction("AllJobs");
        }

        // VIEW JOBS
        public IActionResult AllJobs()
        {
            int? companyId = HttpContext.Session.GetInt32("CompanyId");

            if (companyId == null)
            {
                return RedirectToAction("Login", "Public");
            }

            var jobs = _jobService.GetJobsByCompanyId(companyId.Value);

            return View(jobs);
        }
        public IActionResult Details(int id)
        {
            var job = _jobService.GetJobById(id);

            if (job == null)
            {
                return NotFound();
            }

            return View(job);
        }
        public IActionResult Edit(int id)
        {
            var job = _jobService.GetJobById(id);

            if (job == null)
            {
                return NotFound();
            }

            return View(job);
        }
        [HttpPost]
        public IActionResult Edit(Job job)
        {
            if (!ModelState.IsValid)
            {
                return View(job);
            }

            _jobService.Update(job);

            TempData["Success"] = "Job updated successfully.";

            return RedirectToAction("AllJobs");
        }
        public IActionResult Delete(int id)
        {
            _jobService.Delete(id);

            TempData["Success"] = "Job deleted successfully.";

            return RedirectToAction("AllJobs");
        }
    }
}