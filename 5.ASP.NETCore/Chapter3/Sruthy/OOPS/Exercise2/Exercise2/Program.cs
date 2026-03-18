
using Exercise2.Model;
using Exercise2.Enum;
using Exercise2.Manager;
using Exercise2.Utils;
internal class Program
{
    private static void Main(string[] args)
    {
        PublicManager manager = new PublicManager();

        while (true)
        {
            Console.WriteLine("\n1 Register");
            Console.WriteLine("2 Login");
            Console.WriteLine("3 Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                User user = new User();

                Console.Write("First Name: ");
                user.FirstName = Console.ReadLine();

                Console.Write("Last Name: ");
                user.LastName = Console.ReadLine();

                Console.Write("Email: ");
                user.Email = Console.ReadLine();

                Console.Write("Phone: ");
                user.Phone = Console.ReadLine();

                Console.Write("Password: ");
                user.Password = Console.ReadLine();

                Console.Write("Role (0=Admin,1=JobSeeker): ");
                user.Role = (Roles)Convert.ToInt32(Console.ReadLine());

                manager.Register(user);
            }

            else if (choice == 2)
            {
                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Password: ");
                string pass = Console.ReadLine();

                manager.Login(email, pass);
            }

            else
            {
                break;
            }
        }
    }
}