using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    internal class AdminLogin:ILogin
    {
        string user = "admin";
        string pass="admin";
        public void Authenticate(string username, string password)
        {
            if (user == username && pass == password)
            {

                Console.WriteLine("\nAdmin Logged in Successfully!!!!\n");

            }
            else
            {
                Console.WriteLine("\nAdmin username / password is Incorrect!!!! \nLogin is Unsuccessfull\n\n");
            }
        }
    }
}
