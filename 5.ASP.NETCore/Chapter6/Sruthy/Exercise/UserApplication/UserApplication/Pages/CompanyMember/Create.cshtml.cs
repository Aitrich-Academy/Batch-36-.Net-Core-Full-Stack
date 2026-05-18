using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UserApplication.Dto;
using UserApplication.Interface;

namespace UserApplication.Pages.CompanyMember
{
    public class CreateModel : PageModel
    {
        private readonly ICompanyMemberService _service;

        public CreateModel(ICompanyMemberService service)
        {
            _service = service;
        }

        [BindProperty]
        public CompanyMemberDto Member { get; set; }

        public async Task<IActionResult> OnPost()
        {
            var userId = HttpContext.Session.GetInt32("UserId");

            if (userId == null)
            {
                return RedirectToPage("/User/Login");
            }

            await _service.AddCompanyMemberAsync(Member, userId.Value);

            return RedirectToPage("Index");
        }
    }
}
