internal class Program
{
//#Q!
    struct Patient
    {
        public int Id;
        public string Name;
        public int Age;
    }

//#Q3

    struct Students
    {
        public int RollNumber;
        public string Name;
        public int[] Grades;
    }

//#Q4

    struct Item
    {
        public int ItemCode;
        public string ItemName;
        public int Quantity;
    }
    //#Q6
    struct WeeklyForecast
    {
        public double[] Temps;

        public void ProcessData()
        {
            // 2. Find High/Low
            double high = Temps.Max();
            double low = Temps.Min();

            // 3. Calculate Average
            double average = Temps.Average();

            Console.WriteLine($"\nHighest Temp: {high}°");
            Console.WriteLine($"Lowest Temp:  {low}°");
            Console.WriteLine($"Average Temp: {average:F2}°");

            // 4. Identify days below average
            Console.Write("Days below average (Indices): ");
            for (int i = 0; i < Temps.Length; i++)
            {
                if (Temps[i] < average)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Question 1: Hospital Management");
        Patient[] patients = new Patient[5];

        for (int i = 0; i < patients.Length; i++) {
            Console.WriteLine($"\nEnter details for Patient {i + 1}:");

            Console.Write("Enter ID: ");
            patients[i].Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            patients[i].Name = Console.ReadLine() ??"";

            Console.Write("Enter Age: ");
            patients[i].Age = Convert.ToInt32(Console.ReadLine());



        }

        Console.WriteLine("\n--- Patient Details ---");
        for (int i = 0; i < patients.Length; i++)
        {
            Console.WriteLine($"\nPatient {i + 1}:");
            Console.WriteLine("ID: " + patients[i].Id);
            Console.WriteLine("Name: " + patients[i].Name);
            Console.WriteLine("Age: " + patients[i].Age);
        }
        Console.ReadLine();



        //Q2
        double[] temperatures = new double[7];
        double sum = 0;
        Console.WriteLine("--- Weather Station Temperature Recorder ---");
        for (int i = 0; i < temperatures.Length; i++)
        {
            Console.Write($"Enter temperature for day {i + 1}: ");
            while (!double.TryParse(Console.ReadLine(), out temperatures[i]))
            {
                Console.Write("Invalid input. Please enter a numeric temperature: ");
            }
            sum += temperatures[i];
        }

        // 3. Calculate Average
        double average = sum / temperatures.Length;

        // 4. Find Highest and Lowest
        double highest = temperatures.Max();
        double lowest = temperatures.Min();

        // 5. Print Results
        Console.WriteLine("\n--- Weekly Statistics ---");
        Console.WriteLine($"Average Temperature: {average:F2}°");
        Console.WriteLine($"Highest Temperature: {highest}°");
        Console.WriteLine($"Lowest Temperature:  {lowest}°");

        Console.ReadLine();


        //Q3

        Console.WriteLine("\nQuestion 3: Student Grades");
        Students[] students = new Students[3];

        for (int i = 0; i < students.Length; i++)
        {
            Console.Write("enter RollNo: ");
            students[i].RollNumber= Convert.ToInt32(Console.ReadLine());

            Console.Write("Entre the Name: ");
            students[i].Name = Console.ReadLine() ?? "";

            students[i].Grades = new int[5];
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"Enter grade for Subject {j + 1}: ");
                students[i].Grades[j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("\n================ Student Records ================");
        foreach (var student in students)
        {
            double average1 = student.Grades.Average();

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"Roll No: {student.RollNumber}");
            Console.WriteLine($"Name:    {student.Name}");
            Console.WriteLine($"Grades:  {string.Join(", ", student.Grades)}");
            Console.WriteLine($"Average: {average1:F2}");
        }
        Console.ReadLine() ;

        //Q4

        Console.WriteLine("\nQuestion4: Inventory Management");

        Item[] inventory = new Item[4];

        for (int i = 0; i < inventory.Length; i++)
        {
            Console.WriteLine($"\nEnter details for Item {i + 1}:");

            Console.Write("Enter Item Code: ");
            inventory[i].ItemCode = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Item Name: ");
            inventory[i].ItemName = Console.ReadLine() ?? "";

            Console.Write("Enter Quantity: ");
            inventory[i].Quantity = Convert.ToInt32(Console.ReadLine());
        }
        // 4. Search for an item by ItemCode
        Console.Write("\nEnter Item Code to search: ");
        int searchCode = int.Parse(Console.ReadLine() ?? "");
        bool found = false;

        foreach (var item in inventory)
        {
            if (item.ItemCode == searchCode)
            {
                Console.WriteLine("\n--- Item Found ---");
                Console.WriteLine($"Code:     {item.ItemCode}");
                Console.WriteLine($"Name:     {item.ItemName}");
                Console.WriteLine($"Quantity: {item.Quantity}");
                found = true;
                break; // Exit loop once the item is found
            }
        }

        if (!found)
        {
            Console.WriteLine("\nItem not found in the inventory.");
        }


        //Q5
        // 1. Array for 4 candidates
        int[] votes = new int[4];
        int totalVotes = 0;

        // 2. Read votes from user
        for (int i = 0; i < votes.Length; i++)
        {
            Console.Write($"Enter votes for Candidate {i + 1}: ");
            int.TryParse(Console.ReadLine() ?? "0", out votes[i]);
            totalVotes += votes[i];
        }

        // 3. Calculate and print total
        Console.WriteLine($"\nTotal Votes Cast: {totalVotes}");

        // 4. Determine candidate with highest votes
        int maxVotes = votes.Max();
        int winnerIndex = Array.IndexOf(votes, maxVotes);

        Console.WriteLine($"Winner: Candidate {winnerIndex + 1} with {maxVotes} votes.");



        //Q6
        WeeklyForecast myWeek;
        myWeek.Temps = new double[7];

        // 1. Store temperatures
        for (int i = 0; i < 7; i++)
        {
            Console.Write($"Enter temp for Day {i}: ");
            double.TryParse(Console.ReadLine() ?? "0", out myWeek.Temps[i]);
        }

        myWeek.ProcessData();
    }


}