using System;
using System.Collections.Generic;
using System.Text;

namespace Activity1
{
    internal class Car
    {
        public string brand;
        public string model;

        public Car(string brnd, string mdl)
        {
            brand = brnd;
            model = mdl;
        }
        public void carInfo()
        {
            Console.WriteLine("Car Details:\n--------------------------\nBrand: " + brand + "\nModel: " + model);
        }
    }
}
