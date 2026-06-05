using Microsoft.Extensions.Options;
using System.ComponentModel.DataAnnotations;

namespace MachineTest.Model
{
    public class TaskItem
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Title cannot be Empty!!")]
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; }= string.Empty;
        [Required]
        public DateTime DueDate { get; set; }
        public string Status { get; set; }
     


    }
}
