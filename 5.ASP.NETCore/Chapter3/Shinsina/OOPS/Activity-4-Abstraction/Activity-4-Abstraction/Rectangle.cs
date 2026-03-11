using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Activity_4_Abstraction
{
    internal class Rectangle:Shape
    {
        public double Lenght;
        public double Height;
        public Rectangle(double l,double h) {
            Lenght = l;
            Height = h;
        }
        public override void CalculateArea()
        {
            double area = Lenght * Height;
            Console.WriteLine("Area of Rectangle: "+area);
        }
    }
}
