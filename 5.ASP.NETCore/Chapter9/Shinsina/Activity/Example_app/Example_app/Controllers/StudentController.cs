using Example_app.Models;
using Microsoft.AspNetCore.Mvc;

namespace Example_app.Controllers
{
    public class StudentController : Controller
    {
        public static List<Student> students = new List<Student>
        {
            new Student{ID=1,Name="Sana",Email="sanae@gmail.com",Age=23},
            new Student{ID=2,Name="Sonakshi",Email="sanae@gmail.com",Age=35}
        };
        public async Task<IActionResult> Index()
        {
            return View(students);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student newStudent)
        {
            newStudent.ID = students.Count + 1;
            students.Add(newStudent);
            return RedirectToAction("Index");
        }


        public IActionResult Edit(int id)
        {

            var student = students.FirstOrDefault(x => x.ID == id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);


        }

        [HttpPost]
        public IActionResult Edit(Student updatestudent)
        {

            if (!ModelState.IsValid)
            {
                return View(updatestudent);
            }
            var student = students.FirstOrDefault(s => s.ID == updatestudent.ID);
            if (student == null)
            {
                return NotFound();
            }
            student.Name = updatestudent.Name;
            student.Email = updatestudent.Email;
            student.Age = updatestudent.Age;

            return RedirectToAction("Index");





        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var student = students.FirstOrDefault(s => s.ID== id);
            if (student == null)
            {

                return NotFound();
            }
            return View(student);


        }


        [HttpPost, ActionName("Delete")]


        public IActionResult DeleteConfirmed(int id)
        {


            var student = students.FirstOrDefault(s => s.ID == id);
            if (student == null)
            {
                return NotFound();
            }

            students.Remove(student);
            return RedirectToAction("Index");
        }







    }
}
