//int a = 20;
//int b = 30;
//int c = 31;
//int[] numbers = { 20, 30, 31 };//declaration1

//int[] number1 = new int[5] { 1, 2, 3, 4, 5 };
//int[] number2 = new int[5];
//number2[0] = 1;
//number2[1] = 2;
//number2[2] = 3;
//number2[3] = 4;
//number2[4] = 5;

//for(int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i]);
//}
//Console.ReadLine();
//for(int i = 0;i < number1.Length; i++)
//{
//    Console.WriteLine(number1[i]);
//}
//Console.ReadLine();
//foreach(int i in number2) 
//{
//    Console.WriteLine(i);
//}

//Console.ReadLine();

//int[,] numbers3 = { { 1,2,3},{ 2,3,4} };

//int[,] number4= new int[2,3] { { 1, 2, 3 }, { 2, 3, 4 } };

//int[,] number5 = new int[2, 3];
//number5[0,0] = 1;
//number5[0,1] = 2;
//number5[0,2] = 3;
//number5[1,0] = 2;
//number5[1,1] = 3;
//number5[1,2] = 4;

//for(int i = 0; i<2 ; i++)
//{
//    for(int j = 0; j<3 ; j++)
//    {
//        Console.WriteLine(number5[(int)i,j]);
//    }

//}
//Console.ReadLine();

////jagges array
//int[][] number6= new int[3][]; //this means creating an array of 3 array inide 
//number6[0] = new int[] { 5, 2, 6, 7, 9 };//first array created
//number6[1] = new int[] { 8, 5, 2 };
//number6[2] = new int[] {8, 4, 7, 2};
//for(int i = 0;i<number6.Length ; i++)
//{
//    for (int j = 0; j < number6[i].Length ; j++)
//    {
//        Console.WriteLine(number6[i][j]);
//    }
//    Console.ReadLine();
//}


internal class Program
{
    private static void Main(string[] args)
    {
        ////#1
        int[] arr1 = { 87, 24, 95, 52, 12, 34 };
        int max = arr1[0];
        int min = arr1[0];
        for (int i = 1; i < arr1.Length; i++)
        {
            if (arr1[i] > max)
            {
                max = arr1[i];
            }
            if (arr1[i] < min)
            {
                min = arr1[i];
            }
        }
        Console.WriteLine("Array Elements :");
        for (int i = 0; i < arr1.Length; i++)
        {
            Console.Write(arr1[i] + " ");
        }
        Console.WriteLine("\nMaximum Element is: " + max);
        Console.WriteLine("Minimum Element is: " + min);
        Console.ReadLine();


        ////#2
        int[] arr2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Console.WriteLine("The Original Array is: ");
        for (int i = 0; i < arr2.Length; i++)
        {
            Console.Write(arr2[i] + " ");
        }
        Console.WriteLine();
        int start = 0, end = arr2.Length - 1;
        while (start < end)
        {
            int tmp = arr2[start];
            arr2[start] = arr2[end];
            arr2[end] = tmp;
            start++;
            end--;

        }
        Console.WriteLine("Reversed Array is: ");
        for (int i = 0; i < arr2.Length; i++)
        {
            Console.Write(arr2[i] + " ");
        }
        Console.WriteLine();
        Console.ReadLine();



        /////#3
        int[] arr3 = { 23, 45, 65, 34, 12, 76 };
        int sum = 0;
        double avg;
        for (int i = 0; i < arr3.Length; i++)
        {
            sum += arr3[i];
        }
        avg = (double)sum / arr3.Length;
        Console.WriteLine("the array is: ");
        for (int i = 0; i < arr3.Length; i++)
        {
            Console.Write(arr3[i] + " ");
        }

        Console.WriteLine("\nThe sum of all elements in the array is: " + sum);
        Console.WriteLine("The average of all elements in the array is: " + avg);
        Console.ReadLine();


        /////#4
        int[] arr4 = { 1, 2, 2, 4, 4, 7, 7, 7, 6, 6, 6, 6, 8, 8, 8, 0, 0, 0, 5, 5, 5, 5 };
        int count = 0;
        Console.WriteLine("Enter a number to search in the array:");
        int search = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < arr4.Length; i++)
        {
            if (arr4[i] == search)
            {
                count++;
            }

        }

        if (count == 0)
        {
            Console.WriteLine($"The Number {search} is not found in the array!!!! ");
        }
        else
        {
            Console.WriteLine($"The Number {search} appeared {count} times in the array!!!!");
        }
        Console.ReadLine();



        /////#5
        int[] arr5 = { 10, 7, 1, 12, 8 };

