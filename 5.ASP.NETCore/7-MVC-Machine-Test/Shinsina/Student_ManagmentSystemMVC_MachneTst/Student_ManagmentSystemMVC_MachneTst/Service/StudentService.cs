using Student_ManagmentSystemMVC_MachneTst.Dtos;
using Student_ManagmentSystemMVC_MachneTst.Interface;
using Student_ManagmentSystemMVC_MachneTst.Models;
using Microsoft.EntityFrameworkCore;

namespace Student_ManagmentSystemMVC_MachneTst.Service
{
    public class StudentService:IStudentService
    {
        private readonly ApplicationDbContext _context;
        public StudentService(ApplicationDbContext context)
        {
            _context = context;
        }

       public async Task<List<Student>> GetAllStudentAsync()
        {
            return await _context.Students.ToListAsync();
        }
        public async Task<Student> GetStudentByIdAsync(int id)
        {
            return await _context.Students.FindAsync(id);
        }
        public async Task AddStudentAsync(StudentDto studentDto)
        {
            Student student = new Student()
            {
                Name = studentDto.Name,
                Course = studentDto.Course,
                Age = studentDto.Age
            };
            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateStudentAsync(int id, StudentDto studentDto)
        {
            var student = await _context.Students.FindAsync(id);
            if(student != null)
            {
                student.Name= studentDto.Name;
                student.Course= studentDto.Course;
                student.Age= studentDto.Age;

                await _context.SaveChangesAsync();

            }
        }
        public async Task DeleteStudentAsync(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if( student != null)
            {
                _context.Students.Remove(student);
                await _context.SaveChangesAsync();
            }
        }
    }
}
