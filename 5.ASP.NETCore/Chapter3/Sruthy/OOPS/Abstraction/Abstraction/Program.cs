using Abstraction;

internal class Program
{
    private static void Main(string[] args)
    {
        //JobSeeker seeker = new JobSeeker();
        // seeker.email = "abc@gmail.com";
        // seeker.userName = "abc";
        // seeker.displayInfo();

        Shape circle = new Circle(5);
        Shape rectangle = new Rectangle(4, 6);

        Console.WriteLine($"Area of Circle: { circle.CalculateArea() }");
        Console.WriteLine($"Area of Rectangle: { rectangle.CalculateArea() }");
        Console.ReadLine();

        Console.WriteLine("Here Shape is an abstract class so we cannot directly create the instance of it !!!!!");
        //Shape s=new Shape();
        Console.ReadLine();

        Animal dog = new Dog();
        Animal cat = new Cat();
        dog.MakeSound();
        cat.MakeSound();
        Console.ReadLine() ;






    }
}