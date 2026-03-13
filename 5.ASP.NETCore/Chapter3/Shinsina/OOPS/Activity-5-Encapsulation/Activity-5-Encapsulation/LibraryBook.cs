using System;
using System.Collections.Generic;
using System.Text;

namespace Activity_5_Encapsulation
{
    internal class LibraryBook
    {
        // Auto-properties
        public string Title { get; set; }
        public string Author { get; set; }

        // Read-only outside the class (private set)
        public bool IsBorrowed { get; private set; }

        // Constructor
        public LibraryBook(string title, string author)
        {
            Title = title;
            Author = author;
            IsBorrowed = false;  // Initially not borrowed
        }

        // Method to borrow book
        public void BorrowBook()
        {
            if (!IsBorrowed)
            {
                IsBorrowed = true;
                Console.WriteLine("Book borrowed successfully.");
            }
            else
            {
                Console.WriteLine("Book is already borrowed.");
            }
        }

        // Method to return book
        public void ReturnBook()
        {
            if (IsBorrowed)
            {
                IsBorrowed = false;
                Console.WriteLine("Book returned successfully.");
            }
            else
            {
                Console.WriteLine("Book was not borrowed.");
            }
        }

        // Display method
        public void Display()
        {
            Console.WriteLine("\nTitle: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Borrowed: " + IsBorrowed);
        }
    }
}
