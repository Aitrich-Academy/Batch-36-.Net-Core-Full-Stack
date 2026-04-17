internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Q1");
        Console.WriteLine("\nthe given numbers :");
        List<int> Numbers=new List<int>()
        {
            1,2,3,4,5,6,7,8,9
        };
        foreach (int i in Numbers)
        {
            Console.WriteLine($"{i}");
        }

        // Use LINQ Where to filter even numbers
        var evenNumbers = Numbers.Where(n => n % 2 == 0);

        Console.WriteLine("\n filted even numbers");
        //to display
        foreach (int n in evenNumbers)
        {
            Console.WriteLine(n);
        }


        Console.WriteLine("\nQ2");
        Console.WriteLine("total Students :");
        List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Alice", Age = 20 },
            new Student { Id = 2, Name = "Bob", Age = 22 },
            new Student { Id = 3, Name = "Charlie", Age = 21 }
        }
        ;

        var studentname = students.Select(s => s.Name);
        Console.WriteLine("Student Names:");
        foreach (var name in studentname)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine("\nQ3");

        List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 1200 },
            new Product { Id = 2, Name = "Mouse", Price = 25 },
            new Product { Id = 3, Name = "Keyboard", Price = 75 }
        };

        // Sort products by Price (ascending)
        var sortedProducts = products.OrderBy(p => p.Price);

        // Display result
        Console.WriteLine("Products sorted by price:");
        foreach (var product in sortedProducts)
        {
            Console.WriteLine($"{product.Name} - {product.Price}");
        }


        Console.WriteLine("Q4");
        List<Employees> employees = new List<Employees>
        {
            new Employees { Id = 1, Name = "John", Salary = 60000 },
            new Employees { Id = 2, Name = "Alice", Salary = 45000 },
            new Employees { Id = 3, Name = "Bob", Salary = 70000 },
            new Employees { Id = 4, Name = "David", Salary = 55000 }
        };
        var displayEmployee = employees.Where(e => e.Salary > 5000).OrderBy(e=>e.Name) .Select(e => e.Name);
        foreach (var employee in displayEmployee)
        {
            Console.WriteLine(employee);
        }

        // Create list of students
        List<Student> students1 = new List<Student>
        {
            new Student { Id = 1, Name = "Alice", Score = 85 },
            new Student { Id = 2, Name = "Bob", Score = 72 },
            new Student { Id = 3, Name = "Charlie", Score = 90 },
            new Student { Id = 4, Name = "David", Score = 78 }
        };

        // LINQ query
        var result = students1
                        .Where(s => s.Score > 80)  // filter
                        .Select(s => s.Name);     // project names

        // Display result
        Console.WriteLine("Students with score > 80:");
        foreach (var name in result)
        {
            Console.WriteLine(name);
        }

    }
}