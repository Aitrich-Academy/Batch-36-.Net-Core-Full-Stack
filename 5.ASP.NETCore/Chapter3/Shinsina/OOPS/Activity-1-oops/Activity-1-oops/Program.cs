using Activity_1_oops; 
internal class Program
    
{
    private static void Main(string[] args)
    {
        jobSeeker obj = new jobSeeker("Shinsina", "Sefeer");//new object of the jobseeker class
        //obj.firstName = "Shinsina";
        //obj.lastName = "Sefeer";
        obj.applyJob(1);


        Books book = new Books("The Alchemist", "Paulo Coelho");
        book.DisplayBook(102);

        Car[] cars = new Car[]
       {
            new Car(1, "Toyota", "Corolla"),
            new Car(2, "Honda", "Civic"),
            new Car(3, "BMW", "X5")
       };

        Car.DisplayHeader();

        foreach (Car car in cars)
        {

            car.DisplayCar();
        }

        Car.DisplayLine();
    }



}
