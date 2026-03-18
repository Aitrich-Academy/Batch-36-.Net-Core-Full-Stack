using System;
using System.Collections.Generic;
using System.Text;

namespace Activity1
{
    internal class Logger
    {
        static int logCount;
        static Logger()
        {
            logCount = 100;
            Console.WriteLine("Static constructor runs here.....");
        }
        public static void LogMessage(string message)
        {
            logCount++;
            Console.WriteLine($"Log{logCount} : {message}");
        }
    }
}
