using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UserApplication.Dto;
using UserApplication.Interface;

namespace UserApplication.Pages.User
{
    public class RegisterModel : PageModel
    {
        private readonly IUserService _service;
        public RegisterModel(IUserService service)
        {
            _service = service;
        }

        [BindProperty]
        public UserDto User { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _service.Register(User);

            return RedirectToPage("Login");
        }
    }
}
