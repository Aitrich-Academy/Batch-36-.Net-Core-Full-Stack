using JobPortalApplication.Enums;
using JobPortalApplication.Exceptions;
using JobPortalApplication.Interfaces;
using JobPortalApplication.Models;
using JobPortalApplication.Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace JobPortalApplication.Managers
{
    public class UserManager
    {
        UserRepository repo = new UserRepository();
        public User LoggedUser;
        private IUserRepository userRepo = new UserRepository();
       
        public void Register()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your email: ");
            string email = Console.ReadLine();

            if (!Regex.IsMatch(email, @"^\S+@\S+\.\S+$"))
                throw new InvalidFormatException("Invalid Email Format");

            if (repo.GetUsers().Any(u => u.Email == email))
                throw new UserAlreadyExistException("User already exists");

            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            Console.Write("Enter your role (Provider/Seeker): ");
            Role role = Enum.Parse<Role>(Console.ReadLine(), true);

            repo.AddUser(new User
            {
                Id = repo.GetUsers().Count + 1,
                Name = name,
                Email = email,
                Password = password,
                Role = role
            });

            Console.WriteLine("Registration successful");
        }

        public void Login()
        {

            Console.Write("Enter your email: ");
            string email = Console.ReadLine();

            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            var user = repo.GetUser(email, password);

            if (user == null)
            {
                Console.WriteLine("Invalid credentials. Please try again.\n");

                  LoggedUser = null;   // ✅ IMPORTANT FIX
                return;
                Console.WriteLine("Invalid credentials");
                return;

            }

            LoggedUser = user;

            Console.WriteLine($"Login successful Welcome {user.Name}");

        }

    }
}
