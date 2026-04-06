using System;
using System.Collections.Generic;
using System.Text;

namespace JobPortalApplication.Exceptions
{
    public class UserAlreadyExistException : Exception
    {
        public UserAlreadyExistException(string msg) : base(msg) { }
    }
}
