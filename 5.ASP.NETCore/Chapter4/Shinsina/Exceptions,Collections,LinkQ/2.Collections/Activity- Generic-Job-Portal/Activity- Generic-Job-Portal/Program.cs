using System.Collections;
using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("1).List:");
        List<string> jobTitles = new List<string>();

        jobTitles.Add (".Net Developer");
        jobTitles.Add ("Project Manager");
        jobTitles.Add ("Full stack Developer");
        jobTitles.Add ("Tester");

        
        foreach (var item in jobTitles)
        {
            Console.WriteLine(item);
        }
        

        Console.WriteLine("\n After Inserting new job titles:");
        jobTitles.Insert(3,"Data Analyst");
        jobTitles.Insert(2, "DevOps Engineer");
        foreach(var insert in jobTitles)
        {
            Console.WriteLine(insert);
        }

        Console.WriteLine("\n cheking   job titles:");
        if (jobTitles.Contains("Project Manager"))
        {
            Console.WriteLine("it exist");
        }
        else {
            Console.WriteLine("not exist");
        }

        Console.WriteLine("\n After removing job titles:");

        jobTitles.Remove("Tester");
        foreach( var item2 in jobTitles)
        {
            Console.WriteLine(item2);
        }


        //2.Dictionary
        Console.WriteLine("\n\n2). Dictionary");
        Dictionary<int,string> jobs=new Dictionary<int,string>();
        jobs.Add(102, "Software Developer");
        jobs.Add(103, "Tester");
        jobs.Add(104, ".Net Developer");
        jobs.Add(105, "System Admin");
        jobs.Add(106, "Data Analyst");
        foreach (var item3 in jobs)
        {
           
            Console.WriteLine($"ID: {item3.Key}, Title: {item3.Value}");
        }

        Console.WriteLine("\n cheking   job titles:");
        if (jobs.ContainsKey(1003))
        {
            Console.WriteLine("It exists");

            if (jobs.TryGetValue(103, out string jobTitle))
            {
                Console.WriteLine($"ID: 103, Name: {jobTitle}");
            }
        }
        else
        {
            Console.WriteLine("Job not found");
        }

        Console.WriteLine("\n after updating job name: ");
        jobs[103] = "updated job name";
        foreach (var item4 in jobs)
        {
            Console.WriteLine($"ID : {item4.Key},Job Name :{item4.Value}");
        }
        Console.WriteLine("\n After removing job");
        jobs.Remove(105);
        foreach(var item5 in jobs)
        {
            Console.WriteLine($"ID: {item5.Key},Job NAme : {item5.Value}");
        }

        //SortedList
        Console.WriteLine("\n3).SortedList");
        SortedList<int, string> sortedJobs = new SortedList<int, string>();
        // Add random IDs
        sortedJobs.Add(105, "QA Tester");
        sortedJobs.Add(103, "Web Developer");
        sortedJobs.Add(102, "Data Analyst");
        sortedJobs.Add(104, "System Admin");
        foreach( var item6 in sortedJobs)
        {
            Console.WriteLine($"ID:{item6.Key},Job NAme :{item6.Value}");
        }

        // Get by index
        //Console.WriteLine("Job at index 2: " + sortedJobs.GetByIndex(2));

        Console.WriteLine("\n Cheking the job title");
        if (sortedJobs.ContainsKey(103))
        {
            Console.WriteLine("it exist");
            if (sortedJobs.TryGetValue(103,out string jobtitle))
            {
                Console.WriteLine($"ID: 103, Name: {jobtitle}");
            }
        }
        else
        {
            Console.WriteLine("not Found");
        }
        Console.WriteLine("\n Removing the job title");
        sortedJobs.Remove(104);
        sortedJobs.RemoveAt(0);
        foreach(var job in sortedJobs)
        {
            Console.WriteLine($"Id:{job.Key},Name:{job.Value}");
        }
        //Stack
        Console.WriteLine("\n\n4).Stack");
        Stack<string> stackname= new Stack<string>();
        // Push
        Console.WriteLine("\nAddding Candidate name using push:");
        stackname.Push("John Doe");
        stackname.Push("Alice");
        stackname.Push("Bob");
        stackname.Push("Charlie");
        stackname.Push("David");

        foreach(string name in stackname)
        {
            Console.WriteLine(name);
        }
        //peek
        Console.WriteLine("\nCantidate at peek :" + stackname.Peek());

        //pop
        Console.WriteLine("\nusing pop:" + stackname.Pop());
        Console.WriteLine("using pop:" + stackname.Pop());
        Console.WriteLine("\n After pop");
        foreach(var candidatename  in stackname)
        {
            Console.WriteLine(candidatename);
        }

        //contain
        Console.WriteLine("\nCheking candidate present or not:");
        if (stackname.Contains("Alice"))
        {
            Console.WriteLine("still in stack.");
        }
        else
        {
            Console.WriteLine("not present");
        }
        //Queue
        Console.WriteLine("\n5).Queue");
        Queue<string> queueName=    new Queue<string>();
        Console.WriteLine("\nAdding name using Queue:");
        // Enqueue
        queueName.Enqueue("Alice");
        queueName.Enqueue("Bob");
        queueName.Enqueue("Charlie");
        queueName.Enqueue("David");
        queueName.Enqueue("Eve");
        foreach(var que in queueName)
        {
            Console.WriteLine(que);
        }

        //peek
        Console.WriteLine("\n Candidate at the peek");
        Console.WriteLine("Candidate name:"+ queueName.Peek());

        //Dequeue
        queueName.Dequeue();
        queueName.Dequeue();
        Console.WriteLine("\n After dequeue :");
        foreach(var deque in queueName)
        {
            Console.WriteLine(deque);
        }

        //Contain
        Console.WriteLine("\n Checking whearher  \"Alice\" is in the Queue or not");
        if (queueName.Contains("Alice"))
        {
            Console.WriteLine("\"Alice\" is in the queue");
        }
        else
        {
            Console.WriteLine("Not in the queue");
        }
        Console.WriteLine("\nDisplay remaining candidates in queue.:");
        foreach(var deque1 in queueName)
        {
            Console.WriteLine(deque1);
        }
        Console.ReadKey();
    }
}
