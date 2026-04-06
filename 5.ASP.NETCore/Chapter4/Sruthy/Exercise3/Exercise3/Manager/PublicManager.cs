using Exercise3.Enum;
using Exercise3.Exceptions;
using Exercise3.Interface;
using Exercise3.Model;
using Exercise3.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Exercise3.Manager
{
    public class PublicManager : IMenu
    {
        private IUserRepository userRepository = new UserRepository();

        public void DisplayMenu()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n1. Register\n2. Login\n3. Exit");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Register();
                        break;


                    case "2":
                        Login();
                        break;
                        

                    case "3":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }

        //  REGISTER
        private void Register()
        {
            try
            {
                User user = new User();

                Console.Write("Enter First Name: ");
                user.FirstName = Console.ReadLine();

                Console.Write("Enter Last Name: ");
                user.LastName = Console.ReadLine();

                Console.Write("Enter Email: ");
                user.Email = GetEmail();

                Console.Write("Enter Phone: ");
                user.Phone = GetPhoneNumber();

                Console.Write("Enter Password: ");
                user.Password = Console.ReadLine();

                Console.WriteLine("Select Role:");
                Console.WriteLine("1. Job Provider");
                Console.WriteLine("2. Job Seeker");

                string roleChoice = Console.ReadLine();

                if (roleChoice == "1")
                    user.Role = Roles.JobProvider;
                else if (roleChoice == "2")
                    user.Role = Roles.JobSeeker;
                else
                {
                    Console.WriteLine("Invalid role selected!");
                    return;
                }

                userRepository.Register(user);

                Console.WriteLine("Registration successful!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private string GetEmail()
        {
            try
            {
                Console.WriteLine("Please enter your email address:");
                string email = Console.ReadLine();
                Regex regex = new Regex("^\\S+@\\S+\\.\\S+$");

                if (!regex.IsMatch(email))
                    throw new InvalidFormatException("email was not in correct format :" + email);
                return email;
            }
            catch (InvalidFormatException ex)
            {
                Console.WriteLine(ex.Message + "\n");
                Console.WriteLine("try again...");
                return GetEmail();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\n");
                return GetEmail();
            }
        }

        private long GetPhoneNumber()
        {
            try
            {
                Console.WriteLine("Please enter your phone number:");
                long Phone = long.Parse(Console.ReadLine());
                return Phone;
            }
            catch (Exception e)
            {
                Console.WriteLine("Enter valid phone number");
                return GetPhoneNumber();
            }
        }

        //  LOGIN
        private void Login()
        {
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            var user = userRepository.Login(email, password);

            if (user != null)
            {
                Console.WriteLine("Login successful!");
                Console.WriteLine("Welcome " + user.FirstName);

                IMenu menu;

                //  Role-based redirection
                if (user.Role == Roles.JobProvider)
                    menu = new JobProviderManager();
                else
                    menu = new JobSeekerManager(user);
                menu.DisplayMenu();
            }
            else
            {
                Console.WriteLine("Invalid email or password");
            }
        }
    }
}
