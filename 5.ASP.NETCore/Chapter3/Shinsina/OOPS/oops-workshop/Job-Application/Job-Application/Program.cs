using Job_Application.Managers;

internal class Program
{
    private static void Main(string[] args)
    {
       
        JobSeekerManager manager = new JobSeekerManager();
        manager.showMainMenu();

    }
}