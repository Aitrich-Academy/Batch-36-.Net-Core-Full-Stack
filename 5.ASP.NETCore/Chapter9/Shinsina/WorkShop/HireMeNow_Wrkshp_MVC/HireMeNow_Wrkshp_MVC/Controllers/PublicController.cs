using HireMeNow_Wrkshp_MVC.Dtos;
using HireMeNow_Wrkshp_MVC.Interface;
using Microsoft.AspNetCore.Mvc;

namespace HireMeNow_Wrkshp_MVC.Controllers
{
    public class PublicController : Controller
    {
        private readonly IPublicService _publicService;

        public PublicController(IPublicService publicService)
        {
            _publicService = publicService;
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult JobProviderRegistration()
        {
            return View();
        }

        [HttpPost]
        public IActionResult JobProviderRegistration(RegisterDto dto)
        {
            _publicService.Register(dto);

            return RedirectToAction("Login");
        }

        [HttpPost]
        public IActionResult Login(LoginDto dto)
        {
            var user = _publicService.LoginJobSeeker(dto);

            if (user == null)
            {
                ViewBag.Error = "LOGIN FAILED - USER NOT FOUND";
                return View(dto);
            }
            HttpContext.Session.SetInt32("UserId", user.UserId);

            if (user.CompanyId.HasValue)
            {
                HttpContext.Session.SetInt32("CompanyId", user.CompanyId.Value);

                return RedirectToAction("PostJob", "JobProvider");
            }

            return RedirectToAction("Login");
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Login");
        }
    }
    }
