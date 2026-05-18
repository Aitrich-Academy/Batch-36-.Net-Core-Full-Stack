using Job_Portal_RazorExce.DTO;
using Job_Portal_RazorExce.Interface;
using Job_Portal_RazorExce.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Job_Portal_RazorExce.Pages.Login
{
    public class LoginModel : PageModel
    {
        //private readonly IUserService _service;

        //public LoginModel(IUserService service)
        //{
        //    _service = service;
        //}
        private readonly IUserRepository _repo;

        public LoginModel(IUserRepository repo)
        {
            _repo = repo;
        }

        [BindProperty]
        public User User { get; set; }

        public string ErrorMessage { get; set; }

        public async Task<IActionResult> OnPost()
        {
            var user = await _repo.Login(User.Email, User.Password);

            if (user != null)
            {
                HttpContext.Session.SetInt32("UserId", user.Id);

                HttpContext.Session.SetString("Username", user.Username);

                return RedirectToPage("/Job/Jobs");
            }

            ErrorMessage = "Invalid Email or Password";

            return Page();
            
        }
    }
}
