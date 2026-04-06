using Activity1;
using System.Text.RegularExpressions;

internal class Program
{
    static User[] users = new User[100]; // Array to store users
    static int count = 0; // Track number of users
    private static void Main(string[] args)
    {
        
          while (true)
          {
                User user = new User();

                // ID Validation
                while (true)
                {
                    try
                    {
                        Console.Write("Enter ID: ");
                        string input = Console.ReadLine();

                        if (string.IsNullOrEmpty(input))
                            throw new Exception("ID cannot be null.");

                        user.ID = int.Parse(input);
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

                // Name Validation
                while (true)
                {
                    try
                    {
                        Console.Write("Enter Name: ");
                        user.Name = Console.ReadLine();

                        foreach (char c in user.Name)
                        {
                            if (char.IsDigit(c))
                                throw new Exception("Name cannot contain numbers.");
                        }

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
                        user.Email = Console.ReadLine();

                        string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

                        if (!Regex.IsMatch(user.Email, pattern))
                            throw new Exception("Invalid email format.");

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
                        Console.Write("Enter Phone: ");
                        user.Phone = Console.ReadLine();

                        if (user.Phone.Length != 10 || !long.TryParse(user.Phone, out _))
                            throw new Exception("Phone must be exactly 10 digits.");

                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                // Add user to array
                users[count] = user;
                count++;

                Console.WriteLine("\nUser added successfully!\n");

                // Display all users
                Console.WriteLine("------ User List ------");
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("ID: " + users[i].ID);
                    Console.WriteLine("Name: " + users[i].Name);
                    Console.WriteLine("Email: " + users[i].Email);
                    Console.WriteLine("Phone: " + users[i].Phone);
                    Console.WriteLine("----------------------");
                }
            
          }
    }
}
