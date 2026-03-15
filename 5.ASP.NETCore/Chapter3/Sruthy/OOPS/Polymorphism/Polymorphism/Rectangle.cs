using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw Rectangle");
        }
    }
}
