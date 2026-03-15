using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    public abstract class User
    {
        public int id;
        public string name;
        public string email;

        public void login(string email)
        {
            Console.WriteLine("Login successfull");
        }
        public abstract void displayInfo();
        
    }
}
