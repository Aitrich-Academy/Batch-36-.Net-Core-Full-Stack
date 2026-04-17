using MachineTest;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Job> job = new List<Job>
        {
            new Job {JobId =1, Title="Software Developer",Company="Aabasoft", Location="Kochi", Salary=40000},
            new Job {JobId =2, Title="Fullstack Developer",Company="Aitrich", Location="Thrissur", Salary=60000},
            new Job {JobId =3, Title="UI/UX Designer",Company="Cognisent", Location="Kochi", Salary=50000},
            new Job {JobId =4, Title="Fullstack Developer",Company="LTTech", Location="Trivandrum", Salary=560000},
            new Job {JobId =5, Title="Software Developer",Company="InfoBlaze Tech", Location="Technopark", Salary=70000}
        };
        Console.WriteLine("\n\nThe jobs in the list are:\n");
        Console.WriteLine("Id\tTitle\tCompany\tLocation\tSalary");
        foreach (var j in job)
        {
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine($"{j.JobId}\t{j.Title}\t{j.Company}\t{j.Location}\t{j.Salary}");
        }
        while (true)
        {
            try
            {
                Console.WriteLine("\n\nEnter the expected salary: ");
                decimal exSalary = Convert.ToDecimal(Console.ReadLine());
                if (exSalary <= 0)
                {
                    throw new InvalidSalaryException("Expected salary must be greater than zero ");
                }
                Console.WriteLine("\n\nList of job Based on Location and Salary using LinQ");
                var findJobs = job
                            .Where(jobs => jobs.Location == "Kochi" && jobs.Salary > exSalary)
                            .OrderByDescending(jobs => jobs.Salary)
                            .Select(job => new
                            {
                                job.Title,
                                job.Company,
                                job.Salary

                            });
                Console.WriteLine("\n\nTitle\t\tCompany\t\tSalary");
                foreach (var j in findJobs)
                {
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine($"{j.Title}\t{j.Company}\t{j.Salary}\n");
                }
                return;

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input, please enter a numerical salary");
            }
            catch (InvalidSalaryException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}