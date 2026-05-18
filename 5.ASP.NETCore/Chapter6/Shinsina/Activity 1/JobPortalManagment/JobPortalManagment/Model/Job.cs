namespace JobPortalManagment.Migrations.Model
{
    public class Job
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public string EnvironmentType { get; set; }
        public decimal Salary { get; set; }
         public string Description { get; set; }
        public string Requirements { get; set; }
        public DateTime PostedDate { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
