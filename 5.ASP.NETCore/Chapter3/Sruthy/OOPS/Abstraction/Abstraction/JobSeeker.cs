using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    internal class JobSeeker:User
    {
        public string userName;
        public string password;

        public override void displayInfo()
        {
            Console.WriteLine("Email:" + email + "\nUsername: " + userName);
        }

    }
}
