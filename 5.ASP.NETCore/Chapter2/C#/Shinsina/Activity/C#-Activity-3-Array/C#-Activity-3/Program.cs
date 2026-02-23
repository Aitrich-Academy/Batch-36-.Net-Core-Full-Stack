// See https://aka.ms/new-console-template for more information
Console.WriteLine("single-dimensional array");

        //#Q1
        Console.WriteLine("#Q1");
    
        // 1. Initialize a sample array
        int[] numbers = { 34, 12, 89, 5, 56, 21, 99, 1 };

        // 2. Handle the case of an empty array
        if (numbers.Length == 0)
        {
            Console.WriteLine("The array is empty.");
            return;
        }

        // 3. Assume the first element is both max and min
        int max = numbers[0];
        int min = numbers[0];

        // 4. Iterate through the array starting from the second element
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }

            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }

        // 5. Output the results
        Console.WriteLine("Array elements: " + string.Join(", ", numbers));
        Console.WriteLine($"Maximum Element: {max}");
        Console.WriteLine($"Minimum Element: {min}");


//#Q2
Console.WriteLine("\n#Q2");


// 1. Initialize a sample array
int[] arr = { 10, 20, 30, 40, 50, 60 };

Console.WriteLine("Original: " + string.Join(", ", arr));

// 2. Reverse the array manually
ReverseArray(arr);

// 3. Output the result
Console.WriteLine("Reversed: " + string.Join(", ", arr));
    

    static void ReverseArray(int[] array)
{
    int start = 0;
    int end = array.Length - 1;

    while (start < end)
    {
        // Swap elements at start and end
        int temp = array[start];
        array[start] = array[end];
        array[end] = temp;

        // Move pointers towards the middle
        start++;
        end--;
    }
}


//#Q3
Console.WriteLine("\n#Q3");
int[] number1 = { 15, 25, 35, 45, 55 };
int sum = 0;
double average = 0.0;
foreach (int num in numbers)
{
    sum += num;
}
if (numbers.Length > 0)
{
    average = (double)sum / numbers.Length;
}

Console.WriteLine("Array: " + string.Join(", ", numbers));
Console.WriteLine($"Total Sum: {sum}");
Console.WriteLine($"Average:   {average:F2}");

//#Q4
Console.WriteLine("\n#Q4");
int[] number2 = { 5, 2, 8, 5, 1, 5, 9 };
int target = 5;
int count = 0;


for (int i = 0; i < number2.Length; i++)
{
    if (number2[i] == target)
    {
        count++;
    }
}

Console.WriteLine($"The number {target} appears {count} times.");


//#Q5
Console.WriteLine("\n#Q5");
int[] arry = { 5, 2, 8, 1, 3 };

// Outer loop: goes through the whole array
for (int i = 0; i < arry.Length - 1; i++)
{
    // Inner loop: compares adjacent numbers
    for (int j = 0; j < arry.Length - 1 - i; j++)
    {
        if (arry[j] > arry[j + 1]) // Change > to < for Descending
        {
            // Basic swap logic
            int temp = arry[j];
            arry[j] = arry[j + 1];
            arry[j + 1] = temp;
        }
    }
}

Console.WriteLine("Sorted: " + string.Join(", ", arry));
Console.ReadLine();


Console.WriteLine("Multi dimensional array");

