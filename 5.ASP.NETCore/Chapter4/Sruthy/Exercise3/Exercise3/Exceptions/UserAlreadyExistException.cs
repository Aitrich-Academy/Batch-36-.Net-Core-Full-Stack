using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3.Exceptions
{
    public class UserAlreadyExistException : Exception
    {
        public UserAlreadyExistException()
        {

        }
        public UserAlreadyExistException(string email)
             : base(String.Format("User Already Exist with this email ", email))
        {

        }
    }
}
