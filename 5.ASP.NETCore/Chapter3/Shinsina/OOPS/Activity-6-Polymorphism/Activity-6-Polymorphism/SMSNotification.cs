using System;
using System.Collections.Generic;
using System.Text;

namespace Activity_6_Polymorphism
{
    internal class SMSNotification:Notification
    {
        public override void Send()
        {
            Console.WriteLine("SMS notification");
        }
    }
}
