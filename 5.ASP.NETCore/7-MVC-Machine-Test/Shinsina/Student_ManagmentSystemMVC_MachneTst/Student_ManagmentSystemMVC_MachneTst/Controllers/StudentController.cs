using Microsoft.AspNetCore.Mvc;
using Student_ManagmentSystemMVC_MachneTst.Dtos;
using Student_ManagmentSystemMVC_MachneTst.Interface;

namespace Student_ManagmentSystemMVC_MachneTst.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        private bool IsLoggedIn()
        {
            return HttpContext.Session.GetString("User") != null;
        }
        public IActionResult Dashboard()
        {
            if (!IsLoggedIn())
                return RedirectToAction("Login", "Account");
            ViewBag.User = HttpContext.Session.GetString("User");
            return View();
        }
        public async Task<IActionResult> Index()
        {
            if (!IsLoggedIn())
                return RedirectToAction("Login", "Account");
            var students=await _studentService.GetAllStudentAsync();
            return View(students);
        }
        public IActionResult Create()
        {
            if (!IsLoggedIn())
                return RedirectToAction("Login","Account");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(StudentDto studentDto) 
        {
            if(!ModelState.IsValid)
                return View(studentDto);
            await _studentService.AddStudentAsync(studentDto);
            return RedirectToAction("Dashboard","Student");
        }
        public async Task<IActionResult> Edit(int id)
        {
            if (!IsLoggedIn())
                return RedirectToAction("Login", "Account");
            var student=await _studentService.GetStudentByIdAsync(id);
            if (student == null)
                return NotFound();
            StudentDto studentDto = new StudentDto()
            {
                Name = student.Name,
                Course = student.Course,
                Age = student.Age
            };
            ViewBag.Id = id;
            return View(studentDto);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id,StudentDto studentDto)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Id = id;
                return View(studentDto);

            }
            await _studentService.UpdateStudentAsync(id, studentDto);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int id)
        {
          await _studentService.DeleteStudentAsync(id);
            return RedirectToAction(nameof(Index));
        }


    }
}
