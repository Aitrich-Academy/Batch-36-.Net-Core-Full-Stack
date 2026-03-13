using Activity_2_Constructors;

internal class Program
{
    private static void Main(string[] args)
    {
        //Q1 class-Student
        Student obj = new Student("Shinsina", 31);
        obj.Display();


        //Q2 class-Car
        Car objCar = new Car("BMW","X20");
        objCar.DisplayCars();

        //Q3 Class-Employee
        Employee employee = new Employee("Aravind");
        Employee employee1 = new Employee("Kiran");
        Employee employee2 = new Employee("Yahya");

        employee.DisplayHead();

        employee.DisplayEmployee();
        employee1.DisplayEmployee();
        employee2.DisplayEmployee();


        //Q3 class-Logger
        Logger.LogMessage("Application Started");
        Logger.LogMessage("User Logged In");
        Logger.LogMessage("Data Saved");


        //Q5 Class-Book
        Book Book1 = new Book("The Alchemist", "Paulo Coelho");

        Book objBook2 = new Book(Book1);
        Book1.Displaytitle();

        Console.WriteLine("\nBook 1 Details:");
        Book1.DisplayBook();
        

        Console.WriteLine("\nBook 2 Details (Copied from Book 1):");
        objBook2.DisplayBook();

        Console.ReadKey();



    }
}