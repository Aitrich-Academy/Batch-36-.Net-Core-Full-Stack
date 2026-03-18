using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y; 
        }
        public double Add(double x, double y)
        {
            return x + y;
        }
        public int Add(int x, int y, int z)
        {
            return x + y + z; 
        }
        
    }
}
