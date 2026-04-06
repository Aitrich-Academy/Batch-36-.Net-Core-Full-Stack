internal class Program
{
    public class Job
    {
        public string Title { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public double Salary { get; set; }

    }

    public class InvalidSalaryException : Exception
    {
        public InvalidSalaryException(string message) : base(message)
        {

        }
    }
    private static void Main(string[] args)
    {
        List<Job> jobs = new List<Job>()
        {
            new Job { Title="Software Developer",Company="Aabasoft",Location="Kochi",Salary=4500},
            new Job { Title = "Tester", Company = "Darwish", Location = "Kochi", Salary = 5000 },
            new Job { Title = ".NET Developer", Company = "Wipro", Location = "Kochi", Salary = 2000 },
            new Job { Title="System Engineer",Company="TCS",Location="Trivandram",Salary=2500},
            new Job { Title="Back-End Developer",Company="Manapuram Tech",Location="Thrissur",Salary=4500},
        };

        bool search = true;
        while (search)
        {
            try
            {
                Console.WriteLine("WELCOME TO JOB PORTAL");
                Console.WriteLine("Enter your Expected Salary : ");
                string input = Console.ReadLine();

                double minsalary = Convert.ToDouble(input);

                //linQ
                var result = jobs.Where(i => i.Location == "Kochi" && i.Salary > minsalary)
                    .OrderByDescending(i => i.Salary)
                    .Select(i => new { i.Title, i.Company, i.Salary }).ToList();

                Console.WriteLine("Matching Jobs : ");

                if (result.Count == 0)
                {
                    Console.WriteLine("Nojobs are available..");
                    Console.WriteLine("Press any key and You can try again....");
                }
                else
                {
                    //Console.WriteLine("{0,-25} {1,-25} {2,-25}", "Title", "Company", "Salary");
                    //Console.WriteLine(new string('-', 55));
                    foreach (var job in result)
                    {
                       //Console.WriteLine("{0,-25}{1,-25}{2,-25",job.Title,job.Company,job.Salary);
                        Console.WriteLine($"Title : {job.Title},Company : {job.Company},Salary : {job.Salary}");
                    }
                }

                Console.WriteLine("Do you want to search again? (Y/N) : ");
                string choice = Console.ReadLine().ToLower();

                if( choice != "y")
                {
                    search= false;
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid input. Please enter a numeric salary.");
                Console.WriteLine(ex.Message);
            }
            catch (InvalidSalaryException ex)
            {
                Console.WriteLine("Expected salary must be greater than zero");
                Console.WriteLine(ex.Message);
            }

           
            Console.ReadLine();
        }
    }
}