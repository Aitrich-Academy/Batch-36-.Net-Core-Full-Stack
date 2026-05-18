using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UserApplication.Dto;
using UserApplication.Interface;

namespace UserApplication.Pages.CompanyMember
{
    public class UpdateModel : PageModel
    {
        private readonly ICompanyMemberService _service;

        public UpdateModel(ICompanyMemberService service)
        {
            _service = service;
        }

        [BindProperty]
        public CompanyMemberDto Member { get; set; }

        public async Task<IActionResult> OnGet(int id)
        {
            Console.WriteLine(id);
            var userId = HttpContext.Session.GetInt32("UserId");

            if (userId == null)
                return RedirectToPage("/User/Login");

            var members = await _service.GetAllAsync(userId.Value);

            Member = members.FirstOrDefault(x => x.CompanyMemberId == id);

            if (Member == null)
            {
                Console.WriteLine("NULL DATA");
                ModelState.AddModelError("", "Record not found");
                return Page();
            }

            return Page();
        }

        public async Task<IActionResult> OnPost(int id)
        {
            var userId = HttpContext.Session.GetInt32("UserId");

            if (userId == null)
                return RedirectToPage("/User/Login");

            await _service.UpdateCompanyMemberAsync(id, Member);

            return RedirectToPage("Index");
        }
    }
}
