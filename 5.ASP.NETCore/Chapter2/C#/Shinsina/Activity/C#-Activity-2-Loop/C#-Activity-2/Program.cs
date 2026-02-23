using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        //#Q1
        Console.WriteLine("#Q1"); 
        Console.WriteLine("Even numbers from 1 to 50:"); 
        for (int i = 1; i <= 50; i++) { 
            if (i % 2 == 0) {
                Console.Write(i + " ");
            }
        } Console.ReadLine();

        //#Q2
        Console.WriteLine("\n#Q2");
        int n, rem, rev = 0;

        Console.WriteLine("Enter the number:");
        n = Convert.ToInt32(Console.ReadLine());

        while (n > 0)
        {
            rem = n % 10;
            rev = rev * 10 + rem;
            n = n / 10;
        }

        Console.WriteLine("Reverse is {0}", rev);

        //#Q3
        Console.WriteLine("\n#Q3");


        int number, digit, sum = 0;

        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        number = Math.Abs(number); // Handle negative numbers

        do
        {
            digit = number % 10;  // Get last digit
            sum += digit;         // Add digit to sum
            number /= 10;         // Remove last digit
        }
        while (number > 0);

        Console.WriteLine("Sum of digits: " + sum);



        //#Q4
        Console.WriteLine("\n#Q4");

        int m, f = 1;
        Console.Write("Enter a number : ");
        m= Convert.ToInt32(Console.ReadLine());

        for (int j= 1; j <= m; j++)
        {
            f = f * j;
        }
            Console.WriteLine("Factorial is "+ f);

        //#Q5
        Console.WriteLine("\n#Q5");

        int number1, count = 0;

        Console.Write("Enter a number: ");
        number1 = Convert.ToInt32(Console.ReadLine());

        number1 = Math.Abs(number1); // Handle negative numbers

        if (number1 == 0)
        {
            count = 1; // Special case for 0
        }
        else
        {
            while (number1 > 0)
            {
                number1 /= 10; // Remove last digit
                count++;
            }
        }

        Console.WriteLine("Number of digits: " + count);


        //#Q6
        Console.WriteLine("\n#Q6");
        int n1 = 0, n2 = 1, n3, count1 = 2;

        Console.WriteLine("Fibonacci series (first 10 numbers):");
        Console.Write(n1 + " " + n2 + " "); // Print first two numbers

        do
        {
            n3 = n1 + n2;       // Calculate next number
            Console.Write(n3 + " ");
            n1 = n2;            // Shift n1 to n2
            n2 = n3;            // Shift n2 to n3
            count1++;
        }
        while (count1 < 10);     // Repeat until 10 numbers are printed

        Console.ReadLine();



        //#Q7
        Console.WriteLine("\n#Q7");

        // Example array
        // Example array
        int[] numbers = { 5, 10, 15, 20, 25 };
        int sum1 = 0;

        // Using foreach loop to sum all elements
        foreach (int num in numbers)
        {
            sum1 += num;
        }

        Console.WriteLine("Sum of all elements: " + sum1);
        Console.ReadLine();


        //#Q8
        Console.WriteLine("\n#Q8");

        // Example array
        int[] numbers2 = { 15, 42, 7, 89, 23 };
        int largest1 = numbers2[0]; // Assume first element is largest

        // Using foreach loop to find the largest
        foreach (int num in numbers2)
        {
            if (num > largest1)
            {
                largest1 = num; // Update largest if current number is bigger
            }
        }

        Console.WriteLine("Largest number in the array: " + largest1);
        Console.ReadLine();



        //#Q9
        Console.WriteLine("\n#Q9");

        int number3, originalNumber, reversed = 0, remainder;

        Console.Write("Enter a number: ");
        number3 = Convert.ToInt32(Console.ReadLine());

        originalNumber = number3;          // Store the original number
        number = Math.Abs(number3);        // Handle negative numbers if needed

        // Reverse the number using while loop
        while (number3 > 0)
        {
            remainder = number3 % 10;      // Get last digit
            reversed = reversed * 10 + remainder; // Build reversed number
            number3 /= 10;                 // Remove last digit
        }

        // Check if original number and reversed number are the same
        if (originalNumber == reversed)
        {
            Console.WriteLine("{0} is a palindrome.", originalNumber);
        }
        else
        {
            Console.WriteLine("{0} is not a palindrome.", originalNumber);
        }

        Console.ReadLine();

        //#Q10
        Console.WriteLine("\n#Q10");
        int rows = 4; // Number of rows in the triangle

        for (int i = 1; i <= rows; i++) // Loop for each row
        {
            for (int j = 1; j <= i; j++) // Print stars in each row
            {
                Console.Write("*");
            }
            Console.WriteLine(); // Move to the next line
        }

        Console.ReadLine();


    }
}