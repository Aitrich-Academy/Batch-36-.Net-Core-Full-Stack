using System;
using System.Collections.Generic;
using System.Text;

namespace JobPortalApplication.Exceptions
{
    public class InvalidFormatException : Exception
    {
        public InvalidFormatException(string msg) : base(msg) { }
    }
}
