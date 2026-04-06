using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create Collection
        List<string> fruits = new List<string>();

        // 1. Adding items
        fruits.Add("Apple");
        fruits.Add("Banana");
        fruits.Add("Mango");

        Console.WriteLine("After Adding Items:");
        Display(fruits);

        // 2. Inserting item
        fruits.Insert(1, "Orange");

        Console.WriteLine("\nAfter Inserting Orange at index 1:");
        Display(fruits);

        // 3. Removing items
        fruits.Remove("Banana");   // remove by value
        fruits.RemoveAt(1);        // remove by index

        Console.WriteLine("\nAfter Removing Items:");
        Display(fruits);

        // 4. Finding / Searching
        bool found = fruits.Contains("Apple");
        int index = fruits.IndexOf("Mango");

        Console.WriteLine("\nSearching:");
        Console.WriteLine("Contains Apple: " + found);
        Console.WriteLine("Index of Mango: " + index);

        // 5. Sorting
        fruits.Add("Pineapple");
        fruits.Add("Grapes");
        fruits.Sort();

        Console.WriteLine("\nAfter Sorting:");
        Display(fruits);

        // 6. Replacing item
        fruits[0] = "Strawberry";

        Console.WriteLine("\nAfter Replacing First Item:");
        Display(fruits);

        // 7. Copy collection
        List<string> copyFruits = new List<string>(fruits);

        Console.WriteLine("\nCopied Collection:");
        Display(copyFruits);

        // 8. Capacity and Count
        Console.WriteLine("\nCollection Details:");
        Console.WriteLine("Count: " + fruits.Count);
        Console.WriteLine("Capacity: " + fruits.Capacity);
    }

    static void Display(List<string> list)
    {
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}