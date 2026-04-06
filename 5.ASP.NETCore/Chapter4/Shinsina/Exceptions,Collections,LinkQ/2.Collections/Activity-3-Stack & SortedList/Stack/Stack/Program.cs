using System;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        // Create Stack
        Stack stack = new Stack();

        // 🔹 Push (Add elements)
        stack.Push("Apple");
        stack.Push("Banana");
        stack.Push("Mango");

        Console.WriteLine("After Push:");
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }

        // 🔹 Count
        Console.WriteLine("\nTotal items: " + stack.Count);

        // 🔹 Peek (Top element without removing)
        Console.WriteLine("\nTop element (Peek): " + stack.Peek());

        // 🔹 Contains
        Console.WriteLine("\nContains 'Apple'? " + stack.Contains("Apple"));

        // 🔹 Pop (Remove top element)
        Console.WriteLine("\nRemoved element: " + stack.Pop());

        Console.WriteLine("\nAfter Pop:");
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }

        Console.ReadKey();
    }
}