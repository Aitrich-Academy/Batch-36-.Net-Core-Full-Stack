internal class Program
{
    public struct Employee
    {
        public int EmployeeID;
        public string Name;
        public double salary;
    }
    private static void Main(string[] args)
    {
        Employee[] employees = new Employee[5];
        for (int i = 0; i < employees.Length; i++)
        {
            Console.WriteLine($"\n\nEnter the Detail of Employee {i + 1}: \n");
            Console.Write("Employee ID: ");
            employees[i].EmployeeID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Employee Name: ");
            employees[i].Name = Console.ReadLine();
            Console.Write("Salary: ");
            employees[i].salary = Convert.ToDouble(Console.ReadLine());
        }
        Employee high = employees[0];
        Employee low = employees[0];
        Console.WriteLine("\n\n-----------------------Employee Detalis-------------------------------");
        for (int i = 0; i < employees.Length; i++)
        {
            Console.WriteLine("\nEmployee ID: " + employees[i].EmployeeID);
            Console.WriteLine("Name: " + employees[i].Name);
            Console.WriteLine("Salary: " + employees[i].salary);
            Console.WriteLine("\n---------------------------------------------------------------------");


            if (employees[i].salary > high.salary ){
                high = employees[i];
            }

            if (employees[i].salary < low.salary)
            {
                low = employees[i];
            }

        }
        Console.WriteLine("\n----------------Highest Salary Employee Details------------------- \n");
        Console.WriteLine("EmployeeID: "+high.EmployeeID);
        Console.WriteLine("Employee Name: " + high.Name);
        Console.WriteLine("Salary: " + high.salary);
        Console.WriteLine("---------------------------------------------------------------------\n");

        Console.WriteLine("\n----------------Lowest Salary Employee Details------------------- \n");
        Console.WriteLine("EmployeeID: " + low.EmployeeID);
        Console.WriteLine("Employee Name: " + low.Name);
        Console.WriteLine("Salary: " + low.salary);
        Console.WriteLine("---------------------------------------------------------------------\n");

        Console.ReadLine();

    }
}