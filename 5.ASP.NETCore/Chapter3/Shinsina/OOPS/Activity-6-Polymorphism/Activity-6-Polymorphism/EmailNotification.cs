using System;
using System.Collections.Generic;
using System.Text;

namespace Activity_6_Polymorphism
{
    internal class EmailNotification:Notification
    {
        public override void Send()
        {
            Console.WriteLine("Email Notification");

        }
    }
}
