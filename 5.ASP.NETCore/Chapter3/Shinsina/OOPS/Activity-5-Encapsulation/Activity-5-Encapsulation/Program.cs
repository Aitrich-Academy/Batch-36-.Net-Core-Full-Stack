using Activity_5_Encapsulation;

internal class Program
{
    private static void Main(string[] args)
    {
        //Q1
        Student student = new Student();

        student.Name = "Anu";
        student.Age = 20;

        Console.WriteLine("Student Name: " + student.Name);
        Console.WriteLine("Student Age: " + student.Age);

        // Trying to set negative age
        student.Age = -5;   // This will not change the age

        Console.WriteLine("Updated Age: " + student.Age);


        //Q2
        Car myCar = new Car();
        myCar.Accelerate(50);
        myCar.Brake(20);
        myCar.Brake(40);   // Speed will not go below 0

        myCar.DisplaySpeed();

        //Q3
        Product p1 = new Product();

        p1.Price = 1000;      // Setting price
        Console.WriteLine("\nOriginal Price: " + p1.Price);

        p1.ApplyDiscount(10); // 10% discount

        p1.Price = -500;      // Invalid price (not allowed)


        //Q4
        BankAccount account = new BankAccount(1000);

        Console.WriteLine("\nInitial Balance: " + account.Balance);

        account.Deposit(500);
        Console.WriteLine("Balance After Deposit: " + account.Balance);

        account.Withdraw(1200);   // Prevent overdraft
        account.Withdraw(800);

        Console.WriteLine("Final Balance: " + account.Balance);

        //Q5
        LibraryBook book = new LibraryBook("C# Basics", "John Smith");

        book.Display();

        book.BorrowBook();
        book.BorrowBook();   // Already borrowed

        book.ReturnBook();

        book.Display();
    }
}