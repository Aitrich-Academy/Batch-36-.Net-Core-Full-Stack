using System.Runtime.ConstrainedExecution;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("----------Activity 1: Customer Orders Filtering (E-commerce Domain)----------");
        List<Orders> orders = new List<Orders>()
        {
            new Orders { OrderId = 1, CustomerName = "John", TotalAmount = 250, OrderDate = new DateTime(2024, 3, 10) },
            new Orders { OrderId = 2, CustomerName = "Alice", TotalAmount = 150, OrderDate = new DateTime(2024, 3, 12) },
            new Orders { OrderId = 3, CustomerName = "John", TotalAmount = 300, OrderDate = new DateTime(2024, 3, 15) },
            new Orders { OrderId = 4, CustomerName = "Bob", TotalAmount = 200, OrderDate = new DateTime(2024, 3, 11) }
        };
        var displayOrders = orders.Where(e => e.CustomerName=="John").OrderByDescending(e=>e.OrderDate);

        foreach(var order in displayOrders)
        {
            Console.WriteLine($"OrderId: {order.OrderId}, Name: {order.CustomerName}, Date: {order.OrderDate.ToShortDateString()}");
        }



        Console.WriteLine("\n----------Activity 2: Filter Active Employees (HR System)----------");

        List<Employees> employees = new List<Employees>()
        {   new Employees { ID = 1, Name = "John", IsActive = true },
            new Employees { ID = 2, Name = "Alice", IsActive = false },
            new Employees { ID = 3, Name = "Bob", IsActive = true },
            new Employees { ID = 4, Name = "Emma", IsActive = false }
        };
        var displayActive = employees.Where(e => e.IsActive);
        Console.WriteLine("\nActive Employees");
        foreach (var employee in displayActive) 
        {
            
            Console.WriteLine($"ID :{employee.ID},Name : {employee.Name}"); 
        }


        Console.WriteLine("\nActivity 3: Top Performing Students (Education System)");
        List<Students> students = new List<Students>()
        {
            new Students { Name = "John", Department = "Computer Science", GPA = 3.8 },
            new Students { Name = "Alice", Department = "Mathematics", GPA = 3.5 },
            new Students { Name = "Bob", Department = "Computer Science", GPA = 3.9 },
            new Students { Name = "Emma", Department = "Computer Science", GPA = 3.6 },
            new Students { Name = "David", Department = "Physics", GPA = 3.7 }
        };
        var selectStudent = students.Where(e => e.Department == "Computer Science")
                                    .OrderByDescending(e=>e.GPA)
                                    .Select(s => s.Name);
        ;

        foreach (var student in selectStudent)
        {
            Console.WriteLine(student);
        }

        Console.WriteLine("\nActivity 4: Cars Filter by Brand and Price (Car Showroom)");
        // 1. Create a list of cars
        List<Car> cars = new List<Car>
        {
            new Car { Brand = "Toyota", Model = "Camry", Price = 25000 },
            new Car { Brand = "Honda", Model = "Civic", Price = 22000 },
            new Car { Brand = "Toyota", Model = "Corolla", Price = 20000 },
            new Car { Brand = "Ford", Model = "Focus", Price = 21000 },
            new Car { Brand = "Toyota", Model = "RAV4", Price = 30000 }
        };

        // 2 & 3: Filter Toyota cars and sort by Price (low to high)
        var result = cars
            .Where(c => c.Brand == "Toyota")
            .OrderBy(c => c.Price);

        // Display result
        foreach (var car in result)
        {
            Console.WriteLine($"{car.Brand} {car.Model} - {car.Price}");
        }

        Console.WriteLine("\nActivity 5: Product List with Select Projection (Inventory System)");
        List<Product> products = new List<Product>
        {
            new Product { ProductId = 1, Name = "Laptop", Quantity = 2, UnitPrice = 1500 },
            new Product { ProductId = 2, Name = "Mouse", Quantity = 5, UnitPrice = 20 },
            new Product { ProductId = 3, Name = "Keyboard", Quantity = 3, UnitPrice = 50 }
        };

        // 2. Project new list with Name and Total Value
        var result2 = products
            .Select(p => new
            {
                ProductName = p.Name,
                TotalValue = p.Quantity * p.UnitPrice
            });

        // Display result
        foreach (var item in result2)
        {
            Console.WriteLine($"{item.ProductName} - Total Value: {item.TotalValue}");
        }

        Console.WriteLine("\n�� Activity 6: Patient Appointments (Hospital Management)");
        List<Appointment> appointments = new List<Appointment>
        {
            new Appointment { PatientName = "John", AppointmentDate = new DateTime(2024, 3, 20), Doctor = "Dr. Smith" },
            new Appointment { PatientName = "Alice", AppointmentDate = new DateTime(2024, 3, 18), Doctor = "Dr. Brown" },
            new Appointment { PatientName = "Bob", AppointmentDate = new DateTime(2024, 3, 22), Doctor = "Dr. Smith" },
            new Appointment { PatientName = "Emma", AppointmentDate = new DateTime(2024, 3, 19), Doctor = "Dr. Smith" }
        };
        var result3 = appointments
           .Where(a => a.Doctor == "Dr. Smith")
           .OrderBy(a => a.AppointmentDate);

        // Display result
        foreach (var appt in result3)
        {
            Console.WriteLine($"{appt.PatientName} - {appt.Doctor} - {appt.AppointmentDate.ToShortDateString()}");
        }

        Console.WriteLine("\nActivity 7: Movies Released in a Year (Movie Library)");
        List<Movies> movies=new List<Movies>()
        {
             new Movies { Title = "Inception 2", Genre = "Sci-Fi", ReleaseYear = 2023 },
            new Movies { Title = "Avengers: New Era", Genre = "Action", ReleaseYear = 2023 },
            new Movies { Title = "The Last Journey", Genre = "Drama", ReleaseYear = 2022 },
            new Movies { Title = "Zodiac Return", Genre = "Thriller", ReleaseYear = 2023 },
            new Movies { Title = "Alpha", Genre = "Adventure", ReleaseYear = 2021 }
        };

        var getMovie = movies.Where(a => a.ReleaseYear==2023).OrderByDescending(a=>a.Title);
       foreach (var appt in getMovie)
        {
            Console.WriteLine(appt.Title);
        }
        Console.ReadKey();
    }
}