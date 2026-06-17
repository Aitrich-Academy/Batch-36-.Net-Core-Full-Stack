using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Student_ManagmentSystemMVC_MachneTst.Dtos;

namespace Student_ManagmentSystemMVC_MachneTst.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            if (!ModelState.IsValid)
                return View(loginDto);

            if (loginDto.Username == "admin" && loginDto.Password == "admin123")
            {
                HttpContext.Session.SetString("User", loginDto.Username);
                return RedirectToAction("Dashboard", "Student");
            }
            ViewBag.Error = "invalid";
            return View(loginDto);
        }

        public IActionResult Logout() 
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Account");
        }
    }
}
