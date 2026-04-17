using System;
using System.Collections.Generic;
using System.Text;

namespace MachineTest
{
    public class InvalidSalaryException:Exception
    {
        public InvalidSalaryException(string message):base(message)
        {
        }
    }
}
