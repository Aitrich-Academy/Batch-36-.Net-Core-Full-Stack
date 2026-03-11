using Activity_4_Abstraction;

internal class Program
{
    private static void Main(string[] args)
    {
        //Q1
        Circle circle=new Circle(1);
        circle.CalculateArea();

        Rectangle rectangle = new Rectangle(10, 8);
        rectangle.CalculateArea();

        //Q2

        //Abstract method means only declaration of method,we cannot make an object of abstract
        //class we can only inherited


        //Q3
        Dog dog = new Dog();
        Cat cat = new Cat();

        dog.MakeSound();
        cat.MakeSound();

        //Q4
        PaymentProcessor credit = new CreditCardPayment(500);
        PaymentProcessor paypal = new PayPalPayment(300);

        credit.ProcessPayment();
        Console.WriteLine();
        paypal.ProcessPayment();

    }
}