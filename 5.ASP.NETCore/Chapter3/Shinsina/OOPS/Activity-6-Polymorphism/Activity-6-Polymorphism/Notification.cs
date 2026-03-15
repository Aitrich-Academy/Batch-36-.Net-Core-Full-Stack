using System;
using System.Collections.Generic;
using System.Text;

namespace Activity_6_Polymorphism
{
    internal class Notification
    {
        public virtual void Send()
        {
            Console.WriteLine("\nQ4");
            Console.WriteLine("Sending Messages");
        }



        // Method 1: Send with recipient only
        public void Send(string recipient)
        {
            Console.WriteLine("\nQ5");
            Console.WriteLine("\nSending notification to " + recipient);
        }

        // Method 2: Send with recipient and custom message
        public void Send(string recipient, string message)
        {
            Console.WriteLine("Sending notification to " + recipient + ": " + message);
        }

        // Method 3: Send with recipient, message, and priority
        public void Send(string recipient, string message, int priority)
        {
            Console.WriteLine("Sending notification to " + recipient +
                              " | Message: " + message + " | Priority: " + priority);
        }
    }
}
