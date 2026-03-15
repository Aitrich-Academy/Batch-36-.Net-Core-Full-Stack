using Polymorphism;

internal class Program
{
    private static void Main(string[] args)
    {
        Calculator cal=new Calculator();

        Console.WriteLine("Add(int,int)=> 10+20= " +cal.Add(10, 20));
        Console.WriteLine("Add(int,int,int)=> 10+20+30= "+cal.Add(10, 20, 30));
        Console.WriteLine("Add(double,double)=> 25.50+30.25= " + cal.Add(25.50, 30.25));
        Console.ReadLine();

        Shape shape1 = new Circle();
        Shape shape2 = new Rectangle();
        shape1.Draw();
        shape2.Draw();
        Console.ReadLine() ;


        

    }
}