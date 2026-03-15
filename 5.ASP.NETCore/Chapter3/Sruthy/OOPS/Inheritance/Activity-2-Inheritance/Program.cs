using Activity_2_Inheritance;

internal class Program
{
    private static void Main(string[] args)
    { // Create object of Dog
        Dog myDog = new Dog("Dora");
        

        // Call methods
        myDog.Eat();   // Method inherited from Animal
        myDog.Bark();  // Method of Dog
    }
}