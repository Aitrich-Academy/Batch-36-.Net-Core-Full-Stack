using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UserApplication.Dto;
using UserApplication.Interface;

namespace UserApplication.Pages.CompanyMember
{
    public class DeleteModel : PageModel
    {
        private readonly ICompanyMemberService _service;

        public DeleteModel(ICompanyMemberService service)
        {
            _service = service;
        }

        public CompanyMemberDto Member { get; set; }

        public async Task<IActionResult> OnGet(int id)
        {
            var userId = HttpContext.Session.GetInt32("UserId");

            if (userId == null)
                return RedirectToPage("/User/Login");

            var members = await _service.GetAllAsync(userId.Value);

            Member = members.FirstOrDefault(x => x.CompanyMemberId == id);

            if (Member == null)
                return RedirectToPage("Index");

            return Page();
        }

        public async Task<IActionResult> OnPost(int id)
        {
            await _service.DeleteCompanyMemberAsync(id);

            return RedirectToPage("Index");
        }
    }
}
