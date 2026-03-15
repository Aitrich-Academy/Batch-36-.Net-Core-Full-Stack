using Activity1;

internal class Program
{
    private static void Main(string[] args)
    {
        Student student = new Student();
        student.displayValues();
        Console.ReadLine();

        Car car = new Car("Toyota", "Corola");
        car.carInfo();
        Console.ReadLine();

        Employee employee = new Employee("Deepa");
        Employee employee1 = new Employee("Arun");
        Employee employee2 = new Employee("Ulkarsha");
        employee.infoEmployee();
        employee1.infoEmployee();
        employee2.infoEmployee();
        Console.ReadLine();

        Logger.LogMessage("1st Message");
        Logger.LogMessage("2nd Message");
        Logger.LogMessage("3rd Message");
        Console.ReadLine();

        Book book1 = new Book("The Alchemist", "Paulo Coulo");
        Book book2 = new Book(book1);
        Console.WriteLine("Book 1 Details:");
        book1.displayBook();
        Console.WriteLine("\nBook 2 Details (Copied):");
        book2.displayBook();
        Console.ReadLine();


    }
}