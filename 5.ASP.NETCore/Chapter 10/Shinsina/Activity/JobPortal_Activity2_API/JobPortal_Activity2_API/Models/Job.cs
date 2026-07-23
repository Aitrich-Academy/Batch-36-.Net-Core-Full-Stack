using System.ComponentModel.DataAnnotations;

namespace JobPortal_Activity2_API.Models
{
    public class Job
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Company {  get; set; }

        [Required]
        public double Salary { get; set; }
        [Required]
        public string Location { get; set; }
        public DateTime CreatedDate { get; set; }


    }
}
