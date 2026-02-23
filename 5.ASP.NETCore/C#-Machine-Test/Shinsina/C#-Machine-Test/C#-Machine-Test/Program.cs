using System.Xml.Linq;

internal class Program

{ 
    struct Employee
    {
        public int EmployeeID;
        public string Name;
        public double Salary;
    }
    private static void Main(string[] args)
    {
        Employee[] employees =  new Employee[5];
        Console.WriteLine("-----------------------------------------Employee Records---------------------------------------------------------");
        for (int i = 0; i < employees.Length; i++)
        {
           
            Console.WriteLine("Enter Employee ID: ");
            employees[i].EmployeeID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name: ");
            employees[i].Name = Console.ReadLine();

            Console.WriteLine("Enter Salary: ");
            employees[i].Salary= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("------------------------------------------Successfully Completed------------------------------------------------");
        }

        double highestSalary = employees[0].Salary;
        double lowestSalary= employees[0].Salary;
        string highestSalaryName = employees[0].Name;
        string lowestSalaryName = employees[0].Name;
        for (int i = 0; i < employees.Length; i++)
        {
            if (employees[i].Salary > highestSalary)
            {
                highestSalaryName= employees[i].Name;
                highestSalary=employees[i].Salary;
            }
            if (employees[i].Salary < lowestSalary)
            {
                lowestSalaryName = employees[i].Name;
                lowestSalary =employees[i].Salary;
            }
        }


        Console.WriteLine("\n-------------------------------------------EMPLOYEE DETAILS---------------------------------------------------------");
        foreach (Employee employee in employees)
        { 
            Console.WriteLine($"\nEmployeeID: {employee.EmployeeID}                 | Employee Name:{employee.Name}                    |Salary:{employee.Salary}");

        }
        Console.WriteLine($"\nHighest Salary: {highestSalary}                |Name:   {highestSalaryName} ");
        Console.WriteLine($"\nLowest Salary:{lowestSalary}                 | Name:   { lowestSalaryName}");
    }
}