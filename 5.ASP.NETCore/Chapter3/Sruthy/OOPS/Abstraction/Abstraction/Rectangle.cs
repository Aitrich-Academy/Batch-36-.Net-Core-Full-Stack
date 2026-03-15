using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    class Rectangle : Shape
    {
        public double Length;
        public double Width;

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override double CalculateArea()
        {
            return Length*Width;

        }

    }
}
