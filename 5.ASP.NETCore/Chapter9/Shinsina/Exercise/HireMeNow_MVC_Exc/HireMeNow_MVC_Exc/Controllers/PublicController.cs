using Microsoft.AspNetCore.Mvc;
using HireMeNow_MVC_Exc.DTOs;
using HireMeNow_MVC_Exc.Interfaces;

namespace HireMeNow_MVC_Exc.Controllers
{
    public class PublicController : Controller
    {
        private readonly IPublicService _service;

        public PublicController(IPublicService service)
        {
            _service = service;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterDto registerDto)
        {
            await _service.RegisterAsync(registerDto);

            return RedirectToAction("Login");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginDto dto)
        {
            var user = await _service.LoginAsync(dto);

            if (user != null)
            {
                HttpContext.Session.SetString(
                    "UserId",
                    user.UserId.ToString());

                return RedirectToAction(
                    "Profile",
                    "JobSeeker");
            }

            ViewBag.Message = "Invalid Email or Password";
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}