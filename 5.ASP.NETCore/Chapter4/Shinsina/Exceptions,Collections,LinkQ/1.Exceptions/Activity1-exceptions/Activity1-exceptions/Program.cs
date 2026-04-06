using Activity1_exceptions;
using System.Text.RegularExpressions;
using System.Xml.Linq;

internal class Program
{
    static User[] users = new User[10]; // Array to store users
    static int userCount = 0; // Track number of users

    private static void Main(string[] args)
    {
        while (true)
        {
            if (userCount >= users.Length)
            {
                Console.WriteLine("User storage is full.");
                break;
            }

            User user = new User();

            // ID Validation
            while (true)
                {
                    try
                    {
                        Console.Write("Enter ID: ");
                        string input = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(input))
                            throw new Exception("ID cannot be null.");

                        user.Id = Convert.ToInt32(input);
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("ID must be an integer.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                while (true) 
                {
                    try
                    {
                        Console.WriteLine("Enter your name");
                        string name = Console.ReadLine();

                        if (Regex.IsMatch(name, @"\d"))
                            throw new Exception("Name cannot contain numbers.");

                        user.Name = name;
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                // Email Validation
                while (true)
                {
                    try
                    {
                        Console.Write("Enter Email: ");
                        string email = Console.ReadLine();

                        if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                            throw new Exception("Invalid email format.");

                        user.Email = email;
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                // Phone Validation
                while (true)
                {
                    try
                    {
                        Console.Write("Enter Phone (10 digits): ");
                        string phone = Console.ReadLine();

                        if (!Regex.IsMatch(phone, @"^\d{10}$"))
                            throw new Exception("Phone must be exactly 10 digits.");

                        user.Phone = phone;
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                // Add user to array
                users[userCount] = user;
                userCount++;

                Console.WriteLine("\nUser added successfully!\n");

                // Display all users
                Console.WriteLine("User List:");
                for (int i = 0; i < userCount; i++)
                {
                    Console.WriteLine($"ID: {users[i].Id}, Name: {users[i].Name}, Email: {users[i].Email}, Phone: {users[i].Phone}");
                }

                Console.WriteLine("\nAdd another user? (y/n)");
                string choice = Console.ReadLine();

                if (choice.ToLower() != "y")
                    break;

            

            }
        }
    }
