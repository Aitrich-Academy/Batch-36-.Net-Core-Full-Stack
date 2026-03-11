using System;
using System.Collections.Generic;
using System.Text;

namespace Activity_6_Polymorphism
{
    internal class Rectangle:Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Rectangle");
        }
    }
}
