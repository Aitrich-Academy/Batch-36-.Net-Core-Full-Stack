using System;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        // Create Queue
        Queue queue = new Queue();

        // 🔹 Enqueue (Add elements)
        queue.Enqueue("Apple");
        queue.Enqueue("Banana");
        queue.Enqueue("Mango");

        Console.WriteLine("After Enqueue:");
        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }

        // 🔹 Count
        Console.WriteLine("\nTotal items: " + queue.Count);

        // 🔹 Peek (see first element without removing)
        Console.WriteLine("\nPeek element: " + queue.Peek());

        // 🔹 Dequeue (remove first element)
        Console.WriteLine("\nRemoved element: " + queue.Dequeue());

        Console.WriteLine("\nAfter Dequeue:");
        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }

        Console.ReadKey();
    }
}
