using JobPortalApplication.Interfaces;
using JobPortalApplication.Managers;

internal class Program
{
    private static void Main(string[] args)
    {

        IMenu menu = new JobPortal();
        menu.Start();
    }
}