namespace Login_Exercise_1_Blazor.Model
{
    public class Job
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string JobType { get; set; }
        public decimal Salary { get; set; }
        public int SeekerID { get; set; } // Foreign Key
        public Seeker Seeker { get; set; }
    }
}
