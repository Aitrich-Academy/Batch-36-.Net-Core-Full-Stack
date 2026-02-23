// See https://aka.ms/new-console-template for more information

//#1
int age = 37;
double weight=78.50;
string name = "Sruthy";
Console.WriteLine("Name:" +name +"\nAge:"+age+"\nWeight:"+weight);


//#2
string firstName = "Sruthy";
string lastName = "Ratheesh";
string fullName=firstName+" "+lastName;
Console.WriteLine(fullName);

//#3
int num1 = 123456789;
Console.WriteLine("Number: "+num1);
string numToString = num1.ToString();
Console.WriteLine("number As String:"+numToString);

//#4
int firstNum = 5;
int secondNum = 6;
Console.WriteLine("First Number is :" + firstNum+" Second number is: " + secondNum);
//swapping
int temp=firstNum;
firstNum = secondNum;
secondNum = temp;
Console.WriteLine("After Swapping.....");
Console.WriteLine("First Number is :" + firstNum+" Second number is: " + secondNum);


//#5
Console.Write("Enter the number for multipliication table: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine(num + " * 0 = " + (num * 0));
Console.WriteLine(num + " * 1 = " + (num * 1));
Console.WriteLine(num + " * 2 = " + (num * 2));
Console.WriteLine(num + " * 3 = " + (num * 3));
Console.WriteLine(num + " * 4 = " + (num * 4));
Console.WriteLine(num + " * 5 = " + (num * 5));
Console.WriteLine(num + " * 6 = " + (num * 6));
Console.WriteLine(num + " * 7 = " + (num * 7));
Console.WriteLine(num + " * 8 = " + (num * 8));
Console.WriteLine(num + " * 9 = " + (num * 9));
Console.WriteLine(num + " * 10 = " + (num * 10));


//#6
Console.WriteLine("Enter the First Number:");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the Second Number:");
int secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the Third Number:");
int thirdNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the Fourth Number:");
int fourthNumber = int.Parse(Console.ReadLine());
Console.WriteLine("The Average of "+firstNumber+", "+secondNumber+", "+thirdNumber+", "+fourthNumber+": "+(firstNumber+secondNumber+thirdNumber+fourthNumber)/4 );


//#7
Console.Write("Enter a number: ");
int num0 = int.Parse(Console.ReadLine());

// First time
Console.Write("{0} {0} {0} {0}\n", num0);
Console.Write("{0}{0}{0}{0}\n", num0);

// Second time
Console.Write("{0} {0} {0} {0}\n", num0);
Console.Write("{0}{0}{0}{0}\n", num0);

//#8
if (num0 > 0)
{
    Console.WriteLine(num0 + " is a positive number");
}
else
{
    Console.WriteLine(num0 + " is a negative number");
}


//#9
if (num0 % 2 == 0)
{
    Console.WriteLine(num0 + " is an even number");
}
else
{
    Console.WriteLine(num0 + " is an odd number");
}

//#10
if (firstNumber > secondNumber)
{
    Console.WriteLine("The largest of " + firstNumber + " and " + secondNumber + " is: " + firstNumber);
}
else
{
    Console.WriteLine("The largest of " + firstNumber + " and " + secondNumber + " is: " + secondNumber);
}


//#11
if (firstNumber >= secondNumber && firstNumber >= thirdNumber)
{
    Console.WriteLine("Largest number of " + firstNumber + ", " + secondNumber + ", " + thirdNumber +" is:" + firstNumber);
}
else if (secondNumber >= firstNumber && secondNumber >= thirdNumber)
{
    Console.WriteLine("Largest number of " + firstNumber + ", " + secondNumber + ", " + thirdNumber +" is:" + secondNumber);
}
else
{
    Console.WriteLine("Largest number of " + firstNumber + ", " + secondNumber + ", " + thirdNumber + " is:" + thirdNumber);
}


//#12
Console.WriteLine("Enter a year:");
int year=int.Parse(Console.ReadLine());
if (year % 4 == 0)
{
    Console.WriteLine("You Entered is a leap year");
}
else
{
    Console.WriteLine("You Entered is not a leap year");
}


//#13
Console.Write("Enter a character: ");
char ch = char.Parse(Console.ReadLine().ToLower());

if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
{
    Console.WriteLine("The character is a Vowel");
}
else
{
    Console.WriteLine("The character is a Consonant");
}


//#14
if (age >= 18)
{
    Console.WriteLine("You are eligible to vote");
}
else
{
    Console.WriteLine("You are not eligible to vote");
}

//#15
if (num0 == 0)
{
    Console.WriteLine(num0 + " is Zero");
}
else if (num0 > 0)
{
    Console.WriteLine(num0 + " is a positive number");
}
else
{
    Console.WriteLine(num0 + " is a negative number");
}


//#16

if (num0 % 2 == 0)
{
    if (num0 > 0)
    {
        Console.WriteLine(num0 + " is a positive even number");
    }
    else
    {
        Console.WriteLine(num0 + " is a negative even number");
    }
}
else
{
    if (num0 > 0)
    {
        Console.WriteLine(num0 + " is a positive odd number");
    }
    else
    {
        Console.WriteLine(num0 + " is a negative odd number");
    }
}


//Loops

//#1
Console.WriteLine("All even numbers from 1-50 :");
for(int i = 1; i <= 50; i++)
{
    if(i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}


//#2
Console.Write("Enter a number: ");
int num123 = int.Parse(Console.ReadLine());
int originalNum = num123; // store original number
int originalNum1 = num123;
int reversed = 0;

while (num123 != 0)
{
    int digit = num123 % 10;           // get last digit
    reversed = reversed * 10 + digit;  // append digit
    num123 = num123 / 10;              // remove last digit
}

Console.WriteLine("Original Number: " + originalNum);
Console.WriteLine("Reversed Number: " + reversed);

//#3
int sum = 0;

do
{
    int digit = originalNum1 % 10;   // get last digit
    sum += digit;              // add to sum
    originalNum1 = originalNum1 / 10;      // remove last digit
} while (originalNum1 != 0);

Console.WriteLine("Sum of digits of " + originalNum + " is: " + sum);


//#10
for(int i = 1;i <= 5; i++)
{
    for(int j = 1;j <= i; j++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();

}