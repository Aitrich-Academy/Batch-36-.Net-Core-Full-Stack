using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UserApplication.Interface;
using UserApplication.Dto;

namespace UserApplication.Pages.CompanyMember
{
    public class IndexModel : PageModel
    {
        private readonly ICompanyMemberService _service;
        private readonly IUserService _userService;

        public IndexModel(ICompanyMemberService service, IUserService userService)
        {
            _service = service;
            _userService = userService;
        }

        public List<CompanyMemberDto> Members { get; set; }

        public string UserName { get; set; }

        public async Task<IActionResult> OnGet()
        {
            var userId = HttpContext.Session.GetInt32("UserId");

            if (userId == null)
            {
                return RedirectToPage("/User/Login");
            }

            var user = await _userService.GetUserById(userId.Value);
            UserName = user.UserName;

            Members = await _service.GetAllAsync(userId.Value);

            return Page();

        }
    }
}
