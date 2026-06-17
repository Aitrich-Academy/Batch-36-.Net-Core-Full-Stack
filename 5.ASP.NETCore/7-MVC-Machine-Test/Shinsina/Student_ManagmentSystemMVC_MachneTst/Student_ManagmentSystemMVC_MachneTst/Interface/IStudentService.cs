using Student_ManagmentSystemMVC_MachneTst.Dtos;
using Student_ManagmentSystemMVC_MachneTst.Models;

namespace Student_ManagmentSystemMVC_MachneTst.Interface
{
    public interface IStudentService
    {
        Task<List<Student>> GetAllStudentAsync();
        Task<Student> GetStudentByIdAsync(int id);
        Task AddStudentAsync(StudentDto studentDto);
        Task UpdateStudentAsync(int id, StudentDto studentDto);
        Task DeleteStudentAsync(int id);
      


    }
}
//Add Student
//View Students
//Edit Student
//Delete Student 
