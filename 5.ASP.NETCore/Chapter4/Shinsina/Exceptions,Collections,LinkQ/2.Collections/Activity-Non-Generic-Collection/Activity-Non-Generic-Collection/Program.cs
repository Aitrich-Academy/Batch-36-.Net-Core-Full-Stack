using System.Collections;
using System.ComponentModel.DataAnnotations;

internal class Program
{
    private static void Main(string[] args)
    {
        List<string> jobList = new List<string>();
        Console.WriteLine("=== ArrayList: Job Listings ===");
        //Add
        jobList.Add("\nSoftware Engineer");
        jobList.Add("UI Designer");
        jobList.Add("Project Manager");
        jobList.Add("Test Engineer");
        jobList.Add(".Net Developer");
  

        Display(jobList)    ;

        //removing
        Console.WriteLine("\n-----------------------------------------------------");
        Console.WriteLine("\n=== ArrayList:Removing Job Listings ===");

        jobList.Remove("UI Designer");
        Display(jobList);

        //insert
        Console.WriteLine("\n-----------------------------------------------------");
        Console.WriteLine("\n=== ArrayList:Inserting Job  ===");
        jobList.Insert(2,"WebDeveloper");
        Display(jobList);

        //count
        Console.WriteLine("\n-----------------------------------------------------");
        Console.WriteLine("\n=== ArrayList:Total Count===");
        Console.WriteLine("Count : "+jobList.Count);



        //Hashtable

        Console.WriteLine("\n-------------2---HashTable--------------");
        Console.WriteLine("\n");
        Hashtable Employershashtable = new Hashtable()
        {
            {102,"Arun" },
            {103,"Soniya" },
            {105,"Keethi" },
            {108,"Kurian" }
        };
        foreach ( DictionaryEntry items1 in Employershashtable)
        {
            Console.WriteLine(items1.Key+" "+items1.Value);

        }

        Console.WriteLine("enter the employee Id");
       int EmployeeId=Convert.ToInt32( Console.ReadLine());
        if (Employershashtable.ContainsKey(EmployeeId))
        {
            Console.WriteLine("\nFound");
            Console.WriteLine("ID: " + EmployeeId +
                              " Name: " + Employershashtable[EmployeeId]);
        }
        else
        {
            Console.WriteLine("Employee not found");
        }

        Console.WriteLine("\nUpdated Employee List");
        Employershashtable.Remove(103);
        foreach(DictionaryEntry item in Employershashtable)
        {
           
            Console.WriteLine(item.Key+" "+item.Value);
        }


        //Console.WriteLine("\nEnter the employee name:");
        //string EmployeeName = Console.ReadLine();

        //// Use ContainsValue to search by Name instead of ID
        //if (Employershashtable.ContainsValue(EmployeeName))
        //{
        //    // To get the ID (Key) associated with the Name (Value), 
        //    // we have to loop through since Hashtables map Key -> Value, not Value -> Key.
        //    foreach (DictionaryEntry entry in Employershashtable)
        //    {
        //        if (entry.Value.ToString() == EmployeeName)
        //        {
        //            Console.WriteLine("Found: ID " + entry.Key + " Name " + entry.Value);
        //        }
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("Employer not found");
        //}

        //Sortedlist
        // 3. SortedList – Candidate Profiles
        // =========================
        Console.WriteLine("\n=== SortedList: Candidate Profiles ===");

        SortedList candidates = new SortedList()
        {
            {110, "Alice"},
            {105, "Bob"},
            {120, "Charlie"},
            {101, "David"},
            {115, "Eve"}
        };

        Console.WriteLine("Sorted Candidates:");
        foreach (DictionaryEntry c in candidates)
            Console.WriteLine(c.Key + " -> " + c.Value);

        Console.WriteLine("Contains ID 105? " + candidates.ContainsKey(105));

        Console.WriteLine("Index of Charlie: " + candidates.IndexOfValue("Charlie"));

        // Remove
        candidates.Remove(110);

        Console.WriteLine("\nAfter Removal:");
        foreach (DictionaryEntry c in candidates)
            Console.WriteLine(c.Key + " -> " + c.Value);

        Console.WriteLine("Total Candidates: " + candidates.Count);


        // =========================
        // 4. Stack – Application History
        // =========================
        Console.WriteLine("\n=== Stack: Application History ===");

        Stack stack = new Stack();
        stack.Push("Applied for Developer");
        stack.Push("Applied for Tester");
        stack.Push("Applied for Analyst");
        stack.Push("Applied for Manager");

        Console.WriteLine("Applications:");
        foreach (var s in stack)
            Console.WriteLine(s);

        Console.WriteLine("Last Application: " + stack.Peek());

        stack.Pop();

        Console.WriteLine("\nAfter Pop:");
        foreach (var s in stack)
            Console.WriteLine(s);

        Console.WriteLine("Total Applications: " + stack.Count);


        // =========================
        // 5. Queue – Interview Scheduling
        // =========================
        Console.WriteLine("\n=== Queue: Interview Scheduling ===");

        Queue queue = new Queue();
        queue.Enqueue("John");
        queue.Enqueue("Emma");
        queue.Enqueue("Liam");
        queue.Enqueue("Olivia");
        queue.Enqueue("Noah");

        Console.WriteLine("Queue:");
        foreach (var q in queue)
            Console.WriteLine(q);

        queue.Dequeue();

        Console.WriteLine("\nAfter Dequeue:");
        foreach (var q in queue)
            Console.WriteLine(q);

        Console.WriteLine("Next Candidate: " + queue.Peek());
        Console.WriteLine("Total Candidates: " + queue.Count);
    


}
   
    private static void Display(List<string> jobList)
    {
        foreach (var job in jobList)
        {
            Console.WriteLine(job);
        }
    }


    
   
}