using Activity_2;

internal class Program
{
   
    private static void Main(string[] args)
    {
        Manager manager = new Manager("Salaah",20,2500,"IT Engeneer");

        //manager.Name= "Salaah";
        //manager.Age = 20;
        //manager.Salary = 2500;
        //manager.Department = "IT Engeneer";

        manager.DisplayName();
        manager.DisplaySalary();
        manager.DisplayDepartment();




        // Array for multiple managers
        Manager[] managers = new Manager[2];

        for (int i = 0; i < managers.Length; i++)
        {
            Console.WriteLine($"\nEnter details of Manager {i + 1}");

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Department: ");
            string department = Console.ReadLine();

            // ✅ Object created using constructor
            managers[i] = new Manager(name, age, salary, department);
        }

        Console.WriteLine("\n----- Manager Details -----");

        foreach (Manager m in managers)
        {
            Console.WriteLine("\n----------------------");
            m.DisplayName();
            m.DisplaySalary();
            m.DisplayDepartment();
        }
    }
}