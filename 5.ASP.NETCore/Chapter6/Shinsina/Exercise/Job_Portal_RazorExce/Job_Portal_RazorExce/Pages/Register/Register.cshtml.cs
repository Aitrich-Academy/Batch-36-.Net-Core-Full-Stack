using Job_Portal_RazorExce.DTO;
using Job_Portal_RazorExce.Interface;
using Job_Portal_RazorExce.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Job_Portal_RazorExce.Pages.Jobs
{
    public class RegisterModel : PageModel
    {
        //private readonly IUserRepository _repo;

        //public RegisterModel(IUserRepository repo)
        //{
        //    _repo = repo;
        //}
        private readonly IUserService _service;

        public RegisterModel(IUserService service)
        {
            _service = service;
        }
        [BindProperty]
        public User User { get; set; }

        public async Task<IActionResult> OnPost()
        {
            //var users = _service.GetUsers() ?? new List<User>();
            var users = await _service.GetUsers() ?? new List<User>();

            var emailExists = users.Any(x => x.Email == User.Email);

            if (emailExists)
            {
                TempData["ErrorMessage"] = "Email already exists";
                return Page();
            }

            _service.Register(new User
            {
                Username = User.Username,
                Email = User.Email,
                Password = User.Password
            });

            TempData["SuccessMessage"] = "Registration Successful";

            return RedirectToPage("/Login/Login");
        }
    }
}
       
    
