using System;
using System.Collections.Generic;
using System.Text;
using Workshop1.Interface;
using Workshop1.Model;

namespace Workshop1.Manager
{
    class Admin : IAccount
    {
        JobManager job=new JobManager();
        Admin[] admins = new Admin[2];
        Job[] jobs = new Job[100];

        static int adminCount = 0;
        static int jobCount = 0;

        public string username;
        public string name;
        public string password;

        public void Register()
        {
            if (adminCount >= 2)
            {
                Console.WriteLine("Admin limit reached");
                return;
            }

            Admin a = new Admin();

            Console.Write("Enter Username: ");
            a.username = Console.ReadLine();

            Console.Write("Enter Name: ");
            a.name = Console.ReadLine();

            Console.Write("Enter Password: ");
            a.password = Console.ReadLine();

            admins[adminCount] = a;
            adminCount++;

            Console.WriteLine("Registration Successful");
        }

        public bool Login()
        { 
            Console.Write("Enter Username: ");
            string user = Console.ReadLine();

            Console.Write("Enter Password: ");
            string pass = Console.ReadLine();

            for (int i = 0; i < adminCount; i++)
            {
                if (admins[i].username == user && admins[i].password == pass)
                {
                    Console.WriteLine("Login Successful");
                    bool back = false;

                    while (!back)
                    {
                        Console.WriteLine("\nADMIN MENU");
                        Console.WriteLine("1 Post Job");
                        Console.WriteLine("2 List Jobs");
                        Console.WriteLine("3 Back");

                        int ch = Convert.ToInt32(Console.ReadLine());

                        switch (ch)
                        {
                            case 1:
                                job.PostJob();
                                break;

                            case 2:
                                job.ListJobs();
                                break;

                            case 3:
                                back = true;
                                break;
                        }
                    }

                    return true;
                }
            }
          

            Console.WriteLine("Invalid Login");
            return false;
        }
    }
}
