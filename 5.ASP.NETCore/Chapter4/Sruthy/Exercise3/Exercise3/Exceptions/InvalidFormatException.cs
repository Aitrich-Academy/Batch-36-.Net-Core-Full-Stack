using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3.Exceptions
{
    public class InvalidFormatException : Exception
    {
        public InvalidFormatException() { }
        public InvalidFormatException(string message)
        : base(message)
        {
        }
    }
}
