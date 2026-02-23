using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        //#Q1
        Console.WriteLine("#Q1");
        int num = 1;
        double number2 = 12.54;
        string name = "salaah";
        Console.WriteLine("value of int: " + num);
        Console.WriteLine("value of double: " + number2);
        Console.WriteLine("string value: " + name);


        //#Q2
        Console.WriteLine("\n#Q2");
        string firstName = "Mohammed";
        string secondName = "Salaah";
        Console.WriteLine("Full-Name : " + firstName + " " + secondName);


        //#Q3
        Console.WriteLine("\n#Q3");
        int MyNumber = 1234;
        string myNum = MyNumber.ToString();
        Console.WriteLine("My Number is : " + myNum);


        //#Q4
        Console.WriteLine("\n#Q4");

        Console.Write("Input the First Number : ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Input the Second Number : ");
        int num2 = int.Parse(Console.ReadLine());

        (num1, num2) = (num2, num1);

        // 3. Print the result
        Console.WriteLine("\nAfter Swapping :");
        Console.WriteLine($"First Number : {num1}");
        Console.WriteLine($"Second Number : {num2}");



        //#Q5
        Console.WriteLine("\n#Q5");


        // 1. Get the number from the user
        Console.Write("Enter the number: ");
        int numb1 = int.Parse(Console.ReadLine());

        // 2. Print the table manually (0 to 10)
        Console.WriteLine("\nMultiplication Table:");

        // Using the $ sign to calculate and display on each line
        Console.WriteLine($"{numb1} * 0 = {numb1 * 0}");
        Console.WriteLine($"{numb1} * 1 = {numb1 * 1}");
        Console.WriteLine($"{numb1} * 2 = {numb1 * 2}");
        Console.WriteLine($"{numb1} * 3 = {numb1 * 3}");
        Console.WriteLine($"{numb1} * 4 = {numb1 * 4}");
        Console.WriteLine($"{numb1} * 5 = {numb1 * 5}");
        Console.WriteLine($"{numb1} * 6 = {numb1 * 6}");
        Console.WriteLine($"{numb1} * 7 = {numb1 * 7}");
        Console.WriteLine($"{numb1} * 8 = {numb1 * 8}");
        Console.WriteLine($"{numb1} * 9 = {numb1 * 9}");
        Console.WriteLine($"{numb1} * 10 = {numb1 * 10}");



        //#Q6
        Console.WriteLine("\n#Q6");
        int firstNum1 = 10;
        int firstNum2 = 15;
        int firstNum3 = 20;
        int firstNum4 = 30;
        int average = (firstNum1 + firstNum2 + firstNum3 + firstNum4) / 4;
        Console.WriteLine("Average of 10,15,20,30 is : " + average);


        //#Q7
        Console.WriteLine("\n#Q7");

        Console.Write("Enter a digit: ");
        int number = int.Parse(Console.ReadLine());

        // --- METHOD 1: Using {0} (Composite Formatting) ---
        // This uses a template where {0} is replaced by the first variable provided
        Console.WriteLine("\nOutput using {0}:");
        Console.WriteLine("{0} {0} {0} {0}", number);
        Console.WriteLine("{0}{0}{0}{0}", number);

        // --- METHOD 2: Using Console.Write / Interpolation ---
        // This repeats the logic to show it twice as requested
        Console.WriteLine("{0} {0} {0} {0}", number);
        Console.WriteLine("{0}{0}{0}{0}", number);

        //#Q8
        Console.WriteLine("\n#Q8");
        Console.WriteLine("enter a number : ");
        int x = int.Parse(Console.ReadLine());
        if (x > 0)
        {
            Console.WriteLine(x + " : Number is positive");
        }
        else if (x < 0)
        {
            Console.WriteLine(x + " : number is negative");
        }
        else
        {
            Console.WriteLine("its zero");
        }

        //#Q9
        Console.WriteLine("\n#Q9");
        Console.WriteLine("Enter a number : ");
        int y = int.Parse(Console.ReadLine());
        if (y % 2 == 0)
        {
            Console.WriteLine(y + ": it is a even number");
        }
        else
        {
            Console.WriteLine(y + " :it is a odd number");
        }

        //#Q10
        Console.WriteLine("\n#Q10");
        Console.WriteLine("enter the first number : ");
        int number21 = int.Parse(Console.ReadLine());


        Console.WriteLine("enter the second number : ");
        int number12 = int.Parse(Console.ReadLine());

        if (number21 > number12)
        {
            Console.WriteLine(number21 + " : is largest number");
        }
        else
        {
            Console.WriteLine(number12 + " \n: is largest number");

        }


        //#Q11
        Console.WriteLine("\n#Q11");
        Console.WriteLine("enter the first number : ");
        int numberX = int.Parse(Console.ReadLine());

        Console.WriteLine("enter the second number : ");
        int numberY = int.Parse(Console.ReadLine());

        Console.WriteLine("enter the third number : ");
        int numberZ = int.Parse(Console.ReadLine());

        if (numberX > numberY && numberX > numberZ)
        {
            Console.WriteLine(numberX + " : is largest number");
        }
        else if (numberY > numberZ)
        {
            Console.WriteLine(numberY + " : is largest number");
        }
        else if (numberZ > numberX || numberZ > numberY)
        {
            Console.WriteLine(numberZ + " : is largest number");
        }
        else
        {
            Console.WriteLine("all numbers are equal");
        }



        //#Q12
        Console.WriteLine("\n#Q12");
        Console.WriteLine("enter the year");
        int year=int.Parse(Console.ReadLine());
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine("Leap Year");
        }
        else
        {
            Console.WriteLine("Not a Leap Year");
        }




        //#Q13
        Console.WriteLine("\n#Q13");
        Console.Write("Enter a letter: ");
        char ch = char.ToLower(char.Parse(Console.ReadLine()));

        if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
        {
            Console.WriteLine("It's a Vowel");
        }
        else
        {
            Console.WriteLine("It's a Consonant");
        }



        //#Q14
        Console.WriteLine("\n#Q14");
        Console.WriteLine("enter your age :");
        int age=int.Parse(Console.ReadLine());

        if (age >=18) {
            Console.WriteLine("your age is : "+age+" you are  eligible");
            }
        else
        {
            Console.WriteLine("your age is :" + age + "you are not eligible");
        }


            //#Q15
            Console.WriteLine("\n#Q15");
        Console.Write("Enter a number: ");
        int numberA = int.Parse(Console.ReadLine());

        if (numberA != 0) // First, check if it's not zero
        {
            if (numberA > 0)
            {
                // Nested check for Positive numbers
                if (numberA % 2 == 0)
                    Console.WriteLine("Positive and Even");
                else
                    Console.WriteLine("Positive and Odd");
            }
            else
            {
                // Nested check for Negative numbers
                if (numberA % 2 == 0)
                    Console.WriteLine("Negative and Even");
                else
                    Console.WriteLine("Negative and Odd");
            }
        }
        else
        {
            Console.WriteLine("The number is zero (neither positive nor negative).");
        }



       


    }
}