//#Q1
Console.WriteLine("#Q1");
Console.Write("Enter rows (m): ");
int m = Convert.ToInt32(Console.ReadLine()); Console.Write("Enter columns (n): ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];

// Input
for (int i = 0; i < m; i++)
{
for (int j = 0; j < n; j++)
{
Console.Write($"Enter value for [{i},{j}]: ");
matrix[i, j] = int.Parse(Console.ReadLine());
}
}

// Display
Console.WriteLine("\nDisplaying Matrix:");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

    //#Q2
    Console.WriteLine("#Q2");
    int[,] matrix1 = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
    int totalSum = 0;

    foreach (int item in matrix1)
    {
        totalSum += item;
    }

    Console.WriteLine("Total sum of all elements: " + totalSum);

    //#Q3
    Console.WriteLine("\nQ3");


// Define a 3x3 2D array
int[,] matrix2 = {
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};

int rows = matrix2.GetLength(0);
int cols = matrix2.GetLength(1);

// 1. Calculate Sum of Each Row
Console.WriteLine("--- Row Sums ---");
for (int r = 0; r < rows; r++) // Using 'r' for row index
{
    int rowSum = 0;
    for (int c = 0; c < cols; c++) // Using 'c' for column index
    {
        rowSum += matrix2[r, c];
    }
    Console.WriteLine($"Sum of Row {r + 1}: {rowSum}");
}

// 2. Calculate Sum of Each Column
Console.WriteLine("\n--- Column Sums ---");
for (int c = 0; c < cols; c++) // Using 'c' for column index
{
    int colSum = 0;
    for (int r = 0; r < rows; r++) // Using 'r' for row index
    {
        colSum += matrix2[r, c];
    }
    Console.WriteLine($"Sum of Column {c + 1}: {colSum}");
}


//#Q4
Console.WriteLine("\nQ4");

int[,] matrix3 = { { 10, 2, 55 }, { 4, 88, 1 } };

int max1 = matrix3[0, 0];
int min1 = matrix3[0, 0];

for (int i1 = 0; i1 < matrix3.GetLength(0); i1++)
{
    for (int j = 0; j < matrix3.GetLength(1); j++)
    {
        if (matrix3[i1, j] > max) max = matrix3[i1, j];
        if (matrix3[i1, j] < min) min = matrix3[i1, j];
    }
}

Console.WriteLine("Largest Element: " + max1);
Console.WriteLine("Smallest Element: " + min1);
    


//#Q5
Console.WriteLine("\nQ5");


int[,] matrix4 = {
    { 1, 2, 3 },
    { 4, 5, 6 }
};

int height = matrix4.GetLength(0); // Original rows (2)
int width = matrix4.GetLength(1);  // Original columns (3)

// The transpose dimensions are swapped: width becomes the height
int[,] transpose = new int[width, height];

// 1. Processing the Transpose logic
for (int y = 0; y < height; y++)
{
    for (int x = 0; x < width; x++)
    {
        // Flip the coordinates: matrix[y, x] becomes transpose[x, y]
        transpose[x, y] = matrix4[y, x];
    }
}

// 2. Displaying the Transposed Matrix
Console.WriteLine("Transposed Matrix:");
for (int y = 0; y < width; y++) // Loop through the new height (3)
{
    for (int x = 0; x < height; x++) // Loop through the new width (2)
    {
        Console.Write(transpose[y, x] + "\t");
    }
    Console.WriteLine();
}



Console.WriteLine("\nJAGGED ARRAY");

//#Q1
Console.WriteLine("\nQ1");

    int[][] shelf = new int[3][];
    shelf[0] = new int[] { 10, 20 };
    shelf[1] = new int[] { 30, 40, 50 };
    shelf[2] = new int[] { 60 };

    // Display using p (row) and q (column)
    for (int p = 0; p < shelf.Length; p++)
    {
        for (int q = 0; q < shelf[p].Length; q++)
        {
            Console.Write(shelf[p][q] + " ");
        }
        Console.WriteLine();
    }




//#Q2
Console.WriteLine("\nQ2");
Console.Write("Enter number of rows: ");
int rowCount = Convert.ToInt32(Console.ReadLine());
//int rowCount = int.Parse(Console.ReadLine());
int[][] data = new int[rowCount][];

for (int r = 0; r < rowCount; r++)
{
    Console.Write($"How many numbers in row {r + 1}? ");
    int cols1 = Convert.ToInt32(Console.ReadLine());
    data[r] = new int[cols1];

    for (int c = 0; c < cols1; c++)
    {
        Console.Write($"Enter value for [{r}][{c}]: ");
        data[r][c] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("\n--- Jagged Matrix Format ---");
foreach (int[] row in data)
{
    Console.WriteLine(string.Join("\t", row));
}


//#Q3
Console.WriteLine("\nQ3");
int[][] groups = {
            new int[] { 1, 2, 3 },
            new int[] { 10, 5 },
            new int[] { 4, 4, 4, 4 }
        };

int highestSum = int.MinValue;
int bestRow = 0;

for (int i = 0; i < groups.Length; i++)
{
    int currentSum = 0;
    foreach (int val in groups[i]) currentSum += val;

    if (currentSum > highestSum)
    {
        highestSum = currentSum;
        bestRow = i;
    }
}

Console.WriteLine($"Row {bestRow + 1} has the maximum sum: {highestSum}");


//#Q4
Console.WriteLine("\nQ4");

int[][] grid = {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5 },
            new int[] { 6, 7, 8, 9 }
        };

for (int row = 0; row < grid.Length; row++)
{
    int start = 0;
    int end = grid[row].Length - 1;

    while (start < end)
    {
        // Swap logic using t (temp)
        int t = grid[row][start];
        grid[row][start] = grid[row][end];
        grid[row][end] = t;
        start++;
        end--;
    }
}

Console.WriteLine("Rows Reversed!");
foreach (var r in grid) Console.WriteLine(string.Join(", ", r));
//#Q5
Console.WriteLine("\nQ5");
int[][] numbers5 = {
            new int[] { 5, 12, 3 },
            new int[] { 99, 105, 2 },
            new int[] { 7, 8 }
        };

for (int a = 0; a < numbers5.Length; a++)
{
    int maxVal = numbers5[a][0]; // Start with first element of the row
    for (int b = 1; b < numbers5[a].Length; b++)
    {
        if (numbers5[a][b] > maxVal)
        {
            maxVal = numbers5[a][b];
        }
    }
    Console.WriteLine($"Max in Row {a + 1}: {maxVal}");
}