namespace HireMeNow_Wrkshp_MVC.Helper
{
    public static class SessionHelper
    {
        public static int GetUserId(HttpContext context)
        {
            return Convert.ToInt32(
            context.Session.GetString("UserId"));
        }
    }
}
