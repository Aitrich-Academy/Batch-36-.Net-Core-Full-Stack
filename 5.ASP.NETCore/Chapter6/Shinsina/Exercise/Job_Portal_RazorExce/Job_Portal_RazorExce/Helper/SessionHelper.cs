namespace Job_Portal_RazorExce.Helper
{
    public class SessionHelper
    {
        public static void SetUserId(HttpContext context, int userId)
        {
            context.Session.SetInt32("UserId", userId);
        }

        public static int GetUserId(HttpContext context)
        {
            return context.Session.GetInt32("UserId") ?? 0;
        }
    }
}
