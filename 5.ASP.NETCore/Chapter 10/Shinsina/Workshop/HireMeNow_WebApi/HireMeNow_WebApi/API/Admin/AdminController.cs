using AutoMapper;
using Domain.Models;
using Domain.Service.Admin.DTOs;
using Domain.Service.Admin.Interfaces;
using Domain.Service.Job.DTOs;
using Domain.Service.Job.Interfaces;
using Domain.Service.Login.Interfaces;
using Domain.Service.Profile.DTOs;
using HireMeNow_WebApi.API.Admin.RequestObjects;
using HireMeNow_WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace HireMeNow_WebApi.API.Admin
{
    [ApiController]
    public class AdminController : BaseApiController<AdminController>
    {
        private readonly IAdminServices _adminService;
        private readonly IMapper _mapper;
        private readonly ILoginRequestService _loginRequestService;
        private readonly IJobServices _jobService;

        public AdminController(
            IMapper mapper,
            IAdminServices adminService,
            ILoginRequestService loginRequestService,
            IJobServices jobService)
        {
            _mapper = mapper;
            _adminService = adminService;
            _loginRequestService = loginRequestService;
            _jobService = jobService;
        }

        // -------------------- LOGIN --------------------

        [HttpPost("Admin/login")]
        public IActionResult Login([FromBody] AdminLoginRequests logdata)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = _loginRequestService.Adminlogin(logdata.Email, logdata.Password);

            if (user == null)
                return Unauthorized("Invalid Email or Password");

            return Ok(user);
        }

        // -------------------- JOB SEEKERS --------------------

        [HttpGet("admin/GetJobSeekers")]
        public async Task<IActionResult> GetJobSeekers()
        {
            try
            {
                var jobSeekers = await _adminService.GetJobSeekers();
                return Ok(_mapper.Map<List<JobSeekerDto>>(jobSeekers));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // -------------------- COMPANIES --------------------

        [HttpGet("admin/GetCompanies")]
        public async Task<IActionResult> GetCompanies()
        {
            try
            {
                var companies = await _adminService.GetCompanies();
                return Ok(_mapper.Map<List<JobProviderDto>>(companies));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("admin/SearchCompanies")]
        public async Task<IActionResult> SearchCompanies(string name)
        {
            try
            {
                var companies = await _adminService.SearchCompanies(name);
                return Ok(_mapper.Map<List<JobProviderDto>>(companies));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // -------------------- JOBS --------------------

        [HttpGet("admin/jobsbyName")]
        public async Task<IActionResult> GetJobsByName(string title)
        {
            try
            {
                var jobs = await _adminService.GetJobs(title);
                return Ok(_mapper.Map<List<Joblist>>(jobs));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("alljobs")]
        public async Task<IActionResult> GetAllJobs()
        {
            try
            {
                var jobs = await _adminService.GetJobs();
                return Ok(_mapper.Map<List<Joblist>>(jobs));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // -------------------- SKILLS --------------------

        [HttpPost("skillAdd")]
        public async Task<IActionResult> AddSkill([FromBody] SkillRequest skill)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var dto = _mapper.Map<SkillDto>(skill);

            var result = await _adminService.AddSkillAsync(dto);

            if (!result)
                return BadRequest("Skill already exists.");

            return Ok("Skill added successfully.");
        }

        [HttpDelete("skillRemove/{skillId}")]
        public async Task<IActionResult> RemoveSkill(Guid skillId)
        {
            var result = await _adminService.RemoveSkillAsync(skillId);

            if (!result)
                return NotFound("Skill not found.");

            return Ok("Skill deleted successfully.");
        }

        // -------------------- LOCATIONS --------------------

        [HttpPost("AddLocation")]
        public async Task<IActionResult> AddLocation([FromBody] LocationRequest location)
        {
            var entity = _mapper.Map<Location>(location);

            var result = await _adminService.AddLocation(entity);

            return Ok(result);
        }

        [HttpGet("GetLocations")]
        public async Task<IActionResult> GetLocations()
        {
            try
            {
                var locations = await _adminService.GetLocations();
                return Ok(_mapper.Map<List<LocationDto>>(locations));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("RemoveLocations/{id}")]
        public IActionResult RemoveLocation(Guid id)
        {
            try
            {
                _adminService.DeleteByLocationId(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // -------------------- DELETE COMPANY --------------------

        [HttpDelete("admin/RemoveCompanyUsers/{id}")]
        public IActionResult RemoveCompany(Guid id)
        {
            try
            {
                _adminService.DeleteById(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // -------------------- COUNTS --------------------

        [HttpGet("admin/GetJobProviderCount")]
        public IActionResult GetJobProviderCount()
        {
            return Ok(new
            {
                Count = _adminService.GetJobProviderCount()
            });
        }

        [HttpGet("admin/GetJobCount")]
        public IActionResult GetJobCount()
        {
            return Ok(new
            {
                Count = _adminService.GetJobCount()
            });
        }
    }
}

//namespace HireMeNow_WebApi.API.Admin
//{
//    /* [Route("api/[controller]")]*/
//    [ApiController]
//    public class AdminController : BaseApiController<AdminController>
//    {
//        private readonly IAdminServices _adminService;
//        private readonly IMapper _mapper;
//        IAdminRepository _adminRepository;
//        private IMapper mapper;
//        public ILoginRequestService _loginRequestService;
//        IJobServices _jobService;

//        public AdminController(IMapper mapper, IAdminServices adminService, IAdminRepository adminRepostory, ILoginRequestService loginRequestService,IJobServices jobServices)
//        {
//            _mapper = mapper;
//            _adminService = adminService;
//            _adminRepository = adminRepostory;
//            _loginRequestService = loginRequestService;
//			_jobService = jobServices;
//        }



//        [HttpPost]
//        [Route("Admin/login")]
//        public async Task<ActionResult> Login(AdminLoginRequests logdata)
//        {

//            var user = _loginRequestService.Adminlogin(logdata.Email, logdata.Password);

//            if (user == null)
//            {
//                return BadRequest("Login Failed");
//            }
//            return Ok(user);
//        }

//        [HttpGet]
//        [Route("admin/GetJobSeekers")]
//        public async Task<IActionResult> GetJobSeekers()
//        {

//            try
//            {
//                var jobSeekers = await _adminService.GetJobSeekers();
//                return Ok(_mapper.Map<List<JobSeekerDto>>(jobSeekers));
//            }
//            catch (Exception ex)
//            {
//                return BadRequest();
//            }

//        }


//        [HttpPost("skillAdd")]
//        public async Task<IActionResult> AddSkill( SkillRequest skill)
//        {
//            // Map the request to DTO

//            var Skill = _mapper.Map<SkillDto>(skill);

//            // Call the service
//            var result = await _adminService.AddSkillAsync(Skill);

//            if (result)
//            {
//                return Ok("Skill added successfully");
//            }
//            else
//            {
//                return BadRequest("Skill already exists");
//            }
//        }

//        [HttpDelete("skillRemove/{skillId}")]
//        public async Task<IActionResult> RemoveSkill(Guid skillId)
//        {
//            // Call the service
//            var result = await _adminService.RemoveSkillAsync(skillId);

//            if (result)
//            {
//                return Ok("Skill deleted successfully");
//            }
//            else
//            {
//                return NotFound("Skill not found or failed to delete");
//            }
//        }

//        [HttpGet]
//        [Route("admin/GetCompanies")]
//        public async Task<IActionResult> GetCompanies()
//        {

//            try
//            {
//                var jobProviders = await _adminService.GetCompanies();
//                return Ok(_mapper.Map<List<JobProviderDto>>(jobProviders));
//            }
//            catch (Exception ex)
//            {
//                return BadRequest();
//            }

//        }

//        //New-Code

//        [HttpGet]
//        [Route("admin/SearchCompanies")]
//        public async Task<IActionResult> SearchCompanies(string name)
//        {

//            try
//            {

//                var companies = await _adminService.SearchCompanies(name);
//                return Ok(_mapper.Map<List<JobProviderDto>>(companies));
//            }
//            catch (Exception ex)
//            {
//                return BadRequest();
//            }

//        }

//        //New-Code Ends


//		[HttpGet]
//		[Route("admin/jobsbyName")]
//		public async Task<IActionResult> getalljobs(string Title)
//		{

//			try
//			{
//				var jobs = await _adminService.GetJobs(Title);
//				return Ok(_mapper.Map<List<Joblist>>( jobs));
//			}
//			catch (Exception ex)
//			{
//				return BadRequest();
//			}

//		}
//		[HttpGet]
//		[Route("alljobs")]
//        public async Task<IActionResult> alljobs()
//        {

//            try
//            {
//                var jobs = await _adminService.GetJobs();
//                return Ok(_mapper.Map<List<Joblist>>(jobs));
//            }
//            catch (Exception ex)
//            {
//                return BadRequest();
//            }

//        }




//        [HttpDelete]
//        [Route("admin/RemoveCompanyUsers/{id}")]
//        public IActionResult Remove(Guid id)
//        {
//            try
//            {
//                _adminService.DeleteById(id);
//                return NoContent();
//            }
//            catch (Exception ex)
//            {
//                return BadRequest();
//            }

//        }



//        [HttpGet]
//        [Route("admin/GetJobProviderCount")]
//        public IActionResult GetJobProviderCount()
//        {
//            try
//            {
//                var count = _adminService.GetJobProviderCount();
//                return Ok(new { Count = count });
//            }
//            catch (Exception ex)
//            {
//                return BadRequest();
//            }

//        }

//        [HttpGet]
//        [Route("admin/GetJobCount")]
//        public IActionResult GetJobCount()
//        {
//            try
//            {
//                var count = _adminService.GetJobCount();
//                return Ok(new { Count = count });
//            }
//            catch (Exception ex)
//            {
//                return BadRequest();
//            }

//        }






//        [HttpPost("AddLocation")]
//        public async Task<IActionResult> AddLocation(LocationRequest location)
//        {
//            var Location = _mapper.Map<Location>(location);
//            var result = await _adminService.AddLocation(Location);

//            return Ok(result);
//        }



//        [HttpGet("GetLocations")]
//        public async Task<IActionResult> GetLocations()
//        {

//            try
//            {
//                var locations = await _adminService.GetLocations();
//                return Ok(_mapper.Map<List<LocationDto>>(locations));
//            }
//            catch (Exception ex)
//            {
//                return BadRequest();
//            }

//        }


//        [HttpDelete]
//        [Route("RemoveLocations/{id}")]
//        public IActionResult RemoveLocation(Guid id)
//        {
//            try
//            {
//                _adminService.DeleteByLocationId(id);
//                return NoContent();
//            }
//            catch (Exception ex)
//            {
//                return BadRequest();
//            }

//        }





//    }

//}
