
using Workshop1.Manager;
internal class Program
{
    private static void Main(string[] args)
    {
        Admin admin = new Admin();

        while (true)
        {
            Console.WriteLine("\nMAIN MENU");
            Console.WriteLine("1 Register");
            Console.WriteLine("2 Login");
            Console.WriteLine("3 Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    admin.Register();
                    break;

                case 2:
                    admin.Login();
                    break;

                case 3:
                    return;
            }
        }
    }
}