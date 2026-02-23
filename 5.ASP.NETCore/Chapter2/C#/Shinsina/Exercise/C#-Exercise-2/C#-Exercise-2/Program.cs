using System;

internal class Program
{
    struct Admin
    {
        public string email;
        public string password;
    }

    struct Member
    {
        public int userid;
        public string name;
        public string email;
        public string designation;
        public string phonenumber; // Changed to string
    }

    private static void Main(string[] args)
    {
        Admin admin = new Admin
        {
            email = "admin@gmail.com",
            password = "1234"
        };

        Member[] members = new Member[2];
        int memberCount = 0;
        int userIdCounter = 1;

        bool isLoggedIn = false;

        Console.WriteLine("Welcome To Hire Me Now JobPortal!!");

        while (true)
        {
            if (!isLoggedIn)
            {
                Console.WriteLine("\n1. Login");
                Console.WriteLine("2. Exit");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.WriteLine("Enter your Email:");
                    string email = Console.ReadLine();

                    Console.WriteLine("Enter your Password:");
                    string password = Console.ReadLine();

                    if (email == admin.email && password == admin.password)
                    {
                        Console.WriteLine("Login Successfully");
                        isLoggedIn = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Credentials");
                    }
                }
                else if (choice == "2")
                {
                    break;
                }
            }
            else
            {
                Console.WriteLine("\n1. List All Company Members");
                Console.WriteLine("2. Add Company Member");
                Console.WriteLine("3. Logout");

                string adminChoice = Console.ReadLine();

                switch (adminChoice)
                {
                    case "1":
                        Console.WriteLine("\nUserId | Name | Designation | Email | Phone");

                        if (memberCount == 0)
                        {
                            Console.WriteLine("No members available.");
                        }
                        else
                        {
                            for (int i = 0; i < memberCount; i++)
                            {
                                Console.WriteLine(
                                    members[i].userid + " | " +
                                    members[i].name + " | " +
                                    members[i].designation + " | " +
                                    members[i].email + " | " +
                                    members[i].phonenumber
                                );
                            }
                        }
                        break;

                    case "2":
                        if (memberCount < members.Length)
                        {
                            Console.WriteLine("Enter member name:");
                            members[memberCount].name = Console.ReadLine();

                            Console.WriteLine("Enter designation:");
                            members[memberCount].designation = Console.ReadLine();

                            Console.WriteLine("Enter email:");
                            members[memberCount].email = Console.ReadLine();

                            Console.WriteLine("Enter phone number:");
                            members[memberCount].phonenumber = Console.ReadLine();

                            members[memberCount].userid = userIdCounter;
                            userIdCounter++;
                            memberCount++;

                            Console.WriteLine("Registration Complete");
                        }
                        else
                        {
                            Console.WriteLine("Member limit reached");
                        }
                        break;

                    case "3":
                        isLoggedIn = false;
                        Console.WriteLine("Logged out successfully");
                        break;

                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            }
        }
    }
}
