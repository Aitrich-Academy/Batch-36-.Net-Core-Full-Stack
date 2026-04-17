internal class Program
{
    private static void Main(string[] args)
    {
        //1
        Console.WriteLine("1.DivideByZeroException");
        try
        {
            //Console.WriteLine("enter any two number");
            //int a, b;
            int a = 10;
            int b = 0;
            int c = a/b;
            Console.WriteLine(c);
            //a = Convert.ToInt32(Console.ReadLine());
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("output is : {0}", a / b);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Example of DivideByZeroException");
        }
      

        //Console.WriteLine("enter any number");
        //int a, b;
        //a = Convert.ToInt32(Console.ReadLine());
        //b = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("output is : {0}", a / b);
        //Console.ReadKey();

        //2
        Console.WriteLine("\n2.NullReferenceException");

        try
        {
           
            string name = null;
            Console.WriteLine(name.Length);
        }
        catch(NullReferenceException ex)
        {
            Console.WriteLine(ex.Message)   ;
            Console.WriteLine("Example of NullReferenceException");
        }


        //3
        Console.WriteLine("\n3.FormatException");
        try
        {
            int NUMBER = Convert.ToInt32("hello");
        }
        catch (Exception ex) 
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Example of FormatException");
        }


        //4
        Console.WriteLine("\n4.IndexOutOfRangeException");
        try
        {
            int[] array= { 1, 2, 3 };
            Console.WriteLine(array[5]);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Example of IndexOutOfRangeException");
        }


        //5
        Console.WriteLine("\n5.OverflowException");

        try
        {
            int num = int.MaxValue;
            num = checked(num + 1);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Exapmle of  OverFlowException");
        }


        //6
        Console.WriteLine("\n6.FileNotFoundException");
        try
        {
            string text = File.ReadAllText("test.txt");
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Example of FileNotFoundException");
        }

        //7
        Console.WriteLine("\n7.InvalidCastException");
        try
        {
            object obj = "Hello";
            int num = (int)obj;
        }
        catch (InvalidCastException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Example of InvalidCastException");
        }

        //8
        Console.WriteLine("\n8.ArgumentException");
        static void CheckAge(int age)
        {
            if (age < 0)
                throw new ArgumentException("Age cannot be negative");
        }
        try
        {
            CheckAge(-5);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Example of ArgumentException");
        }

        //9
        Console.WriteLine("\n9.Finally Block Example");

        
            try
            {
                int x = 10 ;
                int y = 0 ;
                int z = x / y;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Error occurred");
            }
            finally
            {
                Console.WriteLine("Finally block executed");
            }
        
        Console.ReadKey();
    }
}