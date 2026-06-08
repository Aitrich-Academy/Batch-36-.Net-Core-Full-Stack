using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Mvc;

using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        

        
        public static List<Student> _students = new List<Student>
    {
        new Student { Id = 1, Name = "Alice", Email = "alice@example.com", Age = 20 },
        new Student { Id = 2, Name = "Bob", Email = "bob@example.com", Age = 22 }
    };
        public async Task<IActionResult> Index()
        {
            
            return View(_students); 
        }

        public IActionResult Create()
        {
            return View(); 
        }

        [HttpPost]
        public IActionResult Create(Student newStudent)
        {
            newStudent.Id = _students.Count + 1;
            _students.Add(newStudent);
            return RedirectToAction("Index");
        }


        public IActionResult Edit(int id)
        {

          var student = _students.FirstOrDefault(x => x.Id == id);
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
            var student = _students.FirstOrDefault(s => s.Id == updatestudent.Id);
            if (student == null)
            {
                return NotFound();
            }
            student.Name= updatestudent.Name;
            student.Email= updatestudent.Email;
            student.Age= updatestudent.Age;

            return RedirectToAction("Index");





        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var student=_students.FirstOrDefault(s =>s.Id == id);
            if (student == null)
            {

                return NotFound();
            }
            return View(student);


        }


        [HttpPost, ActionName("Delete")]


        public IActionResult DeleteConfirmed(int id)
        {


            var student=_students.FirstOrDefault(s =>s.Id == id);
            if(student == null)
            {  return NotFound();
            }

            _students.Remove(student);
            return RedirectToAction("Index");
        }




        
        
        
        
        
   }
}
