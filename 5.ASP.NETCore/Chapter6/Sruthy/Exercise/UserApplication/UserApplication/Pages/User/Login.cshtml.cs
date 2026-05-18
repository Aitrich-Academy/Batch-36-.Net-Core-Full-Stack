using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UserApplication.Dto;
using UserApplication.Interface;

namespace UserApplication.Pages.User
{
    public class LoginModel : PageModel
    {
        private readonly IUserService _service;

        public LoginModel(IUserService service)
        {
            _service = service;
        }

        [BindProperty]
        public UserDto User { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            ModelState.Remove("User.UserName");
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var result = await _service.Login(
                User.Email,
                User.Password);

            if (result == null)
            {
                ModelState.AddModelError("", "Invalid Email or Password");
                return Page();
            }

            HttpContext.Session.SetInt32("UserId", result.UserId);

            return RedirectToPage("/CompanyMember/Index");
        }
    }
}
