using System.ComponentModel.DataAnnotations;

namespace Student_ManagmentSystemMVC_MachneTst.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Name is Required")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Course is Required")]
        public string Course { get; set; }

        [Range(1,90,ErrorMessage ="Age must greater than 0")]
        public int Age { get; set; }
    }
}
