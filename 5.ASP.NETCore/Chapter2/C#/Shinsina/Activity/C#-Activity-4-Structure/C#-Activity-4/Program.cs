internal class Program
{


//#Q1
    struct Book
    {
        public string Title;
        public string Author;
        public double Price;
    }

//#Q2
    struct Rectangle
    {
        public double length;
        public double width;

        public double GetArea()
        {
            return length * width;
        }
    }

//#Q3
struct Employee
    {
        public int ID;
        public string Name;
        public double Salary;

        public Employee(int id, string name, double salary)
        {
            ID = id;
            Name = name;
            Salary = salary;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {ID} | Name: {Name} | Salary: ${Salary:N2}");
        }
    }

    //#Q4
    struct Student
    {
        public int RollNumber;
        public string Name;
        public double Marks;
    }

    //#Q5
    struct Company
    {
        public string CompanyName;
        public Department Dept; // Field of the nested type

        // Nested Struct
        public struct Department
        {
            public string DeptName;
            public string Manager;
        }
    }
    private static void Main(string[] args)
    {

        //#Q1
        Console.WriteLine("#Q1");
        Book[] library = new Book[3];
        for (int i = 0; i < library.Length; i++)
        {
            Console.WriteLine($"--- Enter Details for Book {i + 1} ---");

            Console.Write("Title: ");
            library[i].Title = Console.ReadLine() ?? "";

            Console.Write("Author: ");
            library[i].Author = Console.ReadLine() ?? "";

            Console.Write("Price: ");
            // Using Convert.ToDouble as an alternative method
            library[i].Price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
        }
        Console.WriteLine("======= Library Inventory =======");
        foreach (Book myBook in library)
        {
            Console.WriteLine($"Book: {myBook.Title}");
            Console.WriteLine($"By:   {myBook.Author}");
            Console.WriteLine($"Price: ${myBook.Price:F2}"); // :F2 formats to 2 decimal places
           
        }


        //#Q2
        Console.WriteLine("\n#Q2");

             Rectangle myRectangle=new  Rectangle ();

        Console.Write("Enter the Length of the rectangle: ");
        string inputL = Console.ReadLine() ?? "0";
        myRectangle.length = Convert.ToDouble(inputL);

        Console.Write("Enter the width of the rectangle: ");
        string inputW=Console.ReadLine() ?? "0";
        myRectangle.width = Convert.ToDouble(inputW);

        double result = myRectangle.GetArea();

        Console.WriteLine("\n--- Rectangle Details ---");
        Console.WriteLine($"Length: {myRectangle.length}");
        Console.WriteLine($"Width:  {myRectangle.width}");
        Console.WriteLine($"Total Area: {result}");

        //#Q3
        Console.WriteLine("\n#Q3");

        // 1. Create an array of 3 employees
        Employee[] staff = new Employee[3];

        // 2. Accept user input to populate the array
        for (int i = 0; i < staff.Length; i++)
        {
            Console.WriteLine($"\n--- Enter Details for Employee {i + 1} ---");

            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter Name: ");
            string name = Console.ReadLine() ?? "Unknown";

            Console.Write("Enter Salary: ");
            double salary = Convert.ToDouble(Console.ReadLine() ?? "0");

            // Use the Constructor to create the object
            staff[i] = new Employee(id, name, salary);
        }

        // 3. Display all employee information
        Console.WriteLine("\n======= Employee Records =======");
        foreach (Employee emp in staff)
        {
            emp.DisplayInfo();
        }


        //#Q4
        Student[] classroom = new Student[5];

        // 2. Accept user input
        for (int k = 0; k < classroom.Length; k++)
        {
            Console.WriteLine($"\n--- Details for Student {k + 1} ---");

            Console.Write("Roll Number: ");
            classroom[k].RollNumber = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Name: ");
            classroom[k].Name = Console.ReadLine() ?? "N/A";

            Console.Write("Marks: ");
            classroom[k].Marks = Convert.ToDouble(Console.ReadLine() ?? "0");
        }

        // 3. Sort Students by Marks (Descending Order)
        // Using Bubble Sort logic
        int n = classroom.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                // Compare Marks of adjacent students
                if (classroom[j].Marks < classroom[j + 1].Marks)
                {
                    // Swap the entire student objects
                    Student temp = classroom[j];
                    classroom[j] = classroom[j + 1];
                    classroom[j + 1] = temp;
                }
            }
        }

        // 4. Display the Sorted List
        Console.WriteLine("\n======= Students Ranked by Marks (High to Low) =======");
        foreach (Student s in classroom)
        {
            Console.WriteLine($"Roll: {s.RollNumber} | Name: {s.Name} | Marks: {s.Marks}");
        }


        //#Q5
        // 1. Create an instance of the outer struct
        Company myFirm = new Company();

        // 2. Accept Company details
        Console.Write("Enter Company Name: ");
        myFirm.CompanyName = Console.ReadLine() ?? "Unknown Corp";

        // 3. Accept Department details (accessing through the outer struct)
        Console.Write("Enter Department Name: ");
        myFirm.Dept.DeptName = Console.ReadLine() ?? "General";

        Console.Write("Enter Department Manager: ");
        myFirm.Dept.Manager = Console.ReadLine() ?? "N/A";

        // 4. Display the nested information
        Console.WriteLine("\n======= Business Overview =======");
        Console.WriteLine($"Company:    {myFirm.CompanyName}");
        Console.WriteLine($"Department: {myFirm.Dept.DeptName}");
        Console.WriteLine($"Manager:    {myFirm.Dept.Manager}");
    }
}