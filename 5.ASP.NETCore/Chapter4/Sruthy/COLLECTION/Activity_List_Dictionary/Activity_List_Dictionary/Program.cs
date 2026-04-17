internal class Program
{
    private static void Main(string[] args)
    {
        // Create list
        List<string> names = new List<string>();

        // 1. Add elements
        names.Add("Anu");
        names.Add("Rahul");
        names.Add("Meera");

        // 2. Add multiple elements
        names.AddRange(new List<string> { "David", "Sonia" });

        // 3. Insert at specific index
        names.Insert(1, "Arun");

        // 4. Display list
        Console.WriteLine("List elements:");
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }

        // 5. Access element by index
        Console.WriteLine("\nElement at index 2: " + names[2]);

        // 6. Count
        Console.WriteLine("Total elements: " + names.Count);

        // 7. Check existence
        if (names.Contains("Rahul"))
        {
            Console.WriteLine("Rahul exists");
        }

        // 8. IndexOf
        Console.WriteLine("Index of Meera: " + names.IndexOf("Meera"));

        // 9. Remove by value
        names.Remove("Rahul");

        // 10. Remove by index
        names.RemoveAt(0);

        // 11. Remove all matching
        names.RemoveAll(x => x.Contains("a"));

        // 12. Sort list
        names.Sort();

        // 13. Reverse list
        names.Reverse();


        Console.WriteLine("\nUpdated List:");
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
        Console.ReadLine();




        //dictionary


        Dictionary<int, string> employees = new Dictionary<int, string>();

        // Add
        employees.Add(101, "John");
        employees.Add(102, "Alice");
        employees.Add(103, "David");

        Console.WriteLine("Initial Data:");
        foreach (var item in employees)
        {
            Console.WriteLine(item.Key + " - " + item.Value);
        }

        // ContainsKey
        Console.WriteLine("\nCheck ID 102:");
        if (employees.ContainsKey(102))
            Console.WriteLine("ID exists");
        else
            Console.WriteLine("ID not found");

        // ContainsValue
        Console.WriteLine("\nCheck Name 'Alice':");
        if (employees.ContainsValue("Alice"))
            Console.WriteLine("Name exists");
        else
            Console.WriteLine("Name not found");

        // Remove
        Console.WriteLine("\nRemoving ID 103...");
        employees.Remove(103);

        Console.WriteLine("After Removal:");
        foreach (var item in employees)
        {
            Console.WriteLine(item.Key + " - " + item.Value);
        }

        // Clear
        Console.WriteLine("\nClearing all data...");
        employees.Clear();

        Console.WriteLine("Total items after clear: " + employees.Count);
    }
}