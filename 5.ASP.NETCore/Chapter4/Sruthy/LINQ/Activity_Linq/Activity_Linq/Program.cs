using Activity_Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        List<int> numbers = new List<int>() { 10, 5, 8, 20, 3, 15 };

        // Even numbers 
        var evenFirst = numbers
                        .Where(n => n %2==0);       // filter even numbers

        Console.WriteLine("\nEven Numbers in the list are:");
        foreach (var n in evenFirst)
            Console.WriteLine(n);
        Console.ReadLine();


        //student name
        List<Student> students = new List<Student>()
        {
            new Student { Id = 1, Name = "Anu", Marks = 85 ,Department="Computer Science", GPA=7.8},
            new Student { Id = 2, Name = "Rahul", Marks = 70, Department="Computer Science", GPA=8.3 },
            new Student { Id = 3, Name = "Meera", Marks = 90, Department="Mechanical", GPA=6.8 },
            new Student { Id = 4, Name = "Jyothi", Marks = 90, Department="Computer Science", GPA=9.0 },
            new Student { Id = 5, Name = "Govind", Marks = 90, Department="Mechanical", GPA=6.4 },
            new Student { Id = 6, Name = "Hayan", Marks = 90, Department="Computer Science", GPA=7.4 }
        };
        var studentNames = students.Select(s => s.Name);

        Console.WriteLine("Student Names:");
        foreach (var name in studentNames)
        {
            Console.WriteLine(name);
        }
        Console.ReadLine() ;


        //Product
        List<Product> products = new List<Product>()
        {
            new Product { Id = 1, Name="Book",price=50.25m },
            new Product { Id = 1, Name="Pen",price=20.50m },
            new Product { Id = 1, Name="Pencil",price=10.25m },
            new Product { Id = 1, Name="Eraser",price=5.75m }
        };
        var sortedProduct = products
                            .OrderBy(p => p.price);
        Console.WriteLine("Products Sorted by price:");
        Console.WriteLine("\n\n-----Product List------\n\nProduct\t\tPrice");
        foreach (var p in sortedProduct)
        {
            Console.WriteLine(p.Name + " \t \t" + p.price);
        }
        Console.ReadLine();

        //Employee
        List<Employee> employees = new List<Employee>()
        {
            new Employee {Id=1, Name = "Jeeva", IsActive=true, Salary = 30000 },
            new Employee {Id=2, Name = "Shini", IsActive=true, Salary = 55000 },
            new Employee {Id=3, Name = "Rohan", IsActive=false, Salary = 40000 },
            new Employee {Id=4, Name = "Michel", IsActive=true, Salary = 65000 }
        };
        var employeeList = employees
                        .Where(n => n.Salary > 50000)
                        .OrderBy(p => p.Name);
        Console.WriteLine("\n\nThe Employees who has salary greater than 50000:\n");
        Console.WriteLine("-------Employee List--------\n\nName\t\tSalary");
        foreach(var e in employeeList)
        {
            Console.WriteLine(e.Name+"\t\t"+e.Salary);
        }
        Console.ReadLine ();

        //students
        var result = students
                    .Where(s => s.Marks > 80)   
                    .Select(s =>new { s.Name, s.Marks });       

        Console.WriteLine("\n\nStudents with Score > 80:");
        Console.WriteLine("\n\n--------Student List------\n\nStudent\t\tScore");

        foreach (var s in result)
        {
            Console.WriteLine(s.Name + "\t\t" + s.Marks);
        }
        Console.ReadLine();


        //Order
        List<Order> orders = new List<Order>()
        {
            new Order{OrderId=1,CustomerName="Rachel",TotalAmount=23000m,OrderDate=DateTime.Now.AddDays(-1)},
            new Order{OrderId=2,CustomerName="Vinay",TotalAmount=41000m,OrderDate=DateTime.Now.AddDays(-4)},
            new Order{OrderId=3,CustomerName="John",TotalAmount=33000m,OrderDate=DateTime.Now.AddDays(-9)},
            new Order{OrderId=4,CustomerName="Deepu",TotalAmount=20300m,OrderDate=DateTime.Now.AddDays(-5)},
            new Order{OrderId=3,CustomerName="John",TotalAmount=15000m,OrderDate=DateTime.Now.AddDays(-2)},
            new Order{OrderId=5,CustomerName="Guptan",TotalAmount=50200m,OrderDate=DateTime.Now.AddDays(-6)}
        };
        var orderList = orders
                        .Where(o => o.CustomerName == "John")
                        .OrderByDescending(o=>o.OrderDate);
        Console.WriteLine("\n\nOrders by John (Latest First)\n");
        Console.WriteLine("\n\n--------------Order List----------------\n\nName\t\tAmount\t\tDate");
        foreach(var o in orderList)
        {
            Console.WriteLine(o.CustomerName+"\t\t"+o.TotalAmount+"\t\t"+o.OrderDate);
        }
        Console.ReadLine();

        //
        var employeeList1 = employees
            .Where(e => e.IsActive == true);
        Console.WriteLine("\nActive Employee's List:");
        foreach (var e in employeeList1)
        {
            Console.WriteLine(e.Name);
        }
        Console.ReadLine();



        //Student

        var studentList = students
                            .Where(s=>s.Department=="Computer Science")
                            .OrderByDescending(s=>s.GPA)
                            .Select(s => new { s.Name, s.GPA });

        Console.WriteLine("\n\nStudent in Computer Science in Descending order by GPA:\n");
        Console.WriteLine("--------Student List-----------\nName\t\tGPA\n");
        foreach (var s in studentList)
        {
            Console.WriteLine(s.Name+"\t\t"+s.GPA);
        }
        Console.WriteLine();
        Console.ReadLine();



        //car
        List<Car> list = new List<Car>()
        {
            new Car{Brand="Toyoto",Model="Camery", Price=1400000},
            new Car{Brand="Mitumushi",Model="Pajero", Price=2500000},
            new Car{Brand="Nissan",Model="PathFinder", Price=3000000},
            new Car{Brand="Toyoto",Model="Land Cruiser", Price=3400000},
            new Car{Brand="Toyoto",Model="Rush", Price=850000},
            new Car{Brand="Nissan",Model="Sunny", Price=1400000}
        };


    }
}