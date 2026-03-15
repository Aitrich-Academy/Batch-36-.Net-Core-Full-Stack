using Activity_2_Constructors;
using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace Activity_2_Constructors
{
    internal class Logger
    {
        public static int logCount;

        static Logger()
        {

         
            logCount = 100;
            Console.WriteLine("\n------ Q4 -------");
            Console.WriteLine("Static Constructor Executed");
        }
        // Static method
        public static void LogMessage(string msg)
        {
            logCount++;
            Console.WriteLine($"Log {logCount}: {msg}");
        }

    }
}
//Q1

//How many times does the static constructor run?
//👉 Only once in the entire program execution.
//Even if you call Logger.LogMessage() many times, the static constructor runs just one time.

//Q2

//When does it execute?
//👉 The static constructor executes:
//Automatically
//Before the first use of the class
//When the class is accessed for the first time
//In this example, it runs before the first call to Logger.LogMessage().