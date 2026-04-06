
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\n\n---------------ArrayList-----------------");
       ArrayList JobTitle=new ArrayList(); 
        JobTitle.Add("Software Engineer");
        JobTitle.Add("UI Designer");
        JobTitle.Add("Backend Developer");
        JobTitle.Add("Accountant");
        JobTitle.Add("HR Manager");
        foreach (var item in JobTitle)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("\n\nAfter Removing one element, Updates list:\n");
        JobTitle.Remove("Software Engineer");
        foreach (var item in JobTitle)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("\n\nAfter Inserting new job at index 2:\n");
        JobTitle.Insert(2, "Frontend Developer");
        foreach (var item in JobTitle)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("\n\nTotal Number of Jobs: " + JobTitle.Count);
        Console.ReadLine();



        ///HashTable
        Console.WriteLine("\n\n---------------HashTable-----------------");
        Hashtable Employer=new Hashtable();
        Employer.Add(1001, "David");
        Employer.Add(1002, "Arun");
        Employer.Add(1003, "Jaani");
        Employer.Add(1004, "Surya");
        Employer.Add(1005, "Jannah");

        foreach (DictionaryEntry entry in Employer)
        {
            Console.WriteLine("Employer ID: " + entry.Key + "  Employer Name: " + entry.Value);
        }
        Console.WriteLine();
        Console.WriteLine("Enter an Employer ID to check whether its exists or not: ");
        int key=Convert.ToInt32(Console.ReadLine());
        if (Employer.ContainsKey(key))
        {
            Console.WriteLine("Employer Exists!! ");
            Console.WriteLine("Employer Name is: " + Employer[key]);
        }
        else
        {
            Console.WriteLine("Employer not found!!!");

        }
        Employer.Remove(1001);
        Console.WriteLine("\n\nUpdated list after removing one employer from the list");
        foreach (DictionaryEntry entry in Employer)
        {
            Console.WriteLine("Employer ID: " + entry.Key + "  Employer Name: " + entry.Value);
        }
        Console.ReadLine();



        ///SortedList
        ///
        Console.WriteLine("\n\n---------------Sorted List-----------------");
        SortedList Candidate=new SortedList();
        Candidate.Add(142, "Jerry");
        Candidate.Add(423, "Geetha");
        Candidate.Add(132, "Madhu");
        Candidate.Add(265, "Veena");
        Candidate.Add(101, "Balu");

        Console.WriteLine("Candidate List (Sorted by ID):");

        foreach (DictionaryEntry item in Candidate)
        {
            Console.WriteLine("ID: " + item.Key + ", Name: " + item.Value);
        }
        if(Candidate.ContainsKey(105))
        {
            Console.WriteLine("Candidate Exists with ID 105");
        }
        else
        {
            Console.WriteLine("Candidate doesnot Exist with ID 105");
        }
        int index = Candidate.IndexOfValue("Geetha");
        Console.WriteLine("\n\nIndexOfValue()\nThe ID of Candidate Geetha is: "+index);

        Candidate.Remove(132);
        Console.WriteLine("\n\nUpdated list after removing one element from the sorted list");
        foreach (DictionaryEntry item in Candidate)
        {
            Console.WriteLine("ID: " + item.Key + ", Name: " + item.Value);
        }

        Console.WriteLine("\n\nTotal Number of Candidates : "+Candidate.Count);
        Console.ReadLine();


        ///Stack
        ///
        Console.WriteLine("\n\n---------------Stack-----------------");
        Stack Application=new Stack();
        Application.Push("Applied for Developer");
        Application.Push("Applied for Manager");
        Application.Push("Applied for Tester");
        Application.Push("Applied for Intern");
        Application.Push("Applied for Engineer");
        Console.WriteLine("\n\nAll Application :");
        foreach (var action in Application)
        {
            Console.WriteLine(action);
        }



        Console.WriteLine("\n\nLast Applied Job: "+Application.Peek());

        Application.Pop();
        Console.WriteLine("\n\nAfter withdrawing the last application:");
        foreach (var action in Application)
        {
            Console.WriteLine(action);
        }

        Console.WriteLine("\n\nTotal Number of applications remaining: "+Application.Count); 
        Console.ReadLine();


        ///Queue
        ///

        Console.WriteLine("\n\n---------------Queue-----------------");
        Queue InterviewCandidate=new Queue();
        InterviewCandidate.Enqueue("John");
        InterviewCandidate.Enqueue("Riya");
        InterviewCandidate.Enqueue("Suja");
        InterviewCandidate.Enqueue("Rishab");
        InterviewCandidate.Enqueue("Sanju");
        InterviewCandidate.Enqueue("Meera");

        Console.WriteLine("\n\nCandidates :");
        foreach (var candidate in InterviewCandidate)
        {
            Console.WriteLine(candidate);
        }

        InterviewCandidate.Dequeue();
        Console.WriteLine("\n\nAfter the first candidate is served Updated Candidate list :");
        foreach (var candidate in InterviewCandidate)
        {
            Console.WriteLine(candidate);
        }
        Console.WriteLine("\n\nNext candidate waiting is: "+InterviewCandidate.Peek());
        Console.WriteLine("\n\nThe total number of candidates left: "+InterviewCandidate.Count);
        Console.ReadLine();

       
    }


}