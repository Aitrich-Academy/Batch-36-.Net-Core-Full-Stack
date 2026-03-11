using System;
using System.Collections.Generic;
using System.Text;

namespace Activity_4_Abstraction
{
    internal class Circle:Shape
    {
        public double radius;

        // Constructor
        public Circle(double r)
        {
            radius = r;
        }
        public override void CalculateArea()
        {
            double area = 3.14 * radius * radius;
            Console.WriteLine("Circle Area: " + area);
        }
    }
}
