using Exercise2.Model;
using Exercise2.Utils;
using System;
using System.Collections.Generic;
using System.Text;
//using Exercise2.Model;

namespace Exercise2.Manager
{
    class AdminManager
    {
        Printer printer = new Printer();

        public void ViewRegistrations(User[] users,int count)
        {
            if (count == 0) 
            {
                Console.WriteLine("No users registered yet.");
                return;
            }
            User[] temp = new User[count];
            Array.Copy(users, temp, count);  // create array of actual users
            printer.Print(temp);
            
        }

        public void ViewJobs(JobManager jobManager)
        {
            jobManager.ListJobs();
        }
    }
}
