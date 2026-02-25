namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            Console.WriteLine(s.name);

            Employee n = new ("Arun",18);
      
            Console.WriteLine(n.name);

            Worker n2 = new Worker("sathya");
            Worker n3 = new Worker(n2);
            Console.WriteLine(n2.name);
            Console.WriteLine(n3.name);

          


            // employees joining
            Company emp1 = new Company("Arun");
            Company emp2 = new Company("Neha");
            Company emp3 = new Company("Rahul");

            Console.WriteLine();

            emp1.Display();
            emp2.Display();
            emp3.Display();

        }
    }
}
