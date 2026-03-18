using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    internal class UserLogin:ILogin
    {
        string user = "user";
        string pass = "user";
        public void Authenticate(string username, string password)
        {
            if (user == username && pass == password)
            {
                
                    Console.WriteLine("\nUser Logged in Successfully!!!!\n");
                
            }
            else
            {
                Console.WriteLine("\nUser Username / password is Incorrect!!!! \nLogin is Unsuccessfull\n\n");
            }
        }
    }
}
