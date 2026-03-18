using System;
using System.Collections.Generic;
using System.Text;

namespace Activity1
{
    internal class Book
    {
        public string title;
        public string author;

        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;

        }
        public Book(Book b)  //copy constructor
        {
            title = b.title;
            author = b.author;
        }

        public void displayBook()
        {
            Console.WriteLine("Book Details\n--------------------------------\nTitle: " + title + "\nAuthor: " + author);

        }
    }
}
