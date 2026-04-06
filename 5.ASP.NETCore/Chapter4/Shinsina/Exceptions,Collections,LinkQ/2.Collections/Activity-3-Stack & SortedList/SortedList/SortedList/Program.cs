using System;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        // Create SortedList
        SortedList sl = new SortedList();

        // 🔹 Add (Key, Value)
        sl.Add(3, "Mango");
        sl.Add(1, "Apple");
        sl.Add(2, "Banana");

        Console.WriteLine("After Adding (Sorted by Key):");
        foreach (DictionaryEntry item in sl)
        {
            Console.WriteLine(item.Key + " : " + item.Value);
        }

        // 🔹 Count
        Console.WriteLine("\nTotal items: " + sl.Count);

        // 🔹 ContainsKey
        Console.WriteLine("\nContainsKey 2? " + sl.ContainsKey(2));

        // 🔹 IndexOfKey
        Console.WriteLine("Index of Key 2: " + sl.IndexOfKey(2));

        // 🔹 IndexOfValue
        Console.WriteLine("Index of Value 'Apple': " + sl.IndexOfValue("Apple"));

        // 🔹 Remove
        sl.Remove(2);

        Console.WriteLine("\nAfter Removing key 2:");
        foreach (DictionaryEntry item in sl)
        {
            Console.WriteLine(item.Key + " : " + item.Value);
        }

        Console.ReadKey();
    }
}