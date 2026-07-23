using System.ComponentModel.DataAnnotations;

namespace JobPortal_Activity2_API.DTOs
{
    public class JobDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Company { get; set; }
        public double Salary { get; set; }
        public string Location { get; set; }
    }
}
