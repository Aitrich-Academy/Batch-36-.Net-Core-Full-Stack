using System;
using System.Collections.Generic;
using System.Text;

namespace Activity2
{
    class InvalidAmountException : Exception
    {
        public InvalidAmountException(string msg) : base(msg) { }
    }

    class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string msg) : base(msg) { }
    }

}
