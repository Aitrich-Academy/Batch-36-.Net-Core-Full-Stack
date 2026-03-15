using Activity_6_Polymorphism;

internal class Program
{
    private static void Main(string[] args)
    {
        Calculator calc = new Calculator();

        Console.WriteLine("Sum of 2 integers: " + calc.Add(10, 20));
        Console.WriteLine("Sum of 3 integers: " + calc.Add(5, 10, 15));
        Console.WriteLine("Sum of 2 doubles: " + calc.Add(2.5, 3.5));

        //Q2
        Shape shape = new Shape();
        Shape s1 = new Circle();      // Base reference, Circle object
        Shape s2 = new Rectangle();   // Base reference, Rectangle object

        shape.Draw();
        s1.Draw();   // Calls Circle's Draw()
        s2.Draw();   // Calls Rectangle's Draw()

        //Q3
        Transport trans = new Transport();
        Transport bus = new Bus();
        Transport train = new Train();
        Transport flight = new Flight();

        trans.Fare();
        bus.Fare();
        train.Fare();
        flight.Fare();

        //Q4
        Notification notification = new Notification();
        Notification email = new EmailNotification();
        Notification sms = new SMSNotification();

        notification.Send();
        email.Send();
        sms.Send();


        //Q5
        //Notification n = new Notification();

        notification.Send("Alice");                         // Calls method 1
        notification.Send("Bob", "Meeting at 5 PM");       // Calls method 2
        notification.Send("Charlie", "Server down", 1);


        Console.ReadKey();
    }
}