internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\n\nList\n\n");
        List<string> JobTitle = new List<string>();
        JobTitle.Add("Java Developer");
        JobTitle.Add("DotNet Developer");
        JobTitle.Add("Software Tester");
        JobTitle.Add("Backend Developer");
        JobTitle.Add("Web Developer");
        foreach (var item in JobTitle) { 
            Console.WriteLine(item);
        }
        Console.WriteLine("\n\nAfter Inserting at index 2:\n");
        JobTitle.Insert(2, "Database Admin");
        foreach (var item in JobTitle)
        {
            Console.WriteLine(item);
        }
        if(JobTitle.Contains("Software Engineer"))
        {
            Console.WriteLine("\n\nSoftware Engineer Job Title Exist in the list\n");
        }
        else
        {
            Console.WriteLine("\n\nSoftware Engineer Job Title dosenot Exist in the list\n");
        }
        Console.WriteLine("\n\nupdated list After removing one job\n");
        JobTitle.Remove("Web Developer");
        foreach (var item in JobTitle)
        {
            Console.WriteLine(item);
        }
        Console.ReadLine();


        //Dictionary
        Console.WriteLine("\n\nDictionary\n\n");
        Dictionary<int,string> Job= new Dictionary<int,string>();

        Job.Add(1001, "Java Developer");
        Job.Add(1002, "Python Developer");
        Job.Add(1003, "Web Developer");
        Job.Add(1004, "Software Tester");
        Job.Add(1005, "DotNet Developer");
        string name;
        Console.WriteLine("Job ID\tJob Title");
        foreach (KeyValuePair<int, string> job in Job)
        {
            Console.WriteLine($"{job.Key}\t{job.Value}");
        }

        if (Job.ContainsKey(1002))
        {
            Console.Write("\n\nThe ID 1002 Exist in the Dictionary. ");
            if(Job.TryGetValue(1002,out name))
            {
                Console.WriteLine("The corresponding Job is: " + name);
            }
        }
        else
        {
            Console.WriteLine("\n\nJob Not Found\n\n");
        }
        Console.WriteLine("\n\nOriginal Job Title for 1001: " + Job[1001]);

        // Update job title using indexer
        Job[1001] = "Senior Java Developer";

        // Display updated job title
        Console.WriteLine("Updated Job Title for 1001: " + Job[1001]);

        Job.Remove(1003);
        Console.WriteLine("\n\n Updated list after removing Job 1003\n\n");
        Console.WriteLine("Job ID\tJob Title");
        foreach (KeyValuePair<int,string> job in Job )
        {
            Console.WriteLine($"{job.Key}\t{job.Value}");
        }
        Console.ReadLine() ;



    }
}