        for (int i = 0; i < arr5.Length - 1; i++)
        {
            for (int j = 0; j < arr5.Length - i - 1; j++)
            {
                if (arr5[j] > arr5[j + 1])
                {
                    int temp = arr5[j];
                    arr5[j] = arr5[j + 1];
                    arr5[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Sorted Array in Ascending  Order:");


        foreach (int num in arr5)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
        for (int i = 0; i < arr5.Length - 1; i++)
        {
            for (int j = 0; j < arr5.Length - i - 1; j++)
            {
                if (arr5[j] < arr5[j + 1])   // Change condition for descending
                {
                    int temp = arr5[j];
                    arr5[j] = arr5[j + 1];
                    arr5[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Sorted Array in Descending Order:");
        foreach (int num in arr5)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine();
        Console.ReadLine();



        ///#6&7
        Console.WriteLine("Enter the number of rows :");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the number of columns :");
        int n = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[m, n];
        int sum1 = 0;
        Console.WriteLine("Enter the Elements:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                sum1 += matrix[i, j];
            }
        }

        Console.WriteLine("Matrix:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.ReadLine();
        Console.WriteLine("The sum of each element of the matrix is: " + sum1);
        Console.ReadLine();


        ////#8
        Console.WriteLine("\nSum of each row:");
        for (int i = 0; i < m; i++)
        {
            int rowSum = 0;
            for (int j = 0; j < n; j++)
            {
                rowSum += matrix[i, j];
            }
            Console.WriteLine("Row " + (i + 1) + ": " + rowSum);
        }

        // Sum of each column
        Console.WriteLine("\nSum of each column:");
        for (int j = 0; j < n; j++)
        {
            int colSum = 0;
            for (int i = 0; i < m; i++)
            {
                colSum += matrix[i, j];
            }
            Console.WriteLine("Column " + (j + 1) + ": " + colSum);
        }
        Console.ReadLine();


        ////#9
        int maxM = matrix[0, 0];
        int minM = matrix[0, 0];

        // Find maximum and minimum
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i, j] > maxM)
                    maxM = matrix[i, j];

                if (matrix[i, j] < minM)
                    minM = matrix[i, j];
            }
        }
        Console.WriteLine("Minimum Element in the matrix is: " + minM);
        Console.WriteLine("Maximum Element in the Matrix is: " + maxM);
        Console.ReadLine();



        ///#10
        int row=matrix.GetLength(0);
        int col=matrix.GetLength(1);
        int[,] transpose = new int[col,row];
        for (int i = 0; i < row; i++)
        {
            for(int j = 0;j < col; j++)
            {
                transpose[j,i] = matrix[i, j];
            }
        }
        Console.WriteLine("Transpose of the matrix is: ");
        for (int i = 0;i < row; i++)
        {
            for( int j = 0;j < col; j++)
            {
                Console.Write(transpose[i, j]+"\t");
            }
            Console.WriteLine();
        }
        Console.ReadLine ();



        ////#11
        int[][] jaggedArray = new int[3][];//this means creating an array of 3 array inside 

        jaggedArray[0] = new int[] { 10, 20, 30 }; //first array created
        jaggedArray[1] = new int[] { 40, 50 };
        jaggedArray[2] = new int[] { 60, 70, 80, 90 };

        // Display jagged array elements
        Console.WriteLine("Jagged Array Elements:");

        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(jaggedArray[i][j] + " ");
            }
            Console.WriteLine();
        }
        Console.ReadLine ();



        ///#12
        Console.Write("Enter number of Arrays of jagged array: ");
        int rows = int.Parse(Console.ReadLine());
        int[][] jaggedArr = new int[rows][];
        for (int i = 0; i < rows; i++)
        {
            Console.Write($"Enter Number o Elements in Array{i + 1}: ");
            int cols = int.Parse(Console.ReadLine());
            jaggedArr[i]= new int[cols];
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Enter element [{i},{j}]: ");
                jaggedArr[i][j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("\nJagged Array in Matrix Format:");

        for (int i = 0; i < jaggedArr.Length; i++)
        {
            for (int j = 0; j < jaggedArr[i].Length; j++)
            {
                Console.Write(jaggedArr[i][j] + "\t");
            }
            Console.WriteLine();
        }

        Console.ReadLine();



        ////#13
        int maxSum = int.MinValue;
        int maxRowIndex = -1;

        // Find row with highest sum
        for (int i = 0; i < jaggedArr.Length; i++)
        {
            int rowSum = 0;

            for (int j = 0; j < jaggedArr[i].Length; j++)
            {
                rowSum += jaggedArr[i][j];
            }

            if (rowSum > maxSum)
            {
                maxSum = rowSum;
                maxRowIndex = i;
            }
        }

        // Display result
        Console.WriteLine($"\nRow {maxRowIndex + 1} has the highest sum.");
        Console.WriteLine($"Highest Sum = {maxSum}");

    }
}