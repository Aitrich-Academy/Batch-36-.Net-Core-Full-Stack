using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    class Circle:Shape
    {
        public double Radius;
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

    }
}
