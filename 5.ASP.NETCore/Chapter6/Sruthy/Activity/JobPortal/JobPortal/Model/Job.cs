using Microsoft.Identity.Client;

namespace JobPortal.Model
{
    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string CompanyName { get; set; }
        public string Location { get; set; }
        public decimal Salary {  get; set; }
    }
}
