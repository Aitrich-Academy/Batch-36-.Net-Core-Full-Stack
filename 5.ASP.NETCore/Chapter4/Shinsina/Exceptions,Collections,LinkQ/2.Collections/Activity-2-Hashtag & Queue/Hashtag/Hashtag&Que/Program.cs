using System;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        // Create Hashtable
        Hashtable ht = new Hashtable();

        // 🔹 Add
        ht.Add(1, "Apple");
        ht.Add(2, "Banana");
        ht.Add(3, "Mango");

        Console.WriteLine("After Adding:");
        foreach (DictionaryEntry item in ht)
        {
            Console.WriteLine(item.Key + " : " + item.Value);
        }

        // 🔹 Count
        Console.WriteLine("\nTotal items: " + ht.Count);

        // 🔹 Contains (checks KEY)
        Console.WriteLine("\nContains key 2? " + ht.Contains(2));

        // 🔹 ContainsKey
        Console.WriteLine("ContainsKey 3? " + ht.ContainsKey(3));

        // 🔹 ContainsValue
        Console.WriteLine("ContainsValue 'Apple'? " + ht.ContainsValue("Apple"));

        // 🔹 Remove
        ht.Remove(2);

        Console.WriteLine("\nAfter Removing key 2:");
        foreach (DictionaryEntry item in ht)
        {
            Console.WriteLine(item.Key + " : " + item.Value);
        }

        Console.ReadKey();
    }
}