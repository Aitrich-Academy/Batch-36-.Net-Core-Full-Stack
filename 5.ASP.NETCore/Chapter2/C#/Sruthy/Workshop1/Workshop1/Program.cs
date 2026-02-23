using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Workshop1
{
    internal class Program

    {

        struct adminProfile
        {
            public string fullname;
            public string username;
            public string Email;
            public long Phonenumber;
        }
        static void Main(string[] args)
        {
            
                adminProfile[] admin = new adminProfile[1];
                bool isregistered = false;
                char choice;

                string ch;
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------\n");
                Console.WriteLine("---------------------------------------------------------------- Welcome to Admin Part----------------------------------------------------------------------------------\n");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------\n");

                do
                {
                    Console.WriteLine("A - Register as Admin");
                    Console.WriteLine("D - Display Admin Details");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------\n");
                    Console.WriteLine("Select an option from the list\n");
                    string Command = Console.ReadLine();

                    switch (Command)
                    {
                        case "A":
                        case "a":
                            {


                                Console.WriteLine("----------------------------------------------------------------Admin Registration-------------------------------------------------------------------------------------\n");
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------\n");
                                Console.Write("Enter name of Admin:  \n ");
                                admin[0].fullname = Console.ReadLine();
                                Console.Write("Enter the username of admin : \n ");
                                admin[0].username = Console.ReadLine();
                                Console.Write("Enter the Email of admin : \n");
                                admin[0].Email = Console.ReadLine();
                                Console.Write("Enter the Phone no of Admin : \n");
                                admin[0].Phonenumber = Convert.ToInt64(Console.ReadLine());
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------\n");
                                isregistered = true;
                                Console.WriteLine("\nAdmin registered successfully!\n");

                                break;
                            }

                        case "D":
                        case "d":

                        {


                                Console.WriteLine("----------------------------------------------------------------List of Admin-------------------------------------------------------------------------------------\n");
                            Console.WriteLine("----------------------------------------------------------------List of Admin-------------------------------------------------------------------------------------\n");

                            if (!isregistered)
                            {
                                Console.WriteLine("No admin registered yet.\n");
                            }
                            else
                            {
                                Console.WriteLine("Admin Details:\n");
                                Console.WriteLine("Full Name   : " + admin[0].fullname);
                                Console.WriteLine("Username    : " + admin[0].username);
                                Console.WriteLine("Email       : " + admin[0].Email);
                                Console.WriteLine("Phone No    : " + admin[0].Phonenumber);
                            }

                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------\n");
                    



                                break;
                            }

                    }
                    Console.WriteLine("Do you want to continue (Y/N)");
                    ch = Console.ReadLine();
                }
                while (ch == "Y" || ch == "y");

            }
        }
    }


