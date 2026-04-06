using System;

namespace BankingSystem
{
    class InvalidAmountException : Exception
    {
        public InvalidAmountException(string message) : base(message) { }
    }

    class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message) : base(message) { }

    }

    class InvalidChoiceException : Exception
    {
        public InvalidChoiceException(string message) : base(message) { }

    }
}