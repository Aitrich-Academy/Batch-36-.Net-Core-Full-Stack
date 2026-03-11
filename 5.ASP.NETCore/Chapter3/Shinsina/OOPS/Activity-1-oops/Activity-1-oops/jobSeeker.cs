using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.WebRequestMethods;


namespace Activity_1_oops
{
    internal class jobSeeker
    {
        public int id;
        public string firstName;
        public string lastName;
        public jobSeeker(string a, string b)
        {
            firstName = a;
            lastName = b;
        }
        public void applyJob(int jobID)
        {
            Console.WriteLine("Apply Job Started...");
            Console.WriteLine(firstName + " " + lastName);

        }

    }

    internal class Books
    {
        public int Id;
        public string BookName;
        public string Author;

        // Constructor
        public Books(string bn, string a)
        {
            //this.Id = id;
            BookName = bn;
            Author = a;
        }
        // Method
        public void DisplayBook(int id)
        {
            Console.WriteLine("\n\n-----Book Details...------");
            Console.WriteLine("Book ID: " + id);
            Console.WriteLine("Title: " + BookName);
            Console.WriteLine("Author: " + Author);
        }
    }

    internal class Car
    {
        public int Id;
        public string Name;
        public string Model;

        // Constructor
        public Car(int id, string name, string model)
        {
            Id = id;
            Name = name;
            Model = model;
        }

        //public void DisplayCar()
        //{
        //    Console.WriteLine("ID: " + Id);
        //    Console.WriteLine("Name: " + Name);
        //    Console.WriteLine("Model: " + Model);
        //    Console.WriteLine("------------------------------------------"); // separator
        //}

        // Display car as table row
        public void DisplayCar()
        {
            Console.WriteLine("{0,-10} {1,-15} {2,-15}", Id, Name, Model);
        }

        // Static method to print header
        public static void DisplayHeader()
        {
            Console.WriteLine("\n--------------- Car Details ------------------");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("{0,-10} {1,-15} {2,-15}", "Car Id", "Car Name", "Model");

            Console.WriteLine("------------------------------------------------");
        }

        // Static method for bottom line
        public static void DisplayLine()
        {
            Console.WriteLine("------------------------------------------------");
        }
    }




}
