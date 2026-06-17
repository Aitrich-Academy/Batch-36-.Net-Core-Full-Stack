using System;
namespace HireMeNow_Wrkshp_MVC.Exception
{
    public class UserNotFoundException : System.Exception
    {
        public UserNotFoundException()
        {
        }

        public UserNotFoundException(string message)
            : base(message)
        {
        }
    }
}