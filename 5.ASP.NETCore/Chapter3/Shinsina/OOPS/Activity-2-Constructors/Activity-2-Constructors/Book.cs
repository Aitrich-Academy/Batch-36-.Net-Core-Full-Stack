using System;
using System.Collections.Generic;
using System.Text;

namespace Activity_2_Constructors
{
    internal class Book
    {
        public string Title;
        public string Author;

        public Book(string title, string author)
        {
            this.Title = title;
            this.Author = author;
        }
        public Book(Book book2)
        {
            this.Title= book2.Title;
            this.Author= book2.Author;
        }
        public void Displaytitle()
        {
            Console.WriteLine("\n------ Q5 ------");
        }
        public void DisplayBook()
        {
           
            Console.WriteLine("Title: "+ Title);
            Console.WriteLine("Author: "+ Author);
        }
    }
